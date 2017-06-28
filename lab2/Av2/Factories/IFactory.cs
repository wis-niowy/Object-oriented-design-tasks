using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization.Factories
{
    interface IFactory
    {
        Interfaces.IOwnerReport GetOwnerReport();
        Interfaces.IFundsReport GetFundsReport();
        Interfaces.IEmployeeReport GetEmployeeReport();
        Interfaces.IErrorMessage GetErrorMessage();
    }
}
