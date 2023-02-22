using Microsoft.OpenApi.Models;

using MyWorkout.Api.Middleware;
using MyWorkout.Application;
using MyWorkout.Infrastructure;
using MyWorkout.Persistance;

using Serilog;

Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .CreateLogger();

try
{
    Log.Information("Starting MyWorkout API");
    var builder = WebApplication.CreateBuilder(args);

    builder.Host.UseSerilog((ctx, lc)
        => lc.ReadFrom.Configuration(ctx.Configuration));

    // Add services to the container.

    builder.Services.AddScoped<ErrorHandlerMiddleware>();

    builder.Services.AddControllers();
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen(options =>
    {
        options.SwaggerDoc("v1", new OpenApiInfo
        {
            Version = "v1",
            Title = "MyWorkout API",
            Description = "An ASP.NET Core Web API for managing workout plans",
            Contact = new OpenApiContact
            {
                Name = "Micha³ Rosa",
                Url = new Uri("https://www.linkedin.com/in/rosamichal/")
            }
        });

        var filePath = Path.Combine(AppContext.BaseDirectory, "MyWorkout.Api.xml");
        options.IncludeXmlComments(filePath);
    });

    builder.Services.AddCors(options =>
    {
        options.AddDefaultPolicy(builder =>
        {
            builder.WithOrigins("https://myworkout-react");
        });
    });

    builder.Services.AddApplication();
    builder.Services.AddInfrastructure(builder.Configuration);
    builder.Services.AddPersistance(builder.Configuration);

    builder.Services.AddHealthChecks();

    var app = builder.Build();

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseMiddleware<ErrorHandlerMiddleware>();

    app.UseHttpsRedirection();

    app.UseSerilogRequestLogging();

    app.UseHealthChecks("/api/hc");

    app.UseCors();

    app.UseAuthorization();

    app.MapControllers();

    app.Run();
}
catch (Exception ex)
{
    Log.Fatal(ex, "Application terminated unexpectedly");
}
finally
{
    Log.CloseAndFlush();
}