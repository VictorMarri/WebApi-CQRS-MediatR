using MediatR;
using WebApiMediatR.CQRS.Queries.Responses;

namespace WebApiMediatR.CQRS.Queries.Requests
{
    //Aqui tambem vamos marcar nossa classe que representa a request com a interface do MediatR
    //novamente, passando juntamente com a interface os dados de resposta
    public class EncontrarClientePorIdRequest : IRequest<EncontrarClientePorIdResponse>
    {
        public Guid IdCliente { get; set; }
    }
}
