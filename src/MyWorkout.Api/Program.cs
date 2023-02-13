using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

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

builder.Services.AddHealthChecks();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseHealthChecks("/api/hc");

app.UseAuthorization();

app.MapControllers();

app.Run();
