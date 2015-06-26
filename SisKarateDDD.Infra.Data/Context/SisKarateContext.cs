using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using SisKarateDDD.Domain.Entities;
using SisKarateDDD.Infra.Data.EntityConfig;

namespace SisKarateDDD.Infra.Data.Context
{
    public class SisKarateContext: DbContext
    {
        public SisKarateContext()
            : base("name=SisKarateContext")
        {
            
        }

        public virtual DbSet<TipoPessoa> TIPOPESSOA { get; set; }
        public virtual DbSet<Pessoa> PESSOA { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //garante que todos os campos que forem string sejam gerados no banco como varchar e não como nvarchar
            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new TipoPessoaConfiguration());
            modelBuilder.Configurations.Add(new PessoaConfiguration());
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }

            return base.SaveChanges();
        }
    }
}
