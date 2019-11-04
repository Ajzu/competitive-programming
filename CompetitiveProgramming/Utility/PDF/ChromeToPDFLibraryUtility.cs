using ChromeHtmlToPdfLib;
using System;

namespace CompetitiveProgramming.Utility.PDF
{
    public class ChromeToPDFLibraryUtility
    {
        public ChromeToPDFLibraryUtility()
        {

        }

        public void ConvertHtmlToPDF()
        {
            try
            {
                ConvertUri convertUri = new ConvertUri(@"C:\SampleCV\orange download.html");
                ChromeHtmlToPdfLib.Settings.PageSettings pageSettings = new ChromeHtmlToPdfLib.Settings.PageSettings();
                pageSettings.PrintBackground = true;

                Converter converter1 = new Converter();

                converter1.ConvertToPdf(convertUri, @"C:\SampleCV\competitiveprogramminggoogle.pdf", pageSettings);
            }
            catch (Exception ex)
            {
                // throw;
            }
        }
    }
}
