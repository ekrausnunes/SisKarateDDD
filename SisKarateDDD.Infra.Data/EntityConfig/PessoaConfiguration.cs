
using System.Data.Entity.ModelConfiguration;
using SisKarateDDD.Domain.Entities;

namespace SisKarateDDD.Infra.Data.EntityConfig
{
    public class PessoaConfiguration: EntityTypeConfiguration<Pessoa>
    {
        public PessoaConfiguration()
        {
            HasKey(p => p.IdPessoa);

            HasRequired(p => p.TipoPessoa)
                .WithMany()
                .HasForeignKey(p => p.TipoPessoaId);
        }
    }
}
