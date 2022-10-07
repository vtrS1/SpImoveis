using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Services.Extensions;
using Services.Interfaces;

namespace Web.Pages.Clientes;

public class Index : PageModel
{
    private readonly IClientesServices _clientes;

    public Index(IClientesServices clientes)
    {
        _clientes = clientes;
     
    }
    [FromQuery] public string ParametrosDeBusca { get; set; } = ""; 
    public int Pagina { get; set; } = 1;
    public PagedResult<Dominio.Models.Clientes> Cliente { get; set; }

    
    public void OnGet()
    {
        try
        {
            Cliente = _clientes.ListarClientes(ParametrosDeBusca, Pagina);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }      
    }
}