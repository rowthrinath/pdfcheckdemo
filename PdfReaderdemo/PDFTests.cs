using iTextSharp.text;
using iTextSharp.text.pdf;
using NUnit.Framework;
using PdfToText;
using System;
using System.Collections.Generic;
using System.IO;

namespace PDFTests
{
    public class readfrompdf
    {


        string requiredPath = Path.GetDirectoryName(Path.GetDirectoryName(
        System.IO.Path.GetDirectoryName(
        System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)));

        public void readfrompdffile()
        {
            string clearedfilepath = requiredPath.Replace("file:\\", "").Replace("\\", "/");
            string file = clearedfilepath + "/terms-and-conditions.pdf";
            string outFile = clearedfilepath + "/terms-and-conditions.txt";

            try

            {

                if (!File.Exists(file))
                {
                    file = Path.GetFullPath(file);
                    if (!File.Exists(file))
                    {
                        Console.WriteLine("Please give in the path to the PDF file.");
                    }
                }

                PDFParser pdfParser = new PDFParser();
                pdfParser.ExtractText(file, outFile);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }


        }


        static void DisplayUsage()
        {
            Console.WriteLine();
            Console.WriteLine("Usage:\tpdftotext FILE");
            Console.WriteLine();
            Console.WriteLine("\tFILE\t the path to the PDF file, it may be relative or absolute.");
            Console.WriteLine();
        }


        public bool checkline(string linetocheck)
        {

            string clearedfilepath = requiredPath.Replace("file:\\", "").Replace("\\", "/");
            string file = clearedfilepath + "/terms-and-conditions.pdf";
            string outFile = clearedfilepath + "/terms-and-conditions.txt";



            using (StreamReader w = new StreamReader(outFile))
            {
                string alltextcontents = w.ReadToEnd().ToString();
                Console.WriteLine(alltextcontents);
                if (alltextcontents.Contains(linetocheck))
                {
                    Assert.Pass("Text Found: " + linetocheck);
                    return true;
                }
                else
                {
                    Assert.Fail("Text not Found: " + linetocheck);
                    return false;
                }
            }
           

        }
    }
}


        





