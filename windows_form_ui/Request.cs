using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;

namespace windows_form_ui
{
    public static class Request
    {
        private static HttpClient client;
        private static readonly Dictionary<string, Dictionary<string, string>> headers = new Dictionary<string, Dictionary<string, string>>
        {
            { "github", new Dictionary<string, string>
                {
                    { "scheme", "https"},
                    { "accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9"},
                    { "accept-encoding", "gzip, deflate, br"},
                    { "accept-language", "pt-BR,pt;q=0.9,en-US;q=0.8,en;q=0.7"},
                    { "cache-control", "no-cache"},
                    { "pragma", "no-cache"},
                    { "sec-ch-ua-mobile", "?0"},
                    { "sec-fetch-dest", "document"},
                    { "sec-fetch-mode", "navigate"},
                    { "sec-fetch-site", "none"},
                    { "sec-fetch-user", "?1"},
                    { "upgrade-insecure-requests", "1"}
                }
            }
        };
        private static FormUrlEncodedContent content;
        private static HttpResponseMessage response;
        private static TimeSpan timeout = TimeSpan.FromSeconds(5);
        public static string Post(string endpoint, string header, List<KeyValuePair<string, string>> contentParam)
        {
            InstanceClient(endpoint, header, contentParam);
            response = client.PostAsync(client.BaseAddress, content).GetAwaiter().GetResult();
            return response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
        }
        public static string Get(string endpoint, string header)
        {
            InstanceClient(endpoint, header);
            response = client.GetAsync(endpoint).GetAwaiter().GetResult();
            return response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
        }
        private static void InstanceClient(string endpoint, string header, List<KeyValuePair<string, string>> contentParam = null)
        {
            client = new HttpClient()
            {
                Timeout = timeout,
                BaseAddress = new Uri(endpoint)
            };
            
            List<KeyValuePair<string, string>> encodedContent = new List<KeyValuePair<string, string>>();
            foreach (var item in headers[header])
                encodedContent.Add(new KeyValuePair<string, string>(item.Key, item.Value));

            content = new FormUrlEncodedContent(encodedContent);
        }
    }
}
