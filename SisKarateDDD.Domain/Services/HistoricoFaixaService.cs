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
    public class HistoricoFaixaService : ServiceBase<HistoricoFaixa>, IHistoricoFaixaService
    {
        private readonly IHistoricoFaixaRepository _historicoFaixaRepositoryRepository;

        public HistoricoFaixaService(IHistoricoFaixaRepository historicoFaixaRepositoryRepository)
            : base(historicoFaixaRepositoryRepository)
        {
            _historicoFaixaRepositoryRepository = historicoFaixaRepositoryRepository;
        }
    }
}
