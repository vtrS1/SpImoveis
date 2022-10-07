using Dominio.Models;
using Services.Extensions;
using X.PagedList;

namespace Services.Interfaces;

public interface IClientesServices
{
    PagedResult<Clientes> ListarClientes(string ParametrosDeBusca = "", int pagina = 1, int tamPagina = 10);
}