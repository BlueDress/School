using WebServer.Server.Common;
using WebServer.Server.Enums;

namespace WebServer.Server.Http.Response
{
    public class RedirectResponse : HttpResponse
    {
        public RedirectResponse(string redirectUrl)
        {
            NullValidator.ThrowIfNullOrEmpty(redirectUrl, nameof(redirectUrl));

            this.StatusCode = HttpStatusCode.Found;
            this.HeaderCollection.Add(new HttpHeader("Location", redirectUrl));
        }
    }
}
