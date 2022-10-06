using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Services.Helpers;
using Services.Interfaces;
using Web.Contexto;
using Web.Models;
using X.PagedList;

namespace Services.AppServices;

public class ClientesService: IClientesServices
{
    private readonly SpContexto _spContexto;

    public ClientesService(SpContexto spContexto)
    {
        _spContexto = spContexto;
    }
    
    public async Task<IPagedList<Cliente>> ListarPaginado(int? pagina = 1, string parametroDeBusca = "")
    {
        Expression<Func<Cliente, bool>> condicaoDeBusca = null;
        IPagedList<Cliente> usuarios;

        if (!string.IsNullOrEmpty(parametroDeBusca))
            condicaoDeBusca = (x=>
                x.Nome.ToLower().Contains(parametroDeBusca.ToLower()) ||
                x.Email.ToLower().Contains(parametroDeBusca.ToLower()) ||
                x.Telefone.Replace(".", "").Replace("-", "") == parametroDeBusca.Replace(".", "").Replace("-", ""));

        if (condicaoDeBusca is null)
            usuarios = await _spContexto.Clientes
                .AsNoTracking()
                .ToPagedListAsync(pagina, Paginacao.QuantidadeDeRegistros());
        else
            usuarios = await _spContexto.Clientes
                .Where(condicaoDeBusca)
                .AsNoTracking()
                .ToPagedListAsync(pagina, Paginacao.QuantidadeDeRegistros());

        return usuarios;
    }
}