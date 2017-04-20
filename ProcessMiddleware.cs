using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestProjectForServer
{
    public class ProcessMiddleware
    {
        private readonly RequestDelegate _nextMiddleware;

        public ProcessMiddleware(RequestDelegate next)
        {
            _nextMiddleware = next;
        }
        public async Task Invoke(HttpContext context)
        {
            context.Response.WriteAsync("Completed");
        }
    }
}
