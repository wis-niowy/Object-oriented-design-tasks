using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization.EF
{
    public class OwnerReportSF : Interfaces.IOwnerReport
    {
        public string OwnerName { private get; set; }
        public string OwnerStatus { private get; set; }
        public string Serialize()
        {
            string result = "{EF}";
            result += OwnerName.ToUpper() + "$" + OwnerStatus.ToUpper();
            result += "{EF}";
            return result;
        }
    }

}
