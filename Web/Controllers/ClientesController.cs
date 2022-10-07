using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Services.Interfaces;
using Web.ViewsModels.ClientesViewModels;
using X.PagedList;

namespace Web.Controllers;

public class ClientesController : Controller
{
    private readonly IClientesServices _clientes;

    public ClientesController(IClientesServices clientes)
    {
        _clientes = clientes;
    }
    

    public IActionResult Index()
    {
        return View();
    }
}