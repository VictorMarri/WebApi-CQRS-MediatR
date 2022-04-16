using WebApiCQRS.CQRS.Commands.Requests;
using WebApiCQRS.CQRS.Commands.Responses;
using WebApiCQRS.Infrastructure;
using WebApiCQRS.Interfaces;
using WebApiCQRS.Models;

namespace WebApiCQRS.CQRS.Handlers
{
    //Aqui fica o fluxo de execução da ação de criar um cliente
    //Nessa parte fica o Handler, que é o que de fato vai realizar as regras de negocio da aplicação
    public class CreateClienteHandler : ICreateClienteHandler
    {
        private readonly Repository _repository;

        public CreateClienteHandler(Repository repository)
        {
            _repository = repository;
        }

        //cabe uso da biblioteca Mapper
        public CreateClienteResponse Handle(CreateClienteRequest command)
        {
            if (command == null) throw new ArgumentNullException("A Request veio vazia, por gentileza preenche-la");

            var cliente = new Cliente(command.Nome, command.Email);

            _repository.Clientes.Add(cliente);

            return new CreateClienteResponse
            {
                IdCliente = cliente.IdCliente,
                Nome = cliente.Nome,
                Email = cliente.Email,
                Data = DateTime.Now
            };
        }
    }
}
