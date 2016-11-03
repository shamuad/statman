using System.Net;
using System.Net.Http;

namespace Statman.Api.Client
{
    public class HealthCheckClient : IHealthCheckClient
    {
        private HttpClient httpClient;

        public HealthCheckClient(HttpClient client)
        {
            httpClient = client;
        }

        public bool BasicStatusCheck(string url) {

            var response = httpClient.GetAsync(url).Result;

            return response.StatusCode == HttpStatusCode.OK;
        }
    }
}
