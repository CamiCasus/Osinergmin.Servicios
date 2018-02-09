using System;
using System.Reflection;
using System.Text;
using Application.Dto.AutoMapper;
using Application.MainModule;
using Application.MainModule.Interfaces;
using AutoMapper;
using Distributed.Services.Handler;
using Distributed.Services.Security;
using Domain.MainModule.Osinergmin;
using Infraestructura.Data.MainModule;
using Infraestructura.Data.MainModule.Core;
using Infraestructura.Data.MainModule.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace Intertek.Osinergmin.Servicios
{
    public class Startup
    {
        private const string SecretKey = "iNivDmHLpUA223sqsfhqGbMRdRj1PVkH"; // todo: get this from somewhere secure
        private readonly SymmetricSecurityKey _signingKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(SecretKey));

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<MainModuleContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddAutoMapper(typeof(AutoMapperConfiguration).GetTypeInfo().Assembly);
            services.AddSingleton<IJwtFactory, JwtFactory>();

            ConfigurarSeguridad(services);

            services.AddMvc();
            services.AddCors();

            services.AddSingleton(Configuration.GetSection("Osinergmin").Get<OsinergminConfig>());

            services.AddScoped<DbContext, MainModuleContext>();
            services.AddScoped<IGuiaAppService, GuiaAppService>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IGuiaRepository, GuiaRepository>();
            services.AddScoped<IDetalleGuiaRepository, DetalleGuiaRepository>();
            services.AddScoped<IProductoAppService, ProductoAppService>();
            services.AddScoped<IProductoRepository, ProductoRepository>();
            services.AddScoped<IItemTablaAppService, ItemTablaAppService>();
            services.AddScoped<IItemTablaRepository, ItemTablaRepository>();
            services.AddScoped<IUsuarioAppService, UsuarioAppService>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IOsinergminRepository, OsinergminRepository>();

            var host = new WebHostBuilder().UseKestrel(o => { o.Limits.KeepAliveTimeout = TimeSpan.FromMinutes(30); });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            app.UseMiddleware<ExceptionHandlingMiddleware>();
            app.UseAuthentication();
            app.UseMvc();
        }

        private void ConfigurarSeguridad(IServiceCollection services)
        {
            var jwtAppSettingOptions = Configuration.GetSection(nameof(JwtIssuerOptions));

            services.Configure<JwtIssuerOptions>(options =>
            {
                options.Issuer = jwtAppSettingOptions[nameof(JwtIssuerOptions.Issuer)];
                options.Audience = jwtAppSettingOptions[nameof(JwtIssuerOptions.Audience)];
                options.SigningCredentials = new SigningCredentials(_signingKey, SecurityAlgorithms.HmacSha256);
            });

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidIssuer = jwtAppSettingOptions[nameof(JwtIssuerOptions.Issuer)],
                        ValidateAudience = true,
                        ValidAudience = jwtAppSettingOptions[nameof(JwtIssuerOptions.Audience)],
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = _signingKey
                    };
                });          

            // api user claim policy
            services.AddAuthorization(options =>
            {
                options.AddPolicy("ApiUser", policy => policy.RequireClaim(Constants.Strings.JwtClaimIdentifiers.Rol, Constants.Strings.JwtClaims.ApiAccess));
            });
        }
    }
}
