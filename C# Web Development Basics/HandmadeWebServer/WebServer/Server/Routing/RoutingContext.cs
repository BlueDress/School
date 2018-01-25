using System.Collections.Generic;
using WebServer.Server.Common;
using WebServer.Server.Handlres;
using WebServer.Server.Routing.Contracts;

namespace WebServer.Server.Routing
{
    public class RoutingContext : IRoutingContext
    {
        public RoutingContext(RequestHandler requestHandler, IEnumerable<string> parameters)
        {
            NullValidator.ThrowIfNull(requestHandler, nameof(requestHandler));
            NullValidator.ThrowIfNull(parameters, nameof(parameters));

            this.RequestHandler = requestHandler;
            this.Parameters = parameters;
        }

        public IEnumerable<string> Parameters { get; private set; }

        public RequestHandler RequestHandler { get; private set; }
    }
}
