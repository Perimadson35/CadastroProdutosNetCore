using CadastroProdutosNetCore.Models;
using CadastroProdutosNetCore.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;

namespace CadastroProdutosNetCore.Pages.Produtos
{
    public class DeleteModel : PageModel
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IClienteRepository _clienteRepository;

        public DeleteModel(IProdutoRepository produtoRepository, IClienteRepository clienteRepository)
        {
            _produtoRepository = produtoRepository;
            _clienteRepository = _clienteRepository;
        }

        public Produto Produto { get; set; } = default!;

        public IActionResult OnGet(int id)
        {
            Produto = _produtoRepository.GetById(id);

            if (Produto == null)
            {
                return NotFound();
            }
            return Page();
        }

        public IActionResult OnPost(int id)
        {
            _produtoRepository.Delete(id);
            return RedirectToPage("./Index");
        }
    }
}