using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CompetitiveProgramming.Utility.PDF
{
    public class PDFUtilitiesIText
    {
        public void HTMLToPDFV6()
        {
            Document Doc;
            Doc = new Document(PageSize.A4, 10f, 10f, 50f, 20f);

            string filename = "PaySlip";
            string outXml = "";// selectedhtml.Value;
            outXml = "<style>#tdiv1{background:red;color:white;}</style>" + outXml;
            outXml = outXml.Replace("px", "");
            outXml = outXml.Replace("<br>", "<br/>");

            MemoryStream memStream = new MemoryStream();
            TextReader xmlString = new StringReader(outXml);
            using (Document document = new Document())
            {
                PdfWriter writer = PdfWriter.GetInstance(document, memStream);
                document.Open();
                byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(outXml);
                MemoryStream ms = new MemoryStream(byteArray);
                XMLWorkerHelper.GetInstance().ParseXHtml(writer, document, ms, System.Text.Encoding.UTF8);
                document.Close();
            }

            //Response.ContentType = "application/pdf";
            //Response.AddHeader("content-disposition", "attachment;filename=" + filename + ".pdf");
            //Response.Cache.SetCacheability(HttpCacheability.NoCache);
            //Response.BinaryWrite(memStream.ToArray());
            //Response.End();
            //Response.Flush();
        }
    }
}
