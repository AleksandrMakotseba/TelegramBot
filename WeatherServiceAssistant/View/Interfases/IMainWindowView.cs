using BusinessLogic.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherServiceAssistant.View.Interfases
{
    public class IMainWindowView
    {
        event Func<OperationDetails> StartClick;
        event Func<OperationDetails> StopClick;
        event Func<OperationDetails> UpdateClick;
        event Func<OperationDetails> ChangeDemonstrationClick;
    }
}
