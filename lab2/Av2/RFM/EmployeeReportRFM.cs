using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization.RFM
{
    class EmployeeReportSF: Interfaces.IEmployeeReport
    {
        public int EmployeeCount { private get; set; }
        public string BestEmployeeName { private get; set; }
        public string Serialize()
        {
            string result = "{RFM}";
            result += EmployeeCount.ToString().MyStringReverse();
            if (EmployeeCount >= 0) result += "-";
            result += "&" + BestEmployeeName.MyStringReverse();
            result += "{RFM}";
            return result;
        }

    }
}
