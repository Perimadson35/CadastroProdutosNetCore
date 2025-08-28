using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CadastroProdutosNetCore.Models;
using CadastroProdutosNetCore.Repositories;
using System.Linq;

namespace CadastroProdutosNetCore.Pages.Clientes
{
    public class IndexModel : PageModel
    {
        private readonly IClienteRepository _clienteRepository;

        public IndexModel(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public IList<Cliente> Cliente { get; set; } = new List<Cliente>();

        public void OnGet()
        {
            Cliente = _clienteRepository.GetAll().ToList();
        }
    }
}