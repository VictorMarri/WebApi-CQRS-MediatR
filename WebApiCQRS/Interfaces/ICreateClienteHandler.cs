using WebApiCQRS.CQRS.Command.Requests;
using WebApiCQRS.CQRS.Command.Responses;

namespace WebApiCQRS.Interfaces
{
    public interface ICreateClienteHandler
    {
        CreateClienteResponse Handle(CreateClienteRequest command);
    }
}
