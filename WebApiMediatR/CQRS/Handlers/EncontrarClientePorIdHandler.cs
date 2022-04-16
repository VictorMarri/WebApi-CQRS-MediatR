using MediatR;
using WebApiMediatR.CQRS.Queries.Requests;
using WebApiMediatR.CQRS.Queries.Responses;
using WebApiMediatR.Infrastructure;

namespace WebApiMediatR.CQRS.Handlers
{
    //Aqui o mesmo dito nos comentarios da classe de CriarClienteHandler se aplicam:
    //IRequestHandler<Request, Response>
    public class EncontrarClientePorIdHandler : IRequestHandler<EncontrarClientePorIdRequest, EncontrarClientePorIdResponse>
    {
        private readonly Repository _repository;
        public EncontrarClientePorIdHandler(Repository repository)
        {
            _repository = repository;
        }

        public Task<EncontrarClientePorIdResponse> Handle(EncontrarClientePorIdRequest request, CancellationToken cancellationToken)
        {
            var cliente = _repository.Clientes.FirstOrDefault(x => x.IdCliente == request.IdCliente);

            if (cliente == null) throw new Exception("Cliente não encontrado na base de dados");

            var resposta = new EncontrarClientePorIdResponse
            {
                IdCliente = cliente.IdCliente,
                Nome = cliente.Nome,
                Email = cliente.Email
            };

            return Task.FromResult(resposta);
        }
    }
}
