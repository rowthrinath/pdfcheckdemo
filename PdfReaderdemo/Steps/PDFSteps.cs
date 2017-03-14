using PDFTests;
using System;
using TechTalk.SpecFlow;

namespace PdfReaderdemo.Steps
{
    [Binding]
    public class ReadFromPDFSteps
    {
        [Given(@"I have the expected pdf file")]
        public void GivenIHaveTheExpectedPdfFile()
        {
            Console.WriteLine("Check file existes");
        }
        
        [Then(@"I open and read text from PDF")]
        public void ThenIOpenAndReadTextFromPDF()
        {
            var readpdf = new readfrompdf();
            readpdf.readfrompdffile();
        }
        
        [Then(@"I validate text in pdf")]
        public void ThenIValidateTextInPdf(Table table)
        {
            var linetocheck = table.Rows[0];
            new readfrompdf().checkline(linetocheck["Linetocheck"]);
        }
    }
}
