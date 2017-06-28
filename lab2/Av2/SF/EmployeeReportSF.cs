using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization.SF
{
    class EmployeeReportSF: Interfaces.IEmployeeReport
    {
        public int EmployeeCount { private get; set; }
        public string BestEmployeeName { private get; set; }
        public string Serialize()
        {
            string result = "{SF}";
            result += EmployeeCount + "/" + BestEmployeeName;
            result += "{SF}";
            return result;
        }

    }
}
