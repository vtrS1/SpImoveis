namespace Services.Dtos;

public class CadastrarClienteDto
{
    public CadastrarClienteDto(string nome, string padraoInteresse, string email, string telefone)
    {
        Nome = nome ?? throw new ArgumentNullException(nameof(nome));
        Email = email ?? throw new ArgumentNullException(nameof(email));
        Telefone = telefone ?? throw new ArgumentNullException(nameof(telefone));
        PadraoInteresse = padraoInteresse ?? throw new ArgumentNullException(nameof(padraoInteresse));
    }
    
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }
    public string PadraoInteresse { get; set; }

}