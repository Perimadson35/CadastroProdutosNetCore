using CadastroProdutosNetCore.Models;
using Microsoft.EntityFrameworkCore;

namespace CadastroProdutosNetCore.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; } = default!;
        public DbSet<Produto> Produtos { get; set; } = default!;

       protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<Cliente>()
        .HasKey(c => c.IdCliente);

    modelBuilder.Entity<Cliente>().HasData(
        new Cliente { IdCliente = 1, Nome = "João", Sobrenome = "Silva", Email = "joao.silva@email.com", DataCadastro = System.DateTime.Now, Ativo = true },
        new Cliente { IdCliente = 2, Nome = "Maria", Sobrenome = "Souza", Email = "maria.souza@email.com", DataCadastro = System.DateTime.Now, Ativo = true }
    );

    modelBuilder.Entity<Produto>()
        .HasKey(p => p.IdProduto);

    modelBuilder.Entity<Produto>().HasData(
        new Produto { IdProduto = 1, Nome = "Mouse", Valor = 50.00M, Disponivel = true, IdCliente = 1 },
        new Produto { IdProduto = 2, Nome = "Teclado", Valor = 150.00M, Disponivel = true, IdCliente = 1 }
    );
}
    }
}