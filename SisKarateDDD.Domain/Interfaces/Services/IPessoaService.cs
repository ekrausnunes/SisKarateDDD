using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SisKarateDDD.Domain.Entities;

namespace SisKarateDDD.Domain.Interfaces.Services
{
    public interface IPessoaService: IServiceBase<Pessoa>
    {
        IEnumerable<Pessoa> BuscarPorNome(string nome);
    }
}
