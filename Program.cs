var builder = WebApplication.CreateBuilder(args);

// Servicios
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Endpoint raíz (evita 404 y confirma que la API está viva)
app.MapGet("/", () => Results.Ok("ContosoWeb API is running"));

// Health check (clave para Docker, CI, Kubernetes, Azure, etc.)
app.MapGet("/api/health", () =>
    Results.Ok(new { status = "Healthy" })
);

// Endpoint de ejemplo (WeatherForecast)
app.MapGet("/weatherforecast", () =>
{
    var summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm",
        "Balmy", "Hot", "Sweltering", "Scorching"
    };

    var forecast = Enumerable.Range(1, 5).Select(index =>
        new
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = summaries[Random.Shared.Next(summaries.Length)]
        });

    return forecast;
})
.WithName("GetWeatherForecast");

app.Run();
