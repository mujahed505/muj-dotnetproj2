using System.Net;
using Microsoft.AspNetCore.Mvc.Testing;

namespace MyWebApp.Tests;

public class ApiTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly HttpClient _client;

    public ApiTests(WebApplicationFactory<Program> factory)
    {
        _client = factory.CreateClient();
    }

    [Fact]
    public async Task Root_ReturnsHello()
    {
        var response = await _client.GetAsync("/");

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        Assert.Contains("Hello", await response.Content.ReadAsStringAsync());
    }

    [Fact]
    public async Task Health_ReturnsOk()
    {
        var response = await _client.GetAsync("/api/health");

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }

    [Fact]
    public async Task Greet_ReturnsName()
    {
        var response = await _client.GetAsync("/api/greet/Mujahed");

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        Assert.Contains("Mujahed", await response.Content.ReadAsStringAsync());
    }
}
