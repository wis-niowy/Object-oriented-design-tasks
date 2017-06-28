using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization.Interfaces
{
	public interface IOwnerReport : IMessage
	{
		string OwnerName { set; }
		string OwnerStatus { set; }
	}
}
