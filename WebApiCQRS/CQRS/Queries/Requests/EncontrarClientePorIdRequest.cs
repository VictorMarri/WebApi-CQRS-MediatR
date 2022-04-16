namespace WebApiCQRS.CQRS.Queries
{
    //Classe que vai representar o dado passado na request de busca (query)
    public class EncontrarClientePorIdRequest
    {
        public Guid IdCliente { get; set; }
    }
}
