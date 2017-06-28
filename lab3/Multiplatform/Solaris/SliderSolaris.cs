using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplatform.Solaris
{
    class SliderSolaris: Interfaces.ISlider
    {
        private float minValue;
        private float maxValue;
        private float incrementStep;

        public SliderSolaris(params float[] args)
        {
            minValue = args[0];
            maxValue = args[1];
            incrementStep = args[2];
            CurrentValue = minValue;
            Console.WriteLine("Solaris Slider created");
        }
        public float CurrentValue
        {
            get; private set;
        }

        public void ChangeValue(float value)
        {
            if (value > 0)
                CurrentValue += value * incrementStep;
            else
                CurrentValue = minValue;
            Console.WriteLine("New Solaris Slider value: {0}", CurrentValue);
        }

        public void DrawContent()
        {
            Console.WriteLine("PlatformName slider from {0} to {1} with step: {2}, current: {3}",
                minValue, maxValue, incrementStep, CurrentValue);

        }
    }
}
