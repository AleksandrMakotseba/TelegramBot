using DataLibrary.Context;
using DataLibrary.Model;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DataLibrary.Repository.Interfases
{
    public class WeatherResponseRepository : IRepository<WeatherResponse>
    {
        private WetherDbContext DbContext { get; set; }
        public WeatherResponseRepository()
        {
            DbContext = new WetherDbContext();
        }

        public void Add(WeatherResponse obj, int id)
        {
            DbContext.WeatherResponses.Add(obj);
            DbContext.SaveChanges();
        }

        //public void Clear(int id)//возможно понадобится передать по id
        public void Clear()
        {
            DbContext.WeatherResponses.RemoveRange(DbContext.WeatherResponses);
            DbContext.SaveChanges();
        }

        public WeatherResponse Get(int id)
        {
            return DbContext.WeatherResponses.FirstOrDefault(x => x.Id == id);
        }

        public IList<WeatherResponse> GetAll()
        {
            return DbContext.WeatherResponses.ToList();
        }

        public void Remove(int id)
        {
            DbContext.WeatherResponses.Remove(DbContext.WeatherResponses.FirstOrDefault(x => x.Id == id));
            DbContext.SaveChanges();
        }

        public void Update(WeatherResponse newObj, int id)
        {
            WeatherResponse oldWeatherResponse = DbContext.WeatherResponses.FirstOrDefault(x => x.Id == id);
            oldWeatherResponse.Name = newObj.Name;
            //перечислить все данные что будут обновляться
            DbContext.Entry(oldWeatherResponse).State = EntityState.Modified;
            DbContext.SaveChanges();
        }
    }
}
