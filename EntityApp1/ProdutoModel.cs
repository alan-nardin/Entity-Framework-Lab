using Microsoft.EntityFrameworkCore;

namespace EntityApp1
{
    public class ProdutoContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=dbase.db");
    }

    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Descricao { get; set; }
        public int Estoque { get; set; }
        public decimal Preco { get; set; }
    }
}
