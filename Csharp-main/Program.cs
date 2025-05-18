using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Infrastructure.Persistence;
using challenge_dotnet.Aplication.Interfaces;
using challenge_dotnet.Aplication.Services;
using Application.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Challenge .NET API", Version = "v1" });
});

// Banco de dados Oracle
var connectionString = builder.Configuration.GetConnectionString("Oracle");
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseOracle(connectionString));

// Dependency Injection
builder.Services.AddScoped<IFilialService, FilialService>();
builder.Services.AddScoped<ILocalizacaoService, LocalizacaoService>();
builder.Services.AddScoped<IMotoService, MotoService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Challenge .NET API v1"));
}

// app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();