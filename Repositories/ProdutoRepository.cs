using System.Collections.Generic;
using System.Linq;
using CadastroProdutosNetCore.Models;

namespace CadastroProdutosNetCore.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private static List<Produto> _produtos = new List<Produto>();
        private static int _nextId = 1;

        public IEnumerable<Produto> GetAll()
        {
            return _produtos;
        }

        public Produto? GetById(int id)
        {
            return _produtos.FirstOrDefault(p => p.IdProduto == id);
        }

        public void Add(Produto produto)
        {
            produto.IdProduto = _nextId++;
            _produtos.Add(produto);
        }

        public void Update(Produto produto)
        {
            var existingProduto = GetById(produto.IdProduto);
            if (existingProduto != null)
            {
                existingProduto.Nome = produto.Nome;
                existingProduto.Valor = produto.Valor;
                existingProduto.Disponivel = produto.Disponivel;
                existingProduto.IdCliente = produto.IdCliente;
            }
        }

        public void Delete(int id)
        {
            var produtoToRemove = GetById(id);
            if (produtoToRemove != null)
            {
                _produtos.Remove(produtoToRemove);
            }
        }
    }
}