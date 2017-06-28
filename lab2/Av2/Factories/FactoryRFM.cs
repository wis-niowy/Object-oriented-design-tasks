using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization.Factories
{
    class FactoryRFM: IFactory
    {
        public Interfaces.IOwnerReport GetOwnerReport()
        {
            return new RFM.OwnerReportSF();
        }
        public Interfaces.IFundsReport GetFundsReport()
        {
            return new RFM.FundsReportSF();
        }
        public Interfaces.IEmployeeReport GetEmployeeReport()
        {
            return new RFM.EmployeeReportSF();
        }
        public Interfaces.IErrorMessage GetErrorMessage()
        {
            return new RFM.ErrorMessageSF();
        }
    }
}
