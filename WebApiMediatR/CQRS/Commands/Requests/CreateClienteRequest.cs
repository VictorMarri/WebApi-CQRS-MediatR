using MediatR;
using WebApiMediatR.CQRS.Commands.Responses;

namespace WebApiMediatR.CQRS.Commands.Requests
{
    //Pra que as dependencias sejam resolvidas pelo MediatR, precisamos implementar a interface IRequest nos nosso dados de request
    //E juntamente, passar o dado de resposta
    public class CreateClienteRequest : IRequest<CreateClienteResponse>
    {
        public string Nome { get; set; }
        public string Email { get; set; }
    }
}
