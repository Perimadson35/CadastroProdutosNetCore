using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CadastroProdutosNetCore.Models;
using CadastroProdutosNetCore.Repositories;

namespace CadastroProdutosNetCore.Pages.Produtos
{
    public class CreateModel : PageModel
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IClienteRepository _clienteRepository;

        public CreateModel(IProdutoRepository produtoRepository, IClienteRepository clienteRepository)
        {
            _produtoRepository = produtoRepository;
            _clienteRepository = clienteRepository;
        }

        [BindProperty]
        public Produto Produto { get; set; } = new Produto();

        public SelectList Clientes { get; set; } = default!;

        public IActionResult OnGet()
        {
            Clientes = new SelectList(_clienteRepository.GetAll(), "IdCliente", "Nome");
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                Clientes = new SelectList(_clienteRepository.GetAll(), "IdCliente", "Nome");
                return Page();
            }

            _produtoRepository.Add(Produto);
            return RedirectToPage("./Index");
        }
    }
}