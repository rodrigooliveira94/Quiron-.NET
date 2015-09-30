using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quiron.LojaVirtual.Dominio.Entidade;

namespace Quiron.LojaVirtual.Dominio.Repositorio
{
    public class EfDbContext : DbContext
    {
        //DbContext (referenciar a classe produto em uma coleção DbSet)

        public DbSet<Produto> Produtos { get; set; }

        // Reescrever o método para remover a pluralização
         
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Produto>().ToTable("Produtos");
        }

    }
}
