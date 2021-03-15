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
            LongOperation<string> longOp = new LongOperation<string>();

            string Download()
            {
                Console.WriteLine("Download");
                return "content";
            }
            
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "d")
                {
                    if (!longOp.HasValue)
                    {
                        longOp.Value = Download();
                    }
                    Console.WriteLine(longOp.Value);
                }
            }

            //
            //string rememberDownload = "null";
            //int rememberCalc = 0;
            //bool hasValueD = false;
            //bool hasValueV = false;
            //
            //while (true)
            //{
            //    var input = Console.ReadLine();
            //    if (input == "d")
            //    {
            //        if (!hasValueD)
            //        {
            //            hasValueD = true;
            //            rememberDownload = Download();
            //        }
            //        Console.WriteLine(rememberDownload);
            //    }
            //
            //    if (input == "v")
            //    {
            //        if (!hasValueV)
            //        {
            //            hasValueV = true;
            //            rememberCalc = CalcSomeValue();
            //        }
            //        Console.WriteLine(rememberCalc);
            //    }
            //
            //}

        }
    }
}
