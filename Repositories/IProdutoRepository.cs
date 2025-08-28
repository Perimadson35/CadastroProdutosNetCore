using CadastroProdutosNetCore.Models;
using System.Collections.Generic;

namespace CadastroProdutosNetCore.Repositories
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> GetAll();
        Produto? GetById(int id);
        void Add(Produto produto);
        void Update(Produto produto);
        void Delete(int id);
    }
}