using WebApiCQRS.CQRS.Queries.Requests;
using WebApiCQRS.CQRS.Queries.Responses;

namespace WebApiCQRS.Interfaces
{
    public interface IEncontrarClientePorIdHandler
    {
        EncontrarClientePorIdResponse Handle(EncontrarClientePorIdRequest query);
    }
}
