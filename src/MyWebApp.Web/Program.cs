var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello from MyWebApp!");

app.MapGet("/api/health", () => Results.Ok(new { status = "Healthy", time = DateTime.UtcNow }));

app.MapGet("/api/greet/{name}", (string name) => Results.Ok(new { message = $"Hello, {name}!" }));

app.Run();

// Needed so the test project can use WebApplicationFactory<Program>
public partial class Program { }
