using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApiMediatR.CQRS.Commands.Requests;
using WebApiMediatR.CQRS.Queries.Requests;

namespace WebApiMediatR.Controllers
{
    [ApiController]
    [Route("clientes")]
    public class ClienteController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public IActionResult GetClientePorId([FromServices] IMediator mediator, [FromQuery] EncontrarClientePorIdRequest command)
        {
            var resposta = mediator.Send(command);
            return Ok(resposta);
        }


        [HttpPost]
        [Route("")]
        public IActionResult CriarCliente([FromServices] IMediator mediator, [FromBody] CreateClienteRequest command)
        {
            var resposta = mediator.Send(command);
            return Ok(resposta);
        }
    }
}