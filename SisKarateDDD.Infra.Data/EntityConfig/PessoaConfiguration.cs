
using System.Data.Entity.ModelConfiguration;
using SisKarateDDD.Domain.Entities;

namespace SisKarateDDD.Infra.Data.EntityConfig
{
    public class PessoaConfiguration: EntityTypeConfiguration<Pessoa>
    {
        public PessoaConfiguration()
        {
            HasKey(p => p.IdPessoa);
        }
    }
}
