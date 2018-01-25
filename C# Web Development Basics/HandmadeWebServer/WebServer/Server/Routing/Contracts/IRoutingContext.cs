using System.Collections.Generic;
using WebServer.Server.Handlres;

namespace WebServer.Server.Routing.Contracts
{
    public interface IRoutingContext
    {
        IEnumerable<string> Parameters { get; }

        RequestHandler RequestHandler { get; }
    }
}
