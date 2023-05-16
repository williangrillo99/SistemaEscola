using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SistemaAula.Date;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var conecarMySql = builder.Configuration.GetConnectionString("ConnectionMySql");

builder.Services.AddDbContext<APIDbContext>(x => x.UseMySql(
    conecarMySql, new MySqlServerVersion(new Version(8, 0, 33))));


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


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
