using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Service
{
    public class OperationDetails
    {
        public bool IsError { get; set; }
        public string Message { get; set; }
        public string ErrorMessage { get; set; }
        // возможно даже поле exception
    }
}
