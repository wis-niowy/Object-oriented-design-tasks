using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplatform.Solaris
{
    class DialogWindowSolaris: Interfaces.IDialogWindow
    {
        private string dialogName;
        private List<Interfaces.ISlider> sliderList;
        private List<Interfaces.IButton> buttonList;

        public DialogWindowSolaris(string name, List<Interfaces.ISlider> sliderList, List<Interfaces.IButton> buttonList)
        {
            this.dialogName = name;
            this.sliderList = sliderList;
            this.buttonList = new List<Interfaces.IButton>();
            this.buttonList.Add(new ButtonSolaris("Abandon all settings"));
        }
        public void DrawDialog()
        {
            Console.WriteLine("Solaris dialog: {0}", dialogName);
            foreach (var slider in sliderList)
            {
                slider.DrawContent();
            }
            
            Console.WriteLine("You can change these settings but Solaris OS does not support applying them");
            buttonList[0].DrawContent();
        }
    }
}
