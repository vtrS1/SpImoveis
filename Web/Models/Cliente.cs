namespace Web.Models;

public class Cliente
{
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }
    public string PadraoInteresse { get; set; }
}