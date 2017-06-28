using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization.RFM
{
    class FundsReportSF: Interfaces.IFundsReport
    {
        public float FundsAmount { private get; set; }
        public int AccountsCount { private get; set; }
        public string Serialize()
        {
            string result = "{RFM}";
            result += FundsAmount.ToString().MyStringReverse();
            if (FundsAmount >= 0) result += "-";
            result += "&";
            result += AccountsCount.ToString().MyStringReverse();
            if (AccountsCount >= 0) result += "-";
            result += "{RFM}";
            return result;
        }
    }
}
