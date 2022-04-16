namespace WebApiMediatR.Models
{
    public class Cliente
    {
        public Cliente(string nome, string email)
        {
            IdCliente = Guid.NewGuid();
            Nome = nome;
            Email = email;
        }

        public Guid IdCliente { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
    }
}
