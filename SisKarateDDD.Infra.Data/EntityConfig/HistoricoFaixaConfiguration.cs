

using SisKarateDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace SisKarateDDD.Infra.Data.EntityConfig
{
    public class HistoricoFaixaConfiguration: EntityTypeConfiguration<HistoricoFaixa>
    {
        public HistoricoFaixaConfiguration()
        {
            HasKey(h => h.idHistorico);

            HasRequired(h => h.Pessoa)
                .WithMany()
                .HasForeignKey(h => h.idPessoa);

        }
    }
}
