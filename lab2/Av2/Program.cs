using Serialization.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
	class Program
	{

		static void Main(string[] args)
		{
            List<Interfaces.IMessage> msgList = new List<IMessage>();
            Factories.IFactory factory = null;
			Console.WriteLine("<---------------------STANDARD FORMAT MESSAGES--------------------->");

            factory = new Factories.FactorySF();
            msgList = ClientProgram(factory);
            foreach(var msg in msgList)
            {
                Console.WriteLine(msg.Serialize());
            }

			Console.WriteLine("<---------------------EXTENDED FORMAT MESSAGES--------------------->");

            factory = new Factories.FactoryEF();
            msgList = ClientProgram(factory);
            foreach (var msg in msgList)
            {
                Console.WriteLine(msg.Serialize());
            }

            Console.WriteLine("<---------------------RANDOM FORMAT MESSAGES--------------------->");

            factory = new Factories.FactoryRFM();
            msgList = ClientProgram(factory);
            foreach (var msg in msgList)
            {
                Console.WriteLine(msg.Serialize());
            }

        }

        private static List<Interfaces.IMessage> ClientProgram(Factories.IFactory factory)
        {
            List<Interfaces.IMessage> msgList = new List<IMessage>();

            Interfaces.IOwnerReport ownerReport = factory.GetOwnerReport();
            ownerReport.OwnerName = "John";
            ownerReport.OwnerStatus = "Status";
            msgList.Add(ownerReport);
            Interfaces.IFundsReport fundsReport = factory.GetFundsReport();
            fundsReport.AccountsCount = 20;
            fundsReport.FundsAmount = 15000;
            msgList.Add(fundsReport);
            Interfaces.IEmployeeReport employeeReport = factory.GetEmployeeReport();
            employeeReport.BestEmployeeName = "BestName";
            employeeReport.EmployeeCount = 10;
            msgList.Add(employeeReport);
            Interfaces.IErrorMessage errMsg = factory.GetErrorMessage();
            msgList.Add(errMsg); 

            return msgList;
        }

       
	}

    public static class Extensions
    {
        public static string MyStringReverse(this string str)
        {
            char[] temp = str.ToCharArray();
            Array.Reverse(temp);
            return new String(temp);
        }
    }
}
