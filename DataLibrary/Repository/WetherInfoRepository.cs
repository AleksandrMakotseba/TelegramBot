using DataLibrary.Context;
using DataLibrary.Model;
using System;
using System.Collections.Generic;

namespace DataLibrary.Repository.Interfases
{
    public class WetherInfoRepository : IRepository<WeatherInfo>
    {
        private WetherDbContext DbContext { get; set; }

        public WetherInfoRepository()
        {
            DbContext = new WetherDbContext();
        }

        public void Add(WeatherInfo obj, int id)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public WeatherInfo Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<WeatherInfo> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(WeatherInfo newObj, int id)
        {
            throw new NotImplementedException();
        }
    }
}
