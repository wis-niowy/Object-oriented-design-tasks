using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplatform.Solaris
{
    class ButtonSolaris: Interfaces.IButton
    {
        private string content;
        public ButtonSolaris(string cont)
        {
            int len = cont.Length;
            this.content = cont.Substring(0, len / 2) + "Oracle" + cont.Substring(len / 2 + 1, len / 2 -1);
            Console.WriteLine("Solaris Button created");
        }
        public void ButtonPressed()
        {
            
        }

        public void DrawContent()
        {
            Console.WriteLine(content);
        }
    }
}
