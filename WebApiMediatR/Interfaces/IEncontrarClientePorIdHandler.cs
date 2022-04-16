using WebApiMediatR.CQRS.Queries.Requests;
using WebApiMediatR.CQRS.Queries.Responses;

namespace WebApiMediatR.Interfaces
{
    public interface IEncontrarClientePorIdHandler
    {
        EncontrarClientePorIdResponse Handle(EncontrarClientePorIdRequest query);
    }
}
