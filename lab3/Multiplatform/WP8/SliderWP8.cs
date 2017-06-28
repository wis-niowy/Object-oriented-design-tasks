using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplatform.WP8
{
    class SliderWP8: Interfaces.ISlider
    {
        private float minValue;
        private float maxValue;
        private float incrementStep;

        public SliderWP8(params float[] args)
        {
            minValue = args[0];
            maxValue = args[1];
            incrementStep = args[2];
            CurrentValue = minValue;
            Console.WriteLine("WP8 Slider created");
        }
        public float CurrentValue
        {
            get; private set;
        }

        public void ChangeValue(float value)
        {
            CurrentValue += value * incrementStep;
            if (CurrentValue > maxValue) CurrentValue = maxValue;
            if (CurrentValue < minValue) CurrentValue = minValue;
            Console.WriteLine("New WP8 Slider value: {0}", CurrentValue);
        }

        public void DrawContent()
        {
            Console.WriteLine("PlatformName slider from {0} to {1} with step: {2}, current: {3}",
                minValue, maxValue, incrementStep, CurrentValue);

        }
    }
}
