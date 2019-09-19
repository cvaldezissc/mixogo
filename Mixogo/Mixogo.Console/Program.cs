using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Mixogo.ClassesLibraries.Helpers;

namespace Mixogo.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Console.WriteLine(string.Format("Strings {0}, {1}", args[0], "SQQQ"));
            /*
            var helper = new XLSReportHelper();
            helper.ConfigureDocument();
            System.Console.WriteLine("Done");
            */

            var pdf = new PDFReportHelper();
            pdf.ConfigureDocument();
        }
    }
}
