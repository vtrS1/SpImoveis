using Web.Models;
using X.PagedList;

namespace Services.Interfaces;

public interface IClientesServices
{
    Task<IPagedList<Cliente>> ListarPaginado(int? pagina = 1, string parametroDeBusca = "");
}