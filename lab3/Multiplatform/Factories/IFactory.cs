using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplatform.Factories
{
    interface IFactory
    {
        Interfaces.IButton GetButton(string arg);
        Interfaces.IDialogWindow GetDialogWindow(string name, List<Interfaces.ISlider> sliderList, List<Interfaces.IButton> buttonList);
        Interfaces.ISlider GetSlider(params float[] args);
    }
}
