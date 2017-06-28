using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization.RFM
{
    public class OwnerReportSF : Interfaces.IOwnerReport
    {
        public string OwnerName { private get; set; }
        public string OwnerStatus { private get; set; }
        public string Serialize()
        {
            string result = "{RFM}";
            result += OwnerName.MyStringReverse() + "&" + OwnerStatus.MyStringReverse();
            result += "{RFM}";
            return result;
        }
    }

}
