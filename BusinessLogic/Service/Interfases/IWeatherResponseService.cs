using BusinessLogic.ModelDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Service.Interfases
{
    public interface IWeatherResponseService
    {
        OperationDetails LoadingDataIntoDatabase(IList<WeatherResponseDTO> ListWeatherResponseDTOs);
        OperationDetails PartialUpdate(WeatherResponseDTO weatherResponseDTO, int weatherResponseId);
        WeatherResponseDTO GetWeatherResponseDTO(int WeatherResponseId);
        string GetHashCodeAllWeatherResponseDTO();
        string GetHashCodeSmallWeatherResponseDTO();
    }
}
