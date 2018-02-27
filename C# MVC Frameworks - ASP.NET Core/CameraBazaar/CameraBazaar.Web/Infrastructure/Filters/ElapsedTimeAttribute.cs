using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Diagnostics;
using System.IO;

namespace CameraBazaar.Web.Infrastructure.Filters
{
    public class ElapsedTimeAttribute : ActionFilterAttribute
    {
        private Stopwatch stopwatch;

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            this.stopwatch = Stopwatch.StartNew();
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            using (var writer = new StreamWriter("Logs/elapsedTime.txt", true))
            {
                var dateTime = DateTime.UtcNow;
                var controller = context.Controller.GetType().Name;
                var action = context.ActionDescriptor.RouteValues["action"];

                stopwatch.Stop();

                var logEntry = $"{dateTime} – {controller}.{action} – {stopwatch.Elapsed}";

                writer.WriteLine(logEntry);
            }
        }
    }
}
