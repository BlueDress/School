using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebServer.Server.Common;
using WebServer.Server.Http.Contracts;

namespace WebServer.Server.Http
{
    public class HttpHeaderCollection : IHttpHeaderCollection
    {
        private readonly Dictionary<string, List<HttpHeader>> headers;

        public HttpHeaderCollection()
        {
            this.headers = new Dictionary<string, List<HttpHeader>>();
        }

        public void Add(HttpHeader header)
        {
            NullValidator.ThrowIfNull(header, nameof(header));

            if (!this.headers.ContainsKey(header.Key))
            {
                this.headers[header.Key] = new List<HttpHeader>();
            }

            this.headers[header.Key].Add(header);
        }

        public bool ContainsKey(string key)
        {
            NullValidator.ThrowIfNull(key, nameof(key));

            return this.headers.ContainsKey(key);
        }

        public List<HttpHeader> GetHeader(string key)
        {
            NullValidator.ThrowIfNull(key, nameof(key));

            if (!this.headers.ContainsKey(key))
            {
                throw new InvalidOperationException($"The given key {key} is not present in the headers collection");
            }

            return this.headers[key];
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            foreach (var header in this.headers)
            {
                foreach (var value in header.Value)
                {
                    result.AppendLine($"{header.Key}: {value.Value}");
                }
            }

            return result.ToString();
        }
    }
}
