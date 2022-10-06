using Dominio.Models;
using X.PagedList;

namespace Services.Interfaces;

public interface IClientesServices
{
    Task<IPagedList<Clientes>> ListarPaginado(int? pagina = 1, string parametroDeBusca = "");
}