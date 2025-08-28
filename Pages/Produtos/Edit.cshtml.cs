using CadastroProdutosNetCore.Models;
using CadastroProdutosNetCore.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;

namespace CadastroProdutosNetCore.Pages.Produtos
{
    public class EditModel : PageModel
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IClienteRepository _clienteRepository;

        public EditModel(IProdutoRepository produtoRepository, IClienteRepository clienteRepository)
        {
            _produtoRepository = produtoRepository;
            _clienteRepository = clienteRepository;
        }

        [BindProperty]
        public Produto Produto { get; set; } = default!;

        public SelectList Clientes { get; set; } = default!;

        public IActionResult OnGet(int id)
        {
            Produto = _produtoRepository.GetById(id);

            if (Produto == null)
            {
                return NotFound();
            }

            Clientes = new SelectList(_clienteRepository.GetAll(), "IdCliente", "Nome", Produto.IdCliente);
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                Clientes = new SelectList(_clienteRepository.GetAll(), "IdCliente", "Nome", Produto.IdCliente);
                return Page();
            }

            _produtoRepository.Update(Produto);

            return RedirectToPage("./Index");
        }
    }
}