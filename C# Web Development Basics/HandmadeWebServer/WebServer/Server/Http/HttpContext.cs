using WebServer.Server.Handlres.Contracts;
using WebServer.Server.Http.Contracts;

namespace WebServer.Server.Http
{
    public class HttpContext : IHttpContext
    {
        public readonly IHttpRequest request;

        public HttpContext(string requestString)
        {
            this.request = new HttpRequest(requestString);
        }

        public IHttpRequest Request => this.request;
    }
}
