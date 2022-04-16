using Microsoft.AspNetCore.Mvc;
using WebApiCQRS.CQRS.Command.Requests;
using WebApiCQRS.CQRS.Queries;
using WebApiCQRS.Interfaces;

namespace WebApiCQRS.Controllers
{
    [ApiController]
    [Route("clientes")]
    public class ClienteController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public IActionResult GetClientePorId([FromServices] IEncontrarClientePorIdHandler handler, [FromQuery] EncontrarClientePorIdRequest query)
        {
            var resposta = handler.Handle(query);
            return Ok(resposta);
        }


        [HttpPost]
        [Route("")]
        public IActionResult CriarCliente([FromServices] ICreateClienteHandler handler, [FromBody] CreateClienteRequest request)
        {
            var resposta = handler.Handle(request);
            return Ok(resposta);
        }
    }
}