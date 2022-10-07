using System.Linq.Expressions;
using Dominio.Contexto;
using Dominio.Models;
using Microsoft.EntityFrameworkCore;
using Services.Dtos;
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
    
    public PagedResult<Clientes> ListarClientes (string ParametrosDeBusca = "", int pagina = 1, int tamPagina = 10)
    {
        
        var Users = _spContexto.Clientes
            .Where(x => x.Nome.ToLower().Contains(ParametrosDeBusca) ||
                        x.Email.ToLower().Contains(ParametrosDeBusca) ||
                        x.Nome.ToLower().Contains(ParametrosDeBusca))
            .GetPaged(pagina, tamPagina);

        return Users;
    }

    public async Task ExcluirCliente(Guid usuarioId)
    {
        try
        {
            var cliente = await _spContexto.Clientes.FindAsync(usuarioId);

            _spContexto.Clientes.Remove(cliente);
            await _spContexto.SaveChangesAsync();

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task CriarCliente(CadastrarClienteDto clienteDto)
    {
        if (_spContexto.Clientes.Any(x => x.Email == clienteDto.Email))
            throw new Exception("Email Já Cadastrado");

        var novoCliente = new Clientes(clienteDto);
        
        await _spContexto.AddAsync(novoCliente);
        await _spContexto.SaveChangesAsync();

    }
    
    public async Task<Clientes> BuscarPorId(Guid id)
    {
        var clientes = await _spContexto.Clientes.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);

        if (clientes is null)

            Console.WriteLine("Não foi possivel encontrar o usuário");

        return clientes;
    }

    
}