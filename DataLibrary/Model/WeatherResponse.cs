using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Model
{
    public class WeatherResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Dt { get; set; }
        public int Timezone { get; set; }
        public int Od { get; set; }
        public string @Base { get; set; }
        public CoordInfo Coord { get; set; }
        public virtual IList<WeatherInfo> Weather { get; set; }
        public MainInfo Main { get; set; }
        public WindInfo Wind { get; set; }
        public CloudsInfo Clouds { get; set; }
        public SysInfo Sys { get; set; }
        public WeatherResponse()
        {
            Clouds = new CloudsInfo();
            Weather = new List<WeatherInfo>();
            Main = new MainInfo();
            Wind = new WindInfo();
            Clouds = new CloudsInfo();
            Sys = new SysInfo();
        }
    }
}
