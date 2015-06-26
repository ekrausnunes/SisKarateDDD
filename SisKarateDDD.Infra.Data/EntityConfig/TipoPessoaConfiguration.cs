using System.Data.Entity.ModelConfiguration;
using SisKarateDDD.Domain.Entities;

namespace SisKarateDDD.Infra.Data.EntityConfig
{
    public class TipoPessoaConfiguration: EntityTypeConfiguration<TipoPessoa>
    {
        public TipoPessoaConfiguration()
        {
            //Usando fluent API
            HasKey(t => t.IdTipoPessoa);

            Property(t => t.Descricao)
                .IsRequired()
                .HasMaxLength(200);

        }
    }
}
