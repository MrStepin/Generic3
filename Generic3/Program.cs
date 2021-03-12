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

            string rememberDownload = "1";
            string rememberCalc = "1";

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "d" && rememberDownload != "d")
                {
                    rememberDownload = "d";
                    Console.WriteLine(Download());
                }
                else if (input != "d" && rememberDownload == "d")
                {
                    Console.WriteLine(rememberDownload);
                }
                if (input == "v" && rememberCalc != "v")
                {
                    rememberCalc = "v";
                    Console.WriteLine(CalcSomeValue());
                }
                else if (input != "v" && rememberCalc == "v")
                {
                    Console.WriteLine(rememberCalc);
                }

            }

        }
    }
}
