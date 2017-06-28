using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization.Interfaces
{
	public interface IFundsReport : IMessage
	{
		float FundsAmount { set; }
		int AccountsCount { set; }
	}
}
