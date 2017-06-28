using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplatform.XFCE
{
    class SliderXFCE: Interfaces.ISlider
    {
        private float minValue;
        private float maxValue;
        private float incrementStep;

        public SliderXFCE(params float[] args)
        {
            minValue = args[0];
            maxValue = args[1];
            incrementStep = args[2];
            CurrentValue = minValue;
            Console.WriteLine("XFCE Slider created");
        }
        public float CurrentValue
        {
            get; private set;
        }

        public void ChangeValue(float value)
        {
            CurrentValue += value * incrementStep;
            CurrentValue = CurrentValue % (maxValue - minValue) + minValue;
            Console.WriteLine("New XFCE Slider value: {0}", CurrentValue);
        }

        public void DrawContent()
        {
            Console.WriteLine("PlatformName slider from {0} to {1} with step: {2}, current: {3}",
                minValue, maxValue, incrementStep, CurrentValue);

        }
    }
}
