using WebApiCQRS.CQRS.Queries;
using WebApiCQRS.CQRS.Queries.Responses;

namespace WebApiCQRS.Interfaces
{
    public interface IEncontrarClientePorIdHandler
    {
        EncontrarClientePorIdResponse Handle(EncontrarClientePorIdRequest query);
    }
}
