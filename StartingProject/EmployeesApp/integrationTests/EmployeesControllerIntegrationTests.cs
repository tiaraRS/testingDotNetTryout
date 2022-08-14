namespace integrationTests
{
    public class EmployeesControllerIntegrationTests : IClassFixture<TestingWebAppFactory<Program>>
    {
        private readonly HttpClient _client;

        public EmployeesControllerIntegrationTests(TestingWebAppFactory<Program> factory)
            => _client = factory.CreateClient();
    }
}