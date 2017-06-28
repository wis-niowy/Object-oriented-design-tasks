using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization.Factories
{
    class FactorySF: IFactory
    {
        public Interfaces.IOwnerReport GetOwnerReport()
        {
            return new SF.OwnerReportSF();
        }
        public Interfaces.IFundsReport GetFundsReport()
        {
            return new SF.FundsReportSF();
        }
        public Interfaces.IEmployeeReport GetEmployeeReport()
        {
            return new SF.EmployeeReportSF();
        }
        public Interfaces.IErrorMessage GetErrorMessage()
        {
            return new SF.ErrorMessageSF();
        }
    }
}
