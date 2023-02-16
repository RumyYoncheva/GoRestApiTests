using GoRestTests.Models;
using GoRestTests.Support;
using Newtonsoft.Json;

namespace GoRestApiTests.Support
{
    public class HttpClientService
    {
        private TestContext _context;
        private HttpClient _httpClient;

        public HttpClientService(TestContext context, HttpClient httpClient)
        {
            _context = context;
            _httpClient = httpClient;
        }

        public async Task GetUsers()
        {
            var url = String.Concat(_context.BaseUrl, "posts");

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(url)
            };

            var result = await _httpClient.SendAsync(request).Result.Content.ReadAsStringAsync();

            _context.GetRequestResult = JsonConvert.DeserializeObject<GetUsersModel>(result);
        }
    }
}
