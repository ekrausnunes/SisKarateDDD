using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using SisKarateDDD.Domain.Entities;

namespace SisKarateDDD.Infra.Data.Context
{
    public class SisKarateContext: DbContext
    {
        public SisKarateContext()
            : base("name=SisKarateContext")
        {
            
        }

        public virtual DbSet<TipoPessoa> TIPOPESSOA { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
