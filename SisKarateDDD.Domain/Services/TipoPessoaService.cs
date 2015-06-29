using SisKarateDDD.Domain.Entities;
using SisKarateDDD.Domain.Interfaces.Repositories;
using SisKarateDDD.Domain.Interfaces.Services;

namespace SisKarateDDD.Domain.Services
{
    public class TipoPessoaService: ServiceBase<TipoPessoa>, ITipoPessoaService
    {
        private readonly ITipoPessoaRepository _tipoPessoaRepository;

        public TipoPessoaService(ITipoPessoaRepository tipoPessoaRepository)
            : base(tipoPessoaRepository)
        {
            _tipoPessoaRepository = tipoPessoaRepository;
        }
    }
}
