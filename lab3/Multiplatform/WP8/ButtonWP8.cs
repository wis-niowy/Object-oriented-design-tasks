using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplatform.WP8
{
    class ButtonWP8: Interfaces.IButton
    {
        private string content;
        public ButtonWP8(string cont)
        {
            this.content = cont;
            Console.WriteLine("WP8 Button created");
        }
        public void ButtonPressed()
        {
            Console.WriteLine("WP8 Button pressed, content: {0}", content);
        }

        public void DrawContent()
        {
            Console.WriteLine(content);
        }
    }
}
