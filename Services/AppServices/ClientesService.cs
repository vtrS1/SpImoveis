using System.Linq.Expressions;
using Dominio.Contexto;
using Dominio.Models;
using Microsoft.EntityFrameworkCore;
using Services.Extensions;
using Services.Helpers;
using Services.Interfaces;
using X.PagedList;

namespace Services.AppServices;

public class ClientesService: IClientesServices
{
    private readonly SpContexto _spContexto;

    public ClientesService(SpContexto spContexto)
    {
        _spContexto = spContexto;
    }
    
    public PagedResult<Clientes> ListarClientes (string ParametrosDeBusca = "WILI", int pagina = 1, int tamPagina = 10)
    {
        
        var Users = _spContexto.Clientes
            .Where(x => x.Nome.ToLower().Contains(ParametrosDeBusca) ||
                        x.Email.ToLower().Contains(ParametrosDeBusca) ||
                        x.Nome.ToLower().Contains(ParametrosDeBusca))
            .GetPaged(pagina, tamPagina);

        return Users;
    }

    
}