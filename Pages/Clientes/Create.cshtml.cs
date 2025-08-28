using CadastroProdutosNetCore.Models;
using CadastroProdutosNetCore.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace CadastroProdutosNetCore.Pages.Clientes
{
    public class CreateModel : PageModel
    {
        private readonly IClienteRepository _clienteRepository;

        public CreateModel(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        [BindProperty]
        public Cliente Cliente { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _clienteRepository.Add(Cliente);

            return RedirectToPage("./Index");
        }
    }
}