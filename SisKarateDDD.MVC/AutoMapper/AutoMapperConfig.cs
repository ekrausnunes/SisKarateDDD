
using AutoMapper;

namespace SisKarateDDD.MVC.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMapping()
        {
            Mapper.Initialize(x =>
            {
              x.AddProfile<DomainToViewModelMappingProfile>();  
              x.AddProfile<ViewModelToDomainMappingProfile>();
            });
        }
    }
}