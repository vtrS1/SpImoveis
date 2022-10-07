using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Services.AppServices;
using Services.Extensions;
using Services.Interfaces;

namespace Web.Pages.Imoveis;

public class Index : PageModel
{
    private readonly IImoveisServices _imoveis;
    
    public Index(ImoveisServices imoveis)
    {
        _imoveis = imoveis;

    }
    [FromQuery] public string ParametrosDeBusca { get; set; } = ""; 
    public int Pagina { get; set; } = 1;
    public PagedResult<Dominio.Models.Imoveis> Imoveis { get; set; }
    

    
    public void OnGet()
    {
        try
        {
            Imoveis = _imoveis.ListarImoveis(ParametrosDeBusca, Pagina);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }      
    }

}