using System;
using System.Collections.Generic;
using System.Linq;
using WebServer.Server.Enums;
using WebServer.Server.Handlres;
using WebServer.Server.Routing.Contracts;

namespace WebServer.Server.Routing
{
    public class AppRouteConfig : IAppRouteConfig
    {
        private Dictionary<HttpRequestMethod, IDictionary<string, RequestHandler>> routes;

        public AppRouteConfig()
        {
            this.routes = new Dictionary<HttpRequestMethod, IDictionary<string, RequestHandler>>();

            var availableMethods = Enum.GetValues(typeof(HttpRequestMethod)).Cast<HttpRequestMethod>();

            foreach (var method in availableMethods)
            {
                this.routes[method] = new Dictionary<string, RequestHandler>();
            }
        }

        public IReadOnlyDictionary<HttpRequestMethod, IDictionary<string, RequestHandler>> Routes => this.routes;

        public void AddRoute(string route, RequestHandler handler)
        {
            var handlerName = handler.GetType().Name.ToLower();

            if (handlerName.Contains("get"))
            {
                this.routes[HttpRequestMethod.GET].Add(route, handler);
            }
            else if (handlerName.Contains("post"))
            {
                this.routes[HttpRequestMethod.POST].Add(route, handler);
            }
            else
            {
                throw new InvalidOperationException("Invalid handler");
            }
        }
    }
}
