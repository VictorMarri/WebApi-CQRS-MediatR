namespace WebApiMediatR.CQRS.Commands.Responses
{
    //Aqui vai ficar os dados que queremos retornar para a tela na hora da requisição e do uso do CQRS
    //Não podemos retornar a entidade ClienteModel pq ela nao tem Data, e nem podemos retornar tambem CreateClienteRequest pq nao temos nem ID nem Data
    public class CreateClienteResponse
    {
        public Guid IdCliente { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime Data { get; set; }
    }
}
