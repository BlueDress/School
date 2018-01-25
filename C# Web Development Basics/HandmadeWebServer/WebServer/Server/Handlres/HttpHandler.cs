using System.Text.RegularExpressions;
using WebServer.Server.Handlres.Contracts;
using WebServer.Server.Http.Contracts;
using WebServer.Server.Http.Response;
using WebServer.Server.Routing.Contracts;

namespace WebServer.Server.Handlres
{
    public class HttpHandler : IRequestHandler
    {
        private readonly IServerRouteConfig serverRouteConfig;

        public HttpHandler(IServerRouteConfig serverRouteConfig)
        {
            this.serverRouteConfig = serverRouteConfig;
        }

        public IHttpResponse Handle(IHttpContext context)
        {
            foreach (var kvp in this.serverRouteConfig.Routes[context.Request.RequestMethod])
            {
                var pattern = kvp.Key;
                var regex = new Regex(pattern);
                var match = regex.Match(context.Request.Path);

                if (!match.Success)
                {
                    continue;
                }

                foreach (var parameter in kvp.Value.Parameters)
                {
                    context.Request.AddUrlParameter(parameter, match.Groups[parameter].Value);
                }

                return kvp.Value.RequestHandler.Handle(context);
            }

            return new NotFoundResponse();
        }
    }
}
