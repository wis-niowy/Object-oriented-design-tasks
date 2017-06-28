using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplatform.WP8
{
    class DialogWindowWP8: Interfaces.IDialogWindow
    {
        private string dialogName;
        private List<Interfaces.ISlider> sliderList;
        private List<Interfaces.IButton> buttonList;

        public DialogWindowWP8(string name, List<Interfaces.ISlider> sliderList, List<Interfaces.IButton> buttonList)
        {
            this.dialogName = name;
            this.sliderList = sliderList;
            this.buttonList = buttonList;
        }
        public void DrawDialog()
        {
            Console.WriteLine("Drawing WP8 dialog: {0}", dialogName);
            foreach (var slider in sliderList)
            {
                slider.DrawContent();
            }
            foreach (var button in buttonList)
            {
                button.DrawContent();
            }
        }
    }
}
