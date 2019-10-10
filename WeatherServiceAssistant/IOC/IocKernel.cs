using BusinessLogic.Service;
using BusinessLogic.Service.Interfases;
using BusinessLogic.Until;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace WeatherServiceAssistant.IOC
{
    public static class IocKernel
    {
        private static UnityContainer unityContainer;
        public static T Get<T>()
        {
            if (unityContainer != null) return unityContainer.Resolve<T>();
            unityContainer = new UnityContainer();

            return unityContainer.Resolve<T>();
        }
        public static void RegisterInst<T>(T inst)
        {
            if (unityContainer != null) unityContainer.RegisterInstance<T>(inst);
        }
        public static void Inicialize()
        {
            unityContainer = new UnityContainer();
            unityContainer.RegisterBusinessType();
            unityContainer.RegisterType<IWeatherResponseService, WeatherResponseService>();
        }
    }
}
