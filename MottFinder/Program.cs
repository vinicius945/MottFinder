using Microsoft.EntityFrameworkCore;
using MottFinder.Application.Interfaces;
using MottFinder.Application.Services;
using MottFinder.Infrastructure.Data.Repositories;
using MottFinder.Domain.Interfaces;
using MottFinder.Infrastructure.Data.AppData;

var builder = WebApplication.CreateBuilder(args);


var connectionString = builder.Configuration.GetConnectionString("OracleDb");


builder.Services.AddDbContext<AppDataContext>(options =>
    options.UseOracle(connectionString));


builder.Services.AddScoped<IMotoService, MotoService>();
builder.Services.AddScoped<IMotoRepository, MotoRepository>();

builder.Services.AddScoped<ICameraService, CameraService>();
builder.Services.AddScoped<ICameraRepository, CameraRepository>();

builder.Services.AddScoped<IGpsService, GpsService>();
builder.Services.AddScoped<IGpsRepository, GpsRepository>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDataContext>();
    db.Database.Migrate();
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();