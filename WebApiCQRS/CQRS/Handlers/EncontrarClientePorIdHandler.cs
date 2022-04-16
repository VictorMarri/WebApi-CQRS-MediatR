using WebApiCQRS.CQRS.Queries;
using WebApiCQRS.CQRS.Queries.Responses;
using WebApiCQRS.Infrastructure;
using WebApiCQRS.Interfaces;

namespace WebApiCQRS.CQRS.Handlers
{
    public class EncontrarClientePorIdHandler : IEncontrarClientePorIdHandler
    {
        private readonly Repository _repository;
        public EncontrarClientePorIdHandler(Repository repository)
        {
            _repository = repository;
        }

        public EncontrarClientePorIdResponse Handle(EncontrarClientePorIdRequest query)
        {
            var cliente = _repository.Clientes.FirstOrDefault(x => x.IdCliente == query.IdCliente);

            if (cliente == null) throw new Exception("Cliente não encontrado na base de dados");

            return new EncontrarClientePorIdResponse
            {
                IdCliente = cliente.IdCliente,
                Nome = cliente.Nome,
                Email = cliente.Email
            };

        }
    }
}
