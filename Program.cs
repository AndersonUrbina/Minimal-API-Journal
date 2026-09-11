var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

// Middleware:
app.Use(async (context, next) =>
{
    context.Response.Headers.Append("API", "JournalApi");

    await next();
});

// GET /
app.MapGet("/", () =>
{
    return Results.Text("Hello, ASP.NET");
});

// GET /time
app.MapGet("/time", () =>
{
    return Results.Json(new
    {
        time = DateTime.UtcNow
    });
});

// GET /echo?msg=...
app.MapGet("/echo", (string? msg) =>
{
    if (string.IsNullOrWhiteSpace(msg))
    {
        return Results.BadRequest(new
        {
            error = "The msg parameter is required."
        });
    }

    return Results.Ok(new
    {
        message = msg,
        length = msg.Length
    });
});

app.Run();