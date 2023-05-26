using HouseEasy.API.Profiles;
using HouseEasy.Data;
using HouseEasy.IOC;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddAutoMapper(typeof(AutomapperProfile));

builder.Services.SetupDataContext(builder.Configuration);

builder.Services.SetupRepository();
builder.Services.SetupService();


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "API de Usuarios",
        Description = "Aplicação de cadastro de usuarios e seus dados como endereço, telefones e ocupações.",
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
