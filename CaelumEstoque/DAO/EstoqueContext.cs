using CaelumEstoque.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CaelumEstoque.DAO
{
    public class EstoqueContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        public DbSet<CategoriaDoProduto> Categorias { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        public EstoqueContext() : base("EstoqueContext")
        {
            bool criou = Database.CreateIfNotExists();

      
        }

        protected override void OnModelCreating(DbModelBuilder dbModelBuilder)
        {
            dbModelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}


