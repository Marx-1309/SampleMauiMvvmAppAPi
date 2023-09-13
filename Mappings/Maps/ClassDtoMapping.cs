using AutoMapper;
using WaterBillingMobileAppAPi.Mappings.Dto_s;
using WaterBillingMobileAppAPi.Models;

namespace WaterBillingMobileAppAPi.Mappings.Maps
{
    public class ClassDtoMapping : Profile
    {
        public ClassDtoMapping() 
        {
           
            CreateMap<Reading, UpdateReadingDto>().ReverseMap();
        }
    }
}
