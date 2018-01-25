using System.Text;
using WebServer.Server.Enums;
using WebServer.Server.Http.Contracts;

namespace WebServer.Server.Http.Response
{
    public abstract class HttpResponse : IHttpResponse
    {
        protected HttpResponse()
        {
            this.HeaderCollection = new HttpHeaderCollection();
        }
        
        public HttpHeaderCollection HeaderCollection { get; }

        public HttpStatusCode StatusCode { get; protected set; }

        public string StatusCodeMessage => this.StatusCode.ToString();

        public override string ToString()
        {
            var response = new StringBuilder();

            response.AppendLine($"HTTP/1.1 {(int)this.StatusCode} {this.StatusCodeMessage}");

            response.AppendLine(this.HeaderCollection.ToString());
            response.AppendLine();
            
            return response.ToString();
        }
    }
}
