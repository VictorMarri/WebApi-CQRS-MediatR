using WebApiCQRS.CQRS.Commands.Requests;
using WebApiCQRS.CQRS.Commands.Responses;

namespace WebApiCQRS.Interfaces
{
    public interface ICreateClienteHandler
    {
        CreateClienteResponse Handle(CreateClienteRequest command);
    }
}
