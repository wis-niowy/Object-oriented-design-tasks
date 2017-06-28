using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texts
{
    class Program
    {
        static void Main(string[] args)
        {
            TextReader tr1 = new TextReader("input1.txt");
            TextReader tr2 = new TextReader("input2.txt");
            TextReader tr3 = new TextReader("input3.txt");

            Console.WriteLine("\n*************************\nFile1:\n");
            for (int i = 0; i < 100; ++i)
            {
                Console.Write(tr1.PrintNextChar());
            }

            Console.WriteLine("\n*************************\nFile2:\n");
            for (int i = 0; i < 100; ++i)
            {
                Console.Write(tr2.PrintNextChar());
            }

            Console.WriteLine("\n*************************\nFile3:\n");
            for (int i = 0; i < 100; ++i)
            {
                Console.Write(tr3.PrintNextChar());
            }

            ///////////// TASK 1 ////////////////////

            TextReader x11 = new X1("input1.txt");
            TextReader x12 = new X1("input2.txt");
            TextReader x13 = new X1("input3.txt");

            Console.WriteLine("\n*************************\nFile1:\n");
            for (int i = 0; i < 100; ++i)
            {
                Console.Write(x11.PrintNextChar());
            }

            Console.WriteLine("\n*************************\nFile2:\n");
            for (int i = 0; i < 100; ++i)
            {
                Console.Write(x12.PrintNextChar());
            }

            Console.WriteLine("\n*************************\nFile3:\n");
            for (int i = 0; i < 100; ++i)
            {
                Console.Write(x13.PrintNextChar());
            }

            ///////////// TASK 2 ////////////////////

            TextReader x21 = new X2("input1.txt");
            TextReader x22 = new X2("input2.txt");
            TextReader x23 = new X2("input3.txt");

            Console.WriteLine("\n*************************\nFile1:\n");
            for (int i = 0; i < 100; ++i)
            {
                Console.Write(x21.PrintNextChar());
            }

            Console.WriteLine("\n*************************\nFile2:\n");
            for (int i = 0; i < 100; ++i)
            {
                Console.Write(x22.PrintNextChar());
            }

            Console.WriteLine("\n*************************\nFile3:\n");
            for (int i = 0; i < 100; ++i)
            {
                Console.Write(x23.PrintNextChar());
            }

            ///////////// TASK 3 ////////////////////

            TextReader x31 = new X3("input1.txt");
            TextReader x32 = new X3("input2.txt");
            TextReader x33 = new X3("input3.txt");

            Console.WriteLine("\n*************************\nFile1:\n");
            for (int i = 0; i < 100; ++i)
            {
                Console.Write(x31.PrintNextChar());
            }

            Console.WriteLine("\n*************************\nFile2:\n");
            for (int i = 0; i < 100; ++i)
            {
                Console.Write(x32.PrintNextChar());
            }

            Console.WriteLine("\n*************************\nFile3:\n");
            for (int i = 0; i < 100; ++i)
            {
                Console.Write(x33.PrintNextChar());
            }

            ///////////// TASK 4 ////////////////////

            TextReader x41 = new X4("input1.txt");
            TextReader x42 = new X4("input2.txt");
            TextReader x43 = new X4("input3.txt");

            Console.WriteLine("\n*************************\nFile1:\n");
            for (int i = 0; i < 100; ++i)
            {
                Console.Write(x41.PrintNextChar());
            }

            Console.WriteLine("\n*************************\nFile2:\n");
            for (int i = 0; i < 100; ++i)
            {
                Console.Write(x42.PrintNextChar());
            }

            Console.WriteLine("\n*************************\nFile3:\n");
            for (int i = 0; i < 100; ++i)
            {
                Console.Write(x43.PrintNextChar());
            }

            ///////////// TASK 5 ////////////////////

            TextReader x51 = new X5("input1.txt");
            TextReader x52 = new X5("input2.txt");
            TextReader x53 = new X5("input3.txt");

            Console.WriteLine("\n*************************\nFile1:\n");
            for (int i = 0; i < 100; ++i)
            {
                Console.Write(x51.PrintNextChar());
            }

            Console.WriteLine("\n*************************\nFile2:\n");
            for (int i = 0; i < 100; ++i)
            {
                Console.Write(x52.PrintNextChar());
            }

            Console.WriteLine("\n*************************\nFile3:\n");
            for (int i = 0; i < 100; ++i)
            {
                Console.Write(x53.PrintNextChar());
            }

            ///////////// TASK 6 ////////////////////

            TextReader x61 = new X6("input1.txt", "input2.txt");
            TextReader x62 = new X6("input2.txt", "input3.txt");
            TextReader x63 = new X6("aaaa.txt", "bbbb.txt");

            Console.WriteLine("\n*************************\nFile1 and File2:\n");
            for (int i = 0; i < 100; ++i)
            {
                Console.Write(x61.PrintNextChar());
            }

            Console.WriteLine("\n*************************\nFile2 and File3:\n");
            for (int i = 0; i < 100; ++i)
            {
                Console.Write(x62.PrintNextChar());
            }

            Console.WriteLine("\n*************************\naaaa.txt and bbbb.txt:\n");
            for (int i = 0; i < 100; ++i)
            {
                Console.Write(x63.PrintNextChar());
            }


        }
    }
}
