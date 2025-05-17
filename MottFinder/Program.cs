using Microsoft.EntityFrameworkCore;
using MotFinder.Application.Interfaces;
using MotFinder.Application.Services;
using MotFinder.Domain.Interfaces;
using MotFinder.Infrastructure.Data.AppData;
using MotFinder.Infrastructure.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);


var connectionString = builder.Configuration.GetConnectionString("OracleDb");


builder.Services.AddDbContext<AppDataContext>(options =>
    options.UseOracle(connectionString));


builder.Services.AddScoped<IMotoService, MotoService>();
builder.Services.AddScoped<IMotoRepository, MotoRepository>();


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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();