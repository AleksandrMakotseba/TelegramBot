using BusinessLogic.ModelDTO;
using BusinessLogic.Service.Interfases;
using DataLibrary.Model;
using DataLibrary.Repository.Interfases;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Service
{
    public class WeatherResponseService : IWeatherResponseService
    {
        private IRepository<WeatherResponse> _repository { get; set; }
        private IMapper _mapper { get; set; }
        public WeatherResponseService(IRepository<WeatherResponse> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public string GetHashCodeAllWeatherResponseDTO()
        {
            throw new NotImplementedException();
        }

        public string GetHashCodeSmallWeatherResponseDTO()
        {
            throw new NotImplementedException();
        }

        public WeatherResponseDTO GetWeatherResponseDTO(int WeatherResponseId)
        {
            return _mapper.Map<WeatherResponseDTO>(_repository.Get(WeatherResponseId));
        }

        public OperationDetails LoadingDataIntoDatabase(IList<WeatherResponseDTO> ListWeatherResponseDTOs)
        {
            try
            {
                for (int i = 0; i < ListWeatherResponseDTOs.Count; i++)
                {
                    _repository.Add(_mapper.Map<WeatherResponse>(ListWeatherResponseDTOs[i]), i);
                }
            }
            catch (Exception ex)
            {
                return new OperationDetails() { ErrorMessage = ex.Message, Message = "Loading errore", IsError = true };
            }
            return new OperationDetails() { IsError = false };
        }

        public OperationDetails PartialUpdate(WeatherResponseDTO weatherResponseDTO, int id)
        {
            var WS = _repository.GetAll().FirstOrDefault(x => x.Id == id);
            if (WS == null)
            {
                return new OperationDetails() { IsError = true, Message = "WeatherResponseDTO not found" };
            }
            else
            {
                return new OperationDetails() { IsError = false };
            } 
        }
    }
}
