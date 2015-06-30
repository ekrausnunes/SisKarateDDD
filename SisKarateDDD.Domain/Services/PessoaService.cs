using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SisKarateDDD.Domain.Entities;
using SisKarateDDD.Domain.Interfaces.Repositories;
using SisKarateDDD.Domain.Interfaces.Services;

namespace SisKarateDDD.Domain.Services
{
    public class PessoaService: ServiceBase<Pessoa>, IPessoaService
    {
        private readonly IPessoaRepository _pessoaRepository;

        public PessoaService(IPessoaRepository pessoaRepository)
            :base(pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        public IEnumerable<Pessoa> BuscarPorNome(string nome)
        {
            return _pessoaRepository.BuscarPorNome(nome);
        }
    }
}
