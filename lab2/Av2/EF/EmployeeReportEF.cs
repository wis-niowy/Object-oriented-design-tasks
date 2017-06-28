using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization.EF
{
    class EmployeeReportSF: Interfaces.IEmployeeReport
    {
        public int EmployeeCount { private get; set; }
        public string BestEmployeeName { private get; set; }
        public string Serialize()
        {
            string result = "{EF}";
            result += "?" + EmployeeCount + "?" + "$" + BestEmployeeName.ToUpper(); ;
            result += "{EF}";
            return result;
        }

    }
}
