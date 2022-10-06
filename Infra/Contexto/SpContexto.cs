using Dominio.Models;
using Microsoft.EntityFrameworkCore;


namespace Dominio.Contexto;

public class SpContexto : DbContext 
{
    public SpContexto(DbContextOptions<SpContexto> options) : base(options)
    {
        
    }
    public DbSet<Imoveis> Imoveis { get; set; }
    public DbSet<Clientes> Clientes { get; set; }

}