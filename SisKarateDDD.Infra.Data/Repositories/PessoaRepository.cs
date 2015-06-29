using System.Linq;
using SisKarateDDD.Domain.Entities;
using SisKarateDDD.Domain.Interfaces;
using SisKarateDDD.Domain.Interfaces.Repositories;

namespace SisKarateDDD.Infra.Data.Repositories
{
    public class PessoaRepository: RepositoryBase<Pessoa>, IPessoaRepository
    {
        public System.Collections.Generic.IEnumerable<Pessoa> BuscarPorNome(string nome)
        {
            return Db.PESSOA.Where(w => w.Nome.Equals(nome));
        }
    }
}
