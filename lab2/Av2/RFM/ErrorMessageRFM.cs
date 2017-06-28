using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Serialization.RFM
{
    class ErrorMessageSF: Interfaces.IErrorMessage
    {
        public string Serialize()
        {
            string result = "Error encountered";
            result = "{RFM}" + result.MyStringReverse() + "{RFM}";
            return result;
        }
        
    }
    
}
