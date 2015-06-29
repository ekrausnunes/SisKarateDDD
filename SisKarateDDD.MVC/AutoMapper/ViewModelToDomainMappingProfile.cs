using AutoMapper;
using SisKarateDDD.Domain.Entities;
using SisKarateDDD.MVC.ViewModels;

namespace SisKarateDDD.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Pessoa, PessoaViewModel>();
            Mapper.CreateMap<TipoPessoa, TipoPessoaViewModel>();
        }
    }
}