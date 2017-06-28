using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texts
{
    public class TextReader
    {
        private StreamReader MyStream
        {
            get;
            set;
        }
        public TextReader(string filename)
        {
            MyStream = new StreamReader(filename);
        }
        protected TextReader()
        { }
        private char ReadNextChar()
        {
            if (MyStream.Peek() < 0)
            {
                MyStream.DiscardBufferedData();
                MyStream.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);
            }
            return (char)MyStream.Read();
        }

        public virtual char PrintNextChar()
        {
            return ReadNextChar();
        }
    }

    public class X1: TextReader
    {
        public X1(string filename): base(filename)
        {
        }

        public override char PrintNextChar()
        {
            return base.PrintNextChar().ToString().ToUpper()[0];
        }
    }

    public class X2: TextReader
    {
        public X2(string filename): base(filename)
        {
        }

        public override char PrintNextChar()
        {
            char newChar = base.PrintNextChar();
            while (newChar == '\r')
            {
                newChar = base.PrintNextChar();
            }
            if (newChar == '\n') newChar = '\t';
            else if (newChar == '\t') newChar = ' ';
            return newChar;
        }
    }

    public class X3 : TextReader
    {
        public X3(string filename) : base(filename)
        {
        }

        public override char PrintNextChar()
        {
            char newChar = base.PrintNextChar();
            while (newChar == 'A')
            {
                newChar = base.PrintNextChar();
            }
            if (newChar == 'a') newChar = 'A';
            return newChar;
        }
    }

    public class X4 : TextReader
    {
        private int counter;

        public X4(string filename) : base(filename)
        {
        }

        public override char PrintNextChar()
        {
            char newChar = base.PrintNextChar();
            if (counter % 2 == 1)
                newChar = base.PrintNextChar();
            counter++;
            return newChar;
        }
    }

    public class X5 : TextReader
    {
        private char lastChar;
        private bool flag;

        public X5(string filename) : base(filename)
        {
        }

        public override char PrintNextChar()
        {
            if (flag)
            {
                flag = false;
                return lastChar;
            }
            char newChar = base.PrintNextChar();
            lastChar = newChar;
            flag = true;
            return newChar;
        }
    }

    public class X6 : TextReader
    {
        private TextReader MyStream1;
        private TextReader MyStream2;
        private int currStream;

        public X6(string filename1, string filename2)
        {
            MyStream1 = new TextReader(filename1);
            MyStream2 = new TextReader(filename2);
            currStream = 1;
        }

        public override char PrintNextChar()
        {
            char newChar;
            if (currStream == 1)
            {
                newChar = MyStream1.PrintNextChar();//base.PrintNextChar();
                currStream = 2;
            }
            else
            {
                newChar = MyStream2.PrintNextChar();
                currStream = 1;
            }
            return newChar;
        }
    }






}
