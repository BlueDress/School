using System;
using System.Collections.Generic;
using System.Linq;
using WebServer.Server.Common;
using WebServer.Server.Enums;
using WebServer.Server.Exceptions;
using WebServer.Server.Handlres.Contracts;
using WebServer.Server.Http.Contracts;

namespace WebServer.Server.Http
{
    public class HttpRequest : IHttpRequest
    {
        public HttpRequest(string requestString)
        {
            NullValidator.ThrowIfNullOrEmpty(requestString, nameof(requestString));

            this.HeaderCollection = new HttpHeaderCollection();

            this.FormData = new Dictionary<string, string>();

            this.QuerryParameters = new Dictionary<string, string>();

            this.UrlParameters = new Dictionary<string, string>();

            this.CookieCollection = new List<HttpCookie>();

            this.ParseRequest(requestString);
        }

        public IDictionary<string, string> FormData { get; } 

        public HttpHeaderCollection HeaderCollection { get; }

        public string Path { get; set; }

        public IDictionary<string, string> QuerryParameters { get; }

        public HttpRequestMethod RequestMethod { get; set; }

        public string Url { get; set; }

        public IDictionary<string, string> UrlParameters { get; }

        public ICollection<HttpCookie> CookieCollection { get; }

        public void AddUrlParameter(string key, string value)
        {
            NullValidator.ThrowIfNullOrEmpty(key, nameof(key));
            NullValidator.ThrowIfNullOrEmpty(value, nameof(value));

            this.UrlParameters[key] = value;
        }

        private void ParseRequest(string requestString)
        {
            var requestLines = requestString.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

            if (!requestLines.Any())
            {
                throw new InvalidOperationException("Request is not valid");
            }

            var requestLine = requestLines[0].Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (requestLine.Length != 3 || !requestLine[2].ToLower().Equals("http/1.1"))
            {
                throw new BadRequestException("Invalid request line");
            }

            this.RequestMethod = this.ParseRequestMethod(requestLine[0].ToUpper());
            this.Url = requestLine[1];
            this.Path = this.Url.Split(new[] { '?', '#' }, StringSplitOptions.RemoveEmptyEntries)[0];

            this.ParseHeaders(requestLines);
            this.ParseCookies();
            this.ParseParameters();

            if (this.RequestMethod == HttpRequestMethod.POST)
            {
                this.ParseQuerry(requestLines[requestLines.Length - 1], this.FormData);
            }
        }

        private HttpRequestMethod ParseRequestMethod(string requestMethodString)
        {
            try
            {
                var method = (HttpRequestMethod)Enum.Parse(typeof(HttpRequestMethod), requestMethodString);
                return method;
            }
            catch (Exception)
            {
                throw new BadRequestException("Invalid request method");
            }
        }
        
        private void ParseHeaders(string[] requestLines)
        {
            var endIndex = Array.IndexOf(requestLines, string.Empty);

            for (int i = 1; i < endIndex; i++)
            {
                var headerArgs = requestLines[i].Split(new[] { ": " }, StringSplitOptions.None);

                if (headerArgs.Length != 2)
                {
                    throw new BadRequestException("Invalid request headers");
                }

                var headerKey = headerArgs[0];
                var headerValue = headerArgs[1];

                var header = new HttpHeader(headerKey, headerValue);
                this.HeaderCollection.Add(header);
            }

            if (!this.HeaderCollection.ContainsKey("Host"))
            {
                throw new BadRequestException("Invalid request headers");
            }
        }

        private void ParseParameters()
        {
            if (!this.Url.Contains('?'))
            {
                return;
            }

            var querry = this.Url.Split('?')[1];
            this.ParseQuerry(querry, this.QuerryParameters);
        }

        private void ParseQuerry(string querry, IDictionary<string, string> querryParameters)
        {
            if (!querry.Contains("="))
            {
                return;
            }

            var querryPairs = querry.Split('&');

            foreach (var querryPair in querryPairs)
            {
                var querryArgs = querryPair.Split('=');

                if (querryArgs.Length != 2)
                {
                    continue;
                }

                querryParameters[querryArgs[0]] = querryArgs[1];
            }
        }

        private void ParseCookies()
        {
            if (this.HeaderCollection.ContainsKey("Cookie"))
            {
                var cookiesList = this.HeaderCollection.GetHeader("Cookie");

                foreach (var header in cookiesList)
                {
                    var cookieString = header.Value;

                    if (string.IsNullOrEmpty(cookieString))
                    {
                        return;
                    }

                    var cookies = cookieString.Split(';');

                    foreach (var c in cookies)
                    {
                        if (!c.Contains("="))
                        {
                            continue;
                        }

                        var cookieArgs = c.Split('=');

                        var cookieKey = cookieArgs[0];
                        var cookieValue = cookieArgs[1];

                        var cookie = new HttpCookie(cookieKey, cookieValue, false);
                        this.CookieCollection.Add(cookie);
                    }
                }
            }
        }
    }
}
