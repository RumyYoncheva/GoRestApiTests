using GoRestTests.Support;
using Microsoft.Extensions.Configuration;

namespace GoRestApiTests.Support
{
    public class Config
    {
        private TestContext _context;
        public string BaseUrl { get; set; }

        public Config(TestContext context)
        {
            _context = context;
        }

        public void UseConfig()
        {

            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("config.json")
                .Build();

            BaseUrl = config.GetSection("Settings").GetSection("BaseUrl").ToString();
        }
    }
}