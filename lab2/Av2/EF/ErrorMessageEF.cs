using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization.EF
{
    class ErrorMessageSF: Interfaces.IErrorMessage
    {
        public string Serialize()
        {
            string result = "Error encountered";
            result = "{EF}" + result.ToUpper() + "{EF}";
            return result;
        }
    }
}
