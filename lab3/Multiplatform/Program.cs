using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Multiplatform.Interfaces;

namespace Multiplatform
{
	class Program
	{
		static void Main(string[] args)
		{
            Factories.IFactory factory = null;

			Console.WriteLine("<---------------------FIRST PLATFORM--------------------->");

            factory = new Factories.FactoryWP8();
            BuildDialogWindow(factory);

			Console.WriteLine("<---------------------SECOND PLATFORM--------------------->");

            factory = new Factories.FactoryXFCE();
            BuildDialogWindow(factory);

            Console.WriteLine("<---------------------THIRD PLATFORM--------------------->");

            factory = new Factories.FactorySolaris();
            BuildDialogWindow(factory);
        }

        static void BuildDialogWindow(Factories.IFactory factory)
        {
            List<ISlider> sliderList = new List<ISlider>();
            List<IButton> buttonList = new List<IButton>();
            sliderList.Add(factory.GetSlider(1, 10, 2));
            sliderList.Add(factory.GetSlider(10, 50, 3));
            sliderList.Add(factory.GetSlider(0, 100, 5));
            buttonList.Add(factory.GetButton("Cancel"));
            buttonList.Add(factory.GetButton("Accept"));
            IDialogWindow dialogWindow = factory.GetDialogWindow("UserSettings", sliderList, buttonList);
            foreach(var slider in sliderList)
            {
                for (int i = 1; i < 5; ++i)
                {
                    slider.ChangeValue(i * 4);
                }
            }
            foreach(var button in buttonList)
            {
                button.ButtonPressed();
                button.ButtonPressed();
            }
            dialogWindow.DrawDialog();
        }
	}
}
