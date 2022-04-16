namespace WebApiCQRS.CQRS.Command.Requests
{
    //Aqui estão contidas apenas informações necessarias pra criar um cliente, nesse caso, somente Nome e Email. O ID vai ser gerado de forma automatica
    //Strings são por natureza, nullables, já que são tipos de referencia. O compilador reclama sobre isso, mas ignoramos
    public class CreateClienteRequest
    {
        public string Nome { get; set; }
        public string Email { get; set; }
    }
}
