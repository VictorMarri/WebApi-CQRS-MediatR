using MediatR;
using System.Reflection;
using WebApiMediatR.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<Repository>();

//Agora aqui, não mais precisamos ficar registrando inumeros containeres de injeção de dependencia, que acabariam escalando a medida que a aplicação crescesse.
//Basta somente deixarmos um container do MediatR pra tomar conta de tudo
//Dessa forma, o mediatR se encarrega de receber um comando e verificar qual manipulador vai ser responsavel por gerenciar
builder.Services.AddMediatR(Assembly.GetExecutingAssembly());

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
