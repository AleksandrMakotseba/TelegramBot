using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Model
{
    public class BotSettings
    {
        public string HTTP_API { get; private set; } = "";
        public string Name { get; private set; } = "HomeWork_Weatherbot";
        public string Key { get; private set; } = "";
    }
}
