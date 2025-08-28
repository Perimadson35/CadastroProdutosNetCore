namespace CadastroProdutosNetCore.Models
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public string? Nome { get; set; }
        public decimal Valor { get; set; }
        public bool Disponivel { get; set; }
        public int IdCliente { get; set; }
        public Cliente? Cliente { get; set; }
    }
}