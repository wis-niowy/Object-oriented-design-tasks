using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization.EF
{
    class FundsReportSF: Interfaces.IFundsReport
    {
        public float FundsAmount { private get; set; }
        public int AccountsCount { private get; set; }
        public string Serialize()
        {
            string result = "{EF}";
            result += "?" + FundsAmount + "?" + "$" + "?" + AccountsCount + "?";
            result += "{EF}";
            return result;
        }
    }
}
