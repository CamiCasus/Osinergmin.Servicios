using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Distributed.Services.Handler
{
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate next;
        private readonly ILogger _logger;

        public ExceptionHandlingMiddleware(RequestDelegate next)
        {
            this.next = next;
            //_logger = logger;
        }

        public async Task Invoke(HttpContext context /* other scoped dependencies */)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex, "");
                throw;
            }
        }

        //private static Task HandleExceptionAsync(HttpContext context, Exception exception)
        //{
            //var code = HttpStatusCode.InternalServerError; // 500 if unexpected

            //if (exception is MyNotFoundException) code = HttpStatusCode.NotFound;
            //else if (exception is MyUnauthorizedException) code = HttpStatusCode.Unauthorized;
            //else if (exception is MyException) code = HttpStatusCode.BadRequest;

            //var result = JsonConvert.SerializeObject(new { error = exception.Message });
            //context.Response.ContentType = "application/json";
            //context.Response.StatusCode = (int)code;
            //return context.Response.WriteAsync(result);
        //}

        //public async Task Invoke(HttpContext context)
        //{
        //    try
        //    {
        //        await _next.Invoke(context);
        //        if (context.Response.StatusCode == StatusCodes.Status404NotFound)
        //        {
        //            var statusCodeFeature = context.Features.Get<IStatusCodePagesFeature>();
        //            if (statusCodeFeature == null || !statusCodeFeature.Enabled)
        //            {
        //                // there's no StatusCodePagesMiddleware in app
        //                if (!context.Response.HasStarted)
        //                {
        //                    var view = new ErrorPage(new ErrorPageModel());
        //                    await view.ExecuteAsync(context);
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        // TODO: stay tuned
        //        throw;
        //    }
        //}
    }
}
