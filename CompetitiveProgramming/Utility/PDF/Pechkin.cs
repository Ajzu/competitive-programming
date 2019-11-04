using Pechkin;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProgramming.Utility.PDF
{
    public class Pechkin
    {
        //private void ConvertToPdf()
        //{
        //    var loadPath = Server.MapPath("~/HtmlTemplates");
        //    var loadFile = Path.Combine(loadPath, "Test.html");
        //    var savePath = Server.MapPath("~/Pdf");
        //    var saveFile = Path.Combine(savePath, DateTime.Now.ToString("HH-mm-ss.fff") + ".pdf");

        //    var globalConfig = new GlobalConfig()
        //        .SetMargins(0, 0, 0, 0)
        //        .SetPaperSize(PaperKind.A4);

        //    var pdfWriter = new SynchronizedPechkin(globalConfig);

        //    pdfWriter.Error += OnError;
        //    pdfWriter.Warning += OnWarning;

        //    var objectConfig = new ObjectConfig()
        //        .SetPrintBackground(true)
        //        .SetIntelligentShrinking(false);

        //    var pdfBuffer = pdfWriter.Convert(objectConfig, File.ReadAllText(loadFile));

        //    File.WriteAllBytes(saveFile, pdfBuffer);
        //}

        private void OnWarning(SimplePechkin converter, string warningtext)
        {
            throw new NotImplementedException();
        }

        private void OnError(SimplePechkin converter, string errortext)
        {
            throw new NotImplementedException();
        }
    }
}
