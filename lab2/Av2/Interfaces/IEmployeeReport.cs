using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization.Interfaces
{
	public interface IEmployeeReport : IMessage
	{
		int EmployeeCount { set; }
		string BestEmployeeName { set; }
	}
}
