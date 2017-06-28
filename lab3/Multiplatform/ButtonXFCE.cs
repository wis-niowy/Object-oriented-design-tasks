using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplatform.XFCE
{
    class ButtonXFCE: Interfaces.IButton
    {
        private string content;
        private int counter;
        public ButtonXFCE(string cont)
        {
            this.content = cont.ToLower();
            Console.WriteLine("XFCE Button created");
        }
        public void ButtonPressed()
        {
            Console.WriteLine("XFCE Button pressed {0} times", ++counter);
        }

        public void DrawContent()
        {
            Console.WriteLine(content);
        }
    }
}
