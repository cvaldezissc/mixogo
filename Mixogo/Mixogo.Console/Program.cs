using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Mixogo.ClassesLibraries.Helpers;

namespace Mixogo.Console1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Running Program");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Quick Test");
            Console.WriteLine(DateTime.Now.ToString());


            //Console.WriteLine("Do you Want to Continue? (Y/N)");
            //var answer = Console.ReadLine();

             //if(answer != "y" || answer != "Y")
            //{
              //  Console.WriteLine("Nothing Was done");
            //}
            //else
            //{
                var xls = new XLSReportHelper();
            var xmlDirectoryContainer = @"C:\Users\CBQA-0090\Downloads\xmls y pdfs\";
                var newXLSFileAbsolutePath = @"C:\Users\CBQA-0090\Downloads\xmls y pdfs\generated2_own.xls";
                var xmlDirectory = new List<string>()
                {
                    @"C:\\Users\\CBQA-0090\\Downloads\\xmls y pdfs\\02_BII931004P61_JUN68320_50050237821.xml"
                };
                xls.ConfigureDocumentTemplate(newXLSFileAbsolutePath);

                if(xls.AddDocumentContent(newXLSFileAbsolutePath, xmlDirectory.ToArray()))
                {
                    Console.WriteLine("Is Done");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("There was an error");
                    Console.ReadLine();
                }
            //}
            //System.Console.WriteLine(string.Format("Strings {0}, {1}", args[0], "SQQQ"));
            /*
            var helper = new XLSReportHelper();
            helper.ConfigureDocument();
            System.Console.WriteLine("Done");
            */

            //var pdf = new XLSReportHelper();
            //pdf.ConfigureDocument();
        }
    }
}
