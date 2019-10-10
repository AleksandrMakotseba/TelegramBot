using AutoMapper;
using BusinessLogic.ModelDTO;
using DataLibrary.Model;

namespace BusinessLogic.MapperConfiguration
{
    public class Configuration : Profile
    {
        public Configuration()
        {
            CreateMap<WeatherResponse, WeatherResponseDTO>();
            CreateMap<WeatherResponseDTO, WeatherResponse>();
            CreateMap<WindInfo, WindInfoDTO>();
            CreateMap<WindInfoDTO, WindInfo>();
        }
    }
}
