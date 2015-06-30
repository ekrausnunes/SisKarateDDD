
using System.Collections.Generic;
using SisKarateDDD.Application.Interface;
using SisKarateDDD.Domain.Entities;

namespace SisKarateDDD.Application
{
    public class PessoaAppService: AppServiceBase<Pessoa>, IPessoaAppService
    {
        private readonly IPessoaAppService _pessoaAppService;

        public PessoaAppService(IPessoaAppService pessoaAppService)
            : base(pessoaAppService)
        {
            _pessoaAppService = pessoaAppService;
        }

        public IEnumerable<Pessoa> BuscarPorNome(string nome)
        {
            return _pessoaAppService.BuscarPorNome(nome);
        }
    }
}
