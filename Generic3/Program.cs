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
                Console.WriteLine("Download Started");
                return "content";
            }
            int CalcSomeValue()
            {
                Console.WriteLine("Calc Started");
                return 108;
            }

            string rememberInputD = "1";
            string rememberInputV = "1";
            string rememberDownload = "null";
            int rememberCalc = 0;

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "d" && rememberInputD != "d")
                {
                    rememberInputD = "d";
                    rememberDownload = Download();
                    Console.WriteLine(Download());
                }
                else if (input != "d" && rememberInputD == "d")
                {
                    Console.WriteLine(rememberDownload);
                }

                if (input == "v" && rememberInputV != "v")
                {
                    rememberInputV = "v";
                    rememberCalc = CalcSomeValue();
                    Console.WriteLine(CalcSomeValue());
                }
                else if (input != "v" && rememberInputV == "v")
                {
                    Console.WriteLine(rememberCalc);
                }

            }

        }
    }
}
