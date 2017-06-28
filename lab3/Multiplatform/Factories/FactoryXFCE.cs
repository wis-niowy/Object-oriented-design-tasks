using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Multiplatform.Interfaces;

namespace Multiplatform.Factories
{
    class FactoryXFCE: Factories.IFactory
    {
        public IButton GetButton(string content)
        {
            return new XFCE.ButtonXFCE(content);
        }
        public IDialogWindow GetDialogWindow(string name, List<Interfaces.ISlider> sliderList, List<Interfaces.IButton> buttonList)
        {
            return new XFCE.DialogWindowXFCE(name, sliderList, buttonList);
        }
        public ISlider GetSlider(params float[] args)
        {
            return new XFCE.SliderXFCE(args);
        }
    }
}
