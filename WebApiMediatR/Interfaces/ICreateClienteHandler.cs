using WebApiMediatR.CQRS.Commands.Requests;
using WebApiMediatR.CQRS.Commands.Responses;

namespace WebApiMediatR.Interfaces
{
    public interface ICreateClienteHandler
    {
        CreateClienteResponse Handle(CreateClienteRequest command);
    }
}
