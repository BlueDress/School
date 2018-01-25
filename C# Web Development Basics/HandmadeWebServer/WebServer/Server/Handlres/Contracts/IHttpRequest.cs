using System.Collections.Generic;
using WebServer.Server.Enums;
using WebServer.Server.Http;

namespace WebServer.Server.Handlres.Contracts
{
    public interface IHttpRequest
    {
        IDictionary<string, string> FormData { get; }

        HttpHeaderCollection HeaderCollection { get; }

        string Path { get; }

        IDictionary<string, string> QuerryParameters { get; }

        HttpRequestMethod RequestMethod { get; }

        string Url { get; }

        IDictionary<string, string> UrlParameters { get; }

        ICollection<HttpCookie> CookieCollection { get; }

        void AddUrlParameter(string key, string value);
    }
}
