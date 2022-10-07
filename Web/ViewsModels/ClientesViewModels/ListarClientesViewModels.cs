using Dominio.Models;

namespace Web.ViewsModels.ClientesViewModels;

public class ListarClientesViewModels
{
    public ListarClientesViewModels(Clientes clientes)
    {
        Id = clientes.Id;
        Nome = clientes.Nome;
        Telefone = clientes.Telefone;
        Email = clientes.Email;
        PadraoInteresse = clientes.PadraoInteresse;

    }
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }
    public string PadraoInteresse { get; set; }
}