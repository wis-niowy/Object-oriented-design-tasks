using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplatform.XFCE
{
    class DialogWindowXFCE: Interfaces.IDialogWindow
    {
        private string dialogName;
        private List<Interfaces.ISlider> sliderList;
        private List<Interfaces.IButton> buttonList;

        public DialogWindowXFCE(string name, List<Interfaces.ISlider> sliderList, List<Interfaces.IButton> buttonList)
        {
            this.dialogName = name;
            this.sliderList = sliderList;
            this.buttonList = buttonList;
        }
        public void DrawDialog()
        {
            Console.WriteLine("XFCE dialog: {0}", dialogName);
            foreach (var slider in sliderList)
            {
                slider.DrawContent();
            }
            foreach (var button in buttonList)
            {
                button.DrawContent();
            }
            Console.WriteLine("To accept press ^ O +^ X, to cancel press ESC");
        }
    }
}
