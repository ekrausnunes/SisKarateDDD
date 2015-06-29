using System.Collections.Generic;
using SisKarateDDD.Domain.Entities;

namespace SisKarateDDD.Domain.Interfaces.Repositories
{
    public interface IPessoaRepository: IRepositoryBase<Pessoa>
    {
        IEnumerable<Pessoa> BuscarPorNome(string nome);
    }
}
