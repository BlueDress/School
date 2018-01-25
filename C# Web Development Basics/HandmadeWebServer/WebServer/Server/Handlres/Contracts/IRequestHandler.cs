using WebServer.Server.Http.Contracts;

namespace WebServer.Server.Handlres.Contracts
{
    public interface IRequestHandler
    {
        IHttpResponse Handle(IHttpContext context);
    }
}
