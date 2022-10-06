using Dominio.Models;

namespace Dominio.Models;

public class Imoveis
{
    public Guid Id { get; set; }
    public string Cidade { get; set; }
    public string Bairro { get; set; }
    public string Valor { get; set; }
    public string Padrao { get; set; }
    public Clientes Cliente { get; set; }
}