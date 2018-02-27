using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.IO;

namespace CameraBazaar.Web.Infrastructure.Filters
{
    public class LogAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            using (var writer = new StreamWriter("Logs/log.txt", true))
            {
                var dateTime = DateTime.UtcNow;
                var ipAddress = context.HttpContext.Connection.RemoteIpAddress;
                var username = context.HttpContext.User?.Identity?.Name ?? "Anonymous";
                var controller = context.Controller.GetType().Name;
                var action = context.ActionDescriptor.RouteValues["action"];

                var logEntry = $"{dateTime} – {ipAddress} – {username} – {controller}.{action}";

                if (context.Exception != null)
                {
                    logEntry = $"[!] {logEntry} -{context.Exception.GetType().Name} – {context.Exception.Message}";
                }

                writer.WriteLine(logEntry);
            }
        }
    }
}
