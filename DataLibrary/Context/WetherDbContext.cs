using DataLibrary.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataLibrary.Context
{
    public class WetherDbContext : DbContext 
    {
        public WetherDbContext():base(@"Data Source=(LocalDB)\MSSQLLocalDB; Initial Catalog=WetherDb; Integrated Security=True;")
        {
            Database.SetInitializer(new WetherDBInitializator());
        }
        public virtual DbSet<WeatherResponse> WeatherResponses { get; set; }
        //public virtual DbSet<CloudsInfo> Clouds { get; set; }
        //public virtual DbSet<CoordInfo> Coord { get; set; }
        //public virtual DbSet<MainInfo> Main { get; set; }
        //public virtual DbSet<SysInfo> Sys { get; set; }
        public virtual DbSet<WeatherInfo> Weathers { get; set; }
        //public virtual DbSet<WindInfo> Winds { get; set; }
    }
}