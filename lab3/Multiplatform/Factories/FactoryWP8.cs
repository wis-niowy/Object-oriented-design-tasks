using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Multiplatform.Interfaces;

namespace Multiplatform.Factories
{
    class FactoryWP8: Factories.IFactory
    {
        public IButton GetButton(string content)
        {
            return new WP8.ButtonWP8(content);
        }
        public IDialogWindow GetDialogWindow(string name, List<Interfaces.ISlider> sliderList, List<Interfaces.IButton> buttonList)
        {
            return new WP8.DialogWindowWP8(name, sliderList, buttonList);
        }
        public ISlider GetSlider(params float[] args)
        {
            return new WP8.SliderWP8(args);
        }
    }
}
