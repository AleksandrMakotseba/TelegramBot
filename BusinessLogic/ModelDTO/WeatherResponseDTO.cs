using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ModelDTO
{
    public class WeatherResponseDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Dt { get; set; }
        public int Timezone { get; set; }
        public int Od { get; set; }
        public string @Base { get; set; }
        public CoordInfoDTO Coord { get; set; }
        public virtual IList<WeatherInfoDTO> Weather { get; set; }
        public MainInfoDTO Main { get; set; }
        public WindInfoDTO Wind { get; set; }
        public CloudsInfoDTO Clouds { get; set; }
        public SysInfoDTO Sys { get; set; }

        public WeatherResponseDTO()
        {
            Clouds = new CloudsInfoDTO();
            Weather = new List<WeatherInfoDTO>();
            Main = new MainInfoDTO();
            Wind = new WindInfoDTO();
            Clouds = new CloudsInfoDTO();
            Sys = new SysInfoDTO();
        }
    }
}
