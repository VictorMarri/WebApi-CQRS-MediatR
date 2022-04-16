namespace WebApiMediatR.CQRS.Queries.Responses
{
    //Classe que vai representar a resposta do Handler
    public class EncontrarClientePorIdResponse
    {
        public Guid IdCliente { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
    }
}
