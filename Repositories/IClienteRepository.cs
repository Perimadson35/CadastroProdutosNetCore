using CadastroProdutosNetCore.Models;
using System.Collections.Generic;

namespace CadastroProdutosNetCore.Repositories
{
    public interface IClienteRepository
    {
        IEnumerable<Cliente> GetAll();
        void Add(Cliente cliente);
        void Update(Cliente cliente);
        void Delete(int id);
    }
}