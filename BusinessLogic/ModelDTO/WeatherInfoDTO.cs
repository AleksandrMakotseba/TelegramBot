using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ModelDTO
{
    public class WeatherInfoDTO
    {
        public int Id { get; set; }
        public string Main { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public IEnumerable<WeatherResponseDTO> WeatherResponses { get; set; }
    }
}
