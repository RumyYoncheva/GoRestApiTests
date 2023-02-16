using GoRestApiTests.Support;
using Microsoft.Extensions.DependencyInjection;

public class Services
{
    public void ConfigureServices()
    {
        var services = new ServiceCollection();
        services.AddSingleton<HttpClientService>();
        services.AddSingleton<Config>();        
    }
}