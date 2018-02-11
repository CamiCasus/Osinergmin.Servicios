using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Distributed.Services.Logging
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate next;
        private readonly ILogger<LoggingMiddleware> logger;

        public LoggingMiddleware(
            RequestDelegate next,
            ILogger<LoggingMiddleware> logger)
        {
            this.next = next;
            this.logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            var message = new
            {
                GreetingTo = "James Bond",
                GreetingTime = "Morning",
                GreetingType = "Good"
            };
            this.logger.LogInformation("Inoke executing {@message}", message);

            await context.Response.WriteAsync("Hello Logging!");

            this.logger.LogInformation(
                "Inoke executed by {developer} at {time}", "Tahir", DateTime.Now);
        }
    }
}
