using CadastroProdutosNetCore.Models;
using CadastroProdutosNetCore.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;

namespace CadastroProdutosNetCore.Pages.Produtos
{
    public class DetailsModel : PageModel
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IClienteRepository _clienteRepository;

        public DetailsModel(IProdutoRepository produtoRepository, IClienteRepository clienteRepository)
        {
            _produtoRepository = produtoRepository;
            _clienteRepository = clienteRepository;
        }

        public Produto Produto { get; set; } = default!;
        public Cliente Cliente { get; set; } = default!;

        public IActionResult OnGet(int id)
        {
            Produto = _produtoRepository.GetById(id);

            if (Produto == null)
            {
                return NotFound();
            }

            Cliente = _clienteRepository.GetAll().FirstOrDefault(c => c.IdCliente == Produto.IdCliente);

            return Page();
        }
    }
}