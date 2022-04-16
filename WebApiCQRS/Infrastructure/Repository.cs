using WebApiCQRS.Models;

namespace WebApiCQRS.Infrastructure
{
    public class Repository
    {
        public List<Cliente> Clientes { get; } = new List<Cliente>
        {
            new Cliente("Francisco Rocha", "franciscorocha11@gmail.com"),
            new Cliente("Adelma Santos", "delminha@gmail.com"),
            new Cliente("Alcimar Pereira", "alcimarpereira@gmail.com"),
            new Cliente("Jivanildo Costa", "jijivanildo@gmail.com"),
        };
    }
}
