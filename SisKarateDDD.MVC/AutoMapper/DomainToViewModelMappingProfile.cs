using AutoMapper;
using SisKarateDDD.Domain.Entities;
using SisKarateDDD.MVC.ViewModels;

namespace SisKarateDDD.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<PessoaViewModel, Pessoa>();
            Mapper.CreateMap<TipoPessoaViewModel, TipoPessoa>();
        }
    }
}