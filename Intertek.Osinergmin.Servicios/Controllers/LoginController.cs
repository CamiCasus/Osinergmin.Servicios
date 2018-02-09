using Application.Dto;
using Application.MainModule.Interfaces;
using Distributed.Services.Security;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Distributed.Services.Controllers
{
    [Produces("application/json")]
    [Route("api/Login")]
    public class LoginController : Controller
    {
        private readonly IUsuarioAppService _usuarioAppService;
        private readonly IJwtFactory _jwtFactory;
        private readonly JwtIssuerOptions _jwtOptions;

        public LoginController(
            IUsuarioAppService usuarioAppService, 
            IJwtFactory jwtFactory,
            IOptions<JwtIssuerOptions> jwtOptions)
        {
            _usuarioAppService = usuarioAppService;
            _jwtFactory = jwtFactory;
            _jwtOptions = jwtOptions.Value;
        }

        [HttpPost("/api/autenticar")]
        public async Task<IActionResult> Autenticar([FromBody] UsuarioLoginDto login)
        {
            if (login == null)
            {
                return BadRequest();
            }

            var identity = await GetClaimsIdentity(login.Usuario, login.Password);
            if (identity == null)
            {
                return BadRequest();
            }

            var jwt = await Tokens.GenerateJwt(identity, _jwtFactory, login.Usuario, _jwtOptions, new JsonSerializerSettings { Formatting = Formatting.Indented });
            return new OkObjectResult(jwt);
        }

        private async Task<ClaimsIdentity> GetClaimsIdentity(string userName, string password)
        {
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
                return await Task.FromResult<ClaimsIdentity>(null);

            // get the user to verifty
            var userToVerify = _usuarioAppService.Autenticar(userName, password);

            if (userToVerify == null) return await Task.FromResult<ClaimsIdentity>(null);

            return await Task.FromResult(_jwtFactory.GenerateClaimsIdentity(userName, userToVerify.Id.ToString()));
        }
    }
}