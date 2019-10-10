using AutoMapper;
using DataLibrary.Model;
using DataLibrary.Repository.Interfases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace BusinessLogic.Until
{
    public static class DiRegister
    {
        public static void RegisterBusinessType(this UnityContainer container)
        {
            container.RegisterType<IRepository<WeatherResponse>, WeatherResponseRepository>();
            container.RegisterType<IMapper, Mapper>();
        }
    }
}
