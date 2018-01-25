using System.Collections.Generic;
using WebServer.Server.Enums;
using WebServer.Server.Handlres;

namespace WebServer.Server.Routing.Contracts
{
    public interface IAppRouteConfig
    {
        IReadOnlyDictionary<HttpRequestMethod, IDictionary<string, RequestHandler>> Routes { get; }

        void AddRoute(string route, RequestHandler handler);
    }
}
