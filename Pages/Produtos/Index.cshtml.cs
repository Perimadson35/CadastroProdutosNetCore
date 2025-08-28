using CadastroProdutosNetCore.Models;
using CadastroProdutosNetCore.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace CadastroProdutosNetCore.Pages.Produtos
{
    public class IndexModel : PageModel
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IClienteRepository _clienteRepository;

        public IndexModel(IProdutoRepository produtoRepository, IClienteRepository clienteRepository)
        {
            _produtoRepository = produtoRepository;
            _clienteRepository = clienteRepository;
        }

        public IList<Produto> Produto { get;set; } = default!;
        public IEnumerable<Cliente> Clientes { get; set; } = default!;

        public void OnGet()
        {
            Produto = _produtoRepository.GetAll().ToList();
            Clientes = _clienteRepository.GetAll();
        }
    }
}