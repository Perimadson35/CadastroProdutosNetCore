using CadastroProdutosNetCore.Models;
using CadastroProdutosNetCore.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;

namespace CadastroProdutosNetCore.Pages.Clientes
{
    public class DeleteModel : PageModel
    {
        private readonly IClienteRepository _clienteRepository;

        public DeleteModel(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

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

        public IActionResult OnPost(int id)
        {
            _clienteRepository.Delete(id);
            return RedirectToPage("./Index");
        }
    }
}