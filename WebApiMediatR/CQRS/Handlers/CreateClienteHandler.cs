using MediatR;
using WebApiMediatR.CQRS.Commands.Requests;
using WebApiMediatR.CQRS.Commands.Responses;
using WebApiMediatR.Infrastructure;
using WebApiMediatR.Models;

namespace WebApiMediatR.CQRS.Handlers
{
    //Aqui, agora, diferentemente do exemplo de CQRS, não vamos mais precisar usar uma interface
    //O mediatR vai se encarregar automaticamente de buscar um Handler que vai poder manipular o comando que enviamos pra ele
    //Agora o nosso Handler vai implementar a interface nativa do mediatR IRequestHandler, contando com a classe de request e a classe de response
    public class CreateClienteHandler : IRequestHandler<CreateClienteRequest, CreateClienteResponse>
    {
        private readonly Repository _repository;

        public CreateClienteHandler(Repository repository)
        {
            _repository = repository;
        }

        public Task<CreateClienteResponse> Handle(CreateClienteRequest request, CancellationToken cancellationToken)
        {
            if (request == null) throw new ArgumentNullException("A Request veio vazia, por gentileza preenche-la");

            var cliente = new Cliente(request.Nome, request.Email);

            _repository.Clientes.Add(cliente);

            var resultado = new CreateClienteResponse
            {
                IdCliente = cliente.IdCliente,
                Nome = cliente.Nome,
                Email = cliente.Email,
                Data = DateTime.Now
            };

            return Task.FromResult(resultado);
        }
    }
}
