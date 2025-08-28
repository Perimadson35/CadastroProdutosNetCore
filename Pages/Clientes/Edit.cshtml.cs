using CadastroProdutosNetCore.Models;
using CadastroProdutosNetCore.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;

namespace CadastroProdutosNetCore.Pages.Clientes
{
    public class EditModel : PageModel
    {
        private readonly IClienteRepository _clienteRepository;

        public EditModel(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        [BindProperty]
        public Cliente Cliente { get; set; } = default!;

        public IActionResult OnGet(int id)
        {
            Cliente = _clienteRepository.GetAll().FirstOrDefault(c => c.IdCliente == id);

            if (Cliente == null)
            {
                return NotFound();
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _clienteRepository.Update(Cliente);
            return RedirectToPage("./Index");
        }
    }
}