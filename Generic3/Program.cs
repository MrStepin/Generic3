using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Generic3
{
    class Program
    {
        static void Main(string[] args)

        {
            //LongOperation<string> longOp = new LongOperation<string>();
            string Download()
            {
                Thread.Sleep(1);
                return "content";
            }
            int CalcSomeValue()
            {
                Thread.Sleep(1);
                return 108;
            }

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "d")
                {
                    Console.WriteLine(Download());
                }
                if (input == "v")
                {
                    Console.WriteLine(CalcSomeValue());
                }

                Console.ReadKey();
            }

        }
    }
}
