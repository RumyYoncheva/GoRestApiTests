namespace GoRestApiTests.Support
{
    [Binding]
    public sealed class Hooks
    {
        [BeforeScenario]
        public void AddServices()
        {
            var start = new Services();
            start.ConfigureServices();
        }
    }
}
