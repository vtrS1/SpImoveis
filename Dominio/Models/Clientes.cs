using Services.Dtos;

namespace Dominio.Models;


public class Clientes
{
    public Clientes()
    {
        
    }

    public Clientes(CadastrarClienteDto clienteDto)
    {
        Nome = clienteDto.Nome;
        Telefone = clienteDto.Telefone;
        Email = clienteDto.Email;
        PadraoInteresse = clienteDto.PadraoInteresse;
    }
    
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string? Telefone { get; set; }
    public string Email { get; set; }
    public string? PadraoInteresse { get; set; }
    
    public void AtualizarInformacoes(string nome, string padraoInteresse , string email, string telefone)
    {
        this.Nome = nome;
        this.PadraoInteresse = padraoInteresse;
        this.Email = email;
        this.Telefone = telefone;
    }
}