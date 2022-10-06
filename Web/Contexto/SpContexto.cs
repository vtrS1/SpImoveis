using Microsoft.EntityFrameworkCore;
using Web.Models;

namespace Web.Contexto;

public class SpContexto : DbContext 
{
    public SpContexto(DbContextOptions<SpContexto> options) : base(options)
    {
        
    }
    public DbSet<Imoveis> Imoveis { get; set; }
    public DbSet<Cliente> Clientes { get; set; }

}