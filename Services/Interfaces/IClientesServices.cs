using Dominio.Models;
using Services.Dtos;
using Services.Extensions;
using X.PagedList;

namespace Services.Interfaces;

public interface IClientesServices
{
    PagedResult<Clientes> ListarClientes(string ParametrosDeBusca = "", int pagina = 1, int tamPagina = 10);
    Task ExcluirCliente(Guid usuarioId);
    Task CriarCliente(CadastrarClienteDto cadastrarClienteDto);
    Task<Clientes> BuscarPorId(Guid id);
}