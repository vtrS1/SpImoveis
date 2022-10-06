using System.Reflection.Metadata.Ecma335;

namespace Web.Models;

public class Imoveis
{
    public Guid Id { get; set; }
    public string Cidade { get; set; }
    public string Bairro { get; set; }
    public string Valor { get; set; }
    public string Padrao { get; set; }
    public Cliente Cliente { get; set; }
}