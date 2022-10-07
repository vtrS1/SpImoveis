using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Services.Dtos;
using Services.Interfaces;

namespace Web.Pages.Clientes;

public class CriarCliente : PageModel
{
    private IClientesServices _services;

    public CriarCliente(IClientesServices services)
    {
        _services = services;
    }
    [Display(Name = "CPF ou CNPJ")]
    [BindProperty]
    public string PadraoInteresse { get; set; }

    [Display(Name = "Nome")]
    [BindProperty]
    public string NomeCompleto { get; init; }
    
    [Display(Name = "Email")]
    [EmailAddress(ErrorMessage = "Insira um {0} é válido")]
    [BindProperty]
    public string Email { get; init; }
    
    [Display(Name = "Telefone")]
    [Phone(ErrorMessage = "O {0} é inválido")]
    [BindProperty]
    public string Telefone { get; init; }
    
    
    public async Task<IActionResult> OnPost()
    {
        try
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var novoUsuario = new CadastrarClienteDto(
                NomeCompleto,
                PadraoInteresse,
                Email,
                Telefone
            );
            
            await _services.CriarCliente(novoUsuario);

            return RedirectToPage("Index");
        }
        catch (Exception e)
        {
            ModelState.AddModelError("Error", e.Message);
            return Page();
        }
    }

}