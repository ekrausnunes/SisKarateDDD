using System.Collections.Generic;
using SisKarateDDD.Domain.Entities;

namespace SisKarateDDD.Application.Interface
{
    public interface IPessoaAppService: IAppServiceBase<Pessoa>
    {
        IEnumerable<Pessoa> BuscarPorNome(string nome);
    }
}
