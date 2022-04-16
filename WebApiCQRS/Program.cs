using WebApiCQRS.CQRS.Handlers;
using WebApiCQRS.Infrastructure;
using WebApiCQRS.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<Repository>();
builder.Services.AddTransient<ICreateClienteHandler, CreateClienteHandler>();
builder.Services.AddTransient<IEncontrarClientePorIdHandler, EncontrarClientePorIdHandler>();


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
