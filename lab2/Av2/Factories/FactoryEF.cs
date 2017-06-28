using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization.Factories
{
    class FactoryEF: IFactory
    {
        public Interfaces.IOwnerReport GetOwnerReport()
        {
            return new EF.OwnerReportSF();
        }
        public Interfaces.IFundsReport GetFundsReport()
        {
            return new EF.FundsReportSF();
        }
        public Interfaces.IEmployeeReport GetEmployeeReport()
        {
            return new EF.EmployeeReportSF();
        }
        public Interfaces.IErrorMessage GetErrorMessage()
        {
            return new EF.ErrorMessageSF();
        }
    }
}
