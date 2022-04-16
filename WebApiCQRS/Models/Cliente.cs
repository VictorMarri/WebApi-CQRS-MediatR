namespace WebApiCQRS.Models
{
    public class Cliente
    {
        public Cliente(string nome, string email)
        {
            IdCliente = Guid.NewGuid();
            Nome = nome;
            Email = email;
        }

        public Guid IdCliente { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
    }
}
