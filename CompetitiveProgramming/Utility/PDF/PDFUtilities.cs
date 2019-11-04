using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using Microsoft.TeamFoundation.WorkItemTracking.Internals;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web;
using System.Net;
using TheArtOfDev.HtmlRenderer.PdfSharp;
using PdfSharp;

namespace CompetitiveProgramming.Utility.PDF
{
    public class PDFUtilities
    {
        public PDFUtilities()
        {

        }

        
        public void HTMLFileToString()
        {
            // Method 1
            string pathToHTMLFile = @"C:\Users\asingh30\Downloads\sample cv\purple light download.html"; // @"C:\temp\someFile.html";
            string htmlToString = File.ReadAllText(pathToHTMLFile);

            //Method 2
            string htmlString = "";
            using (FileStream fs = File.Open(pathToHTMLFile, FileMode.Open, FileAccess.ReadWrite))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    htmlString = sr.ReadToEnd();
                }
            }
        }

        public void HTMLToPDFV5()
        {
            // string html = File.ReadAllText("input.htm");
            string html = File.ReadAllText(@"C:\Users\asingh30\Downloads\sample cv\purple light download.html");
            PdfSharp.Pdf.PdfDocument pdf3 = PdfGenerator.GeneratePdf(html, PdfSharp.PageSize.A4);
            pdf3.Save(@"C:\Users\asingh30\Downloads\sample cv\purple light downloadPDf.pdf");

            //PdfDocument pdf = PdfGenerator.GeneratePdf(html, PdfSharp.PageSize.A4);
            //pdf.Save("document.pdf");

            


            //PdfGenerateConfig config = new PdfGenerateConfig();
            //config.PageSize = PageSize.A4;
            //config.SetMargins(20);
            //PdfDocument pdf2 = PdfGenerator.GeneratePdf(html, PdfSharp.PageSize.A4);//, null, DemoUtils.OnStylesheetLoad, HtmlRenderingHelper.OnImageLoadPdfSharp);
        }




        //public void HTMLtoPDFV4()
        //{
        //    // instantiate a html to pdf converter object 
        //    HtmlToPdf converter = new HtmlToPdf();

        //    // create a new pdf document converting an url 
        //    PdfDocument doc = converter.ConvertUrl(collection["TxtUrl"]);

        //    // save pdf document 
        //    byte[] pdf = doc.Save();

        //    // close pdf document 
        //    doc.Close();

        //    // return resulted pdf document 
        //    FileResult fileResult = new FileContentResult(pdf, "application/pdf");
        //    fileResult.FileDownloadName = "Document.pdf";
        //}


        //public void HTMLtoPDFV3()
        //{
        //    try
        //    {
        //        HtmlConverter.ConvertToPdf( new FileInfo(@"Path\to\Html\File.html"), new FileInfo(@"Path\to\Pdf\File.pdf"));
        //    }
        //    catch (Exception ex)
        //    {

        //        throw;
        //    }
        //}
        //protected void PendingOrdersPDF_Click(object sender, EventArgs e)
        //{
        //    if (PendingOrdersGV.Rows.Count > 0)
        //    {
        //        //to allow paging=false & change style.
        //        PendingOrdersGV.HeaderStyle.ForeColor = System.Drawing.Color.Black;
        //        PendingOrdersGV.BorderColor = Color.Gray;
        //        PendingOrdersGV.Font.Name = "Tahoma";
        //        PendingOrdersGV.DataSource = clsBP.get_PendingOrders(lbl_BP_Id.Text);
        //        PendingOrdersGV.AllowPaging = false;
        //        PendingOrdersGV.Columns[0].Visible = false; //export won't work if there's a link in the gridview
        //        PendingOrdersGV.DataBind();

        //        //to PDF code --Sam
        //        string attachment = "attachment; filename=report.pdf";
        //        Response.ClearContent();
        //        Response.AddHeader("content-disposition", attachment);
        //        Response.ContentType = "application/pdf";
        //        StringWriter stw = new StringWriter();
        //        HtmlTextWriter htextw = new HtmlTextWriter(stw);
        //        htextw.AddStyleAttribute("font-size", "8pt");
        //        htextw.AddStyleAttribute("color", "Grey");

        //        PendingOrdersPanel.RenderControl(htextw); //Name of the Panel
        //        Document document = new Document();
        //        document = new Document(PageSize.A4, 5, 5, 15, 5);
        //        FontFactory.GetFont("Tahoma", 50, iTextSharp.text.BaseColor.BLUE);
        //        PdfWriter.GetInstance(document, Response.OutputStream);
        //        document.Open();

        //        StringReader str = new StringReader(stw.ToString());
        //        HTMLWorker htmlworker = new HTMLWorker(document);
        //        htmlworker.Parse(str);

        //        document.Close();
        //        Response.Write(document);
        //    }
        //}

        //public void HTMLtoPDFV0()
        //{
        //    try
        //    {
        //        //Create a byte array that will eventually hold our final PDF
        //        Byte[] bytes;

        //        //Boilerplate iTextSharp setup here
        //        //Create a stream that we can write to, in this case a MemoryStream
        //        using (var ms = new MemoryStream())
        //        {

        //            //Create an iTextSharp Document which is an abstraction of a PDF but **NOT** a PDF
        //            using (var doc = new Document())
        //            {

        //                //Create a writer that's bound to our PDF abstraction and our stream
        //                using (var writer = PdfWriter.GetInstance(doc, ms))
        //                {

        //                    //Open the document for writing
        //                    doc.Open();

        //                    //Our sample HTML and CSS
        //                    var example_html = @"<p>This <em>is </em><span class=""headline"" style=""text-decoration: underline;"">some</span> <strong>sample <em> text</em></strong><span style=""color: red;"">!!!</span></p>";
        //                    var example_css = @".headline{font-size:200%}";

        //                    /**************************************************
        //                     * Example #1                                     *
        //                     *                                                *
        //                     * Use the built-in HTMLWorker to parse the HTML. *
        //                     * Only inline CSS is supported.                  *
        //                     * ************************************************/

        //                    //Create a new HTMLWorker bound to our document
        //                    using (var htmlWorker = new HTMLWorker(doc))
        //                    {

        //                        //HTMLWorker doesn't read a string directly but instead needs a TextReader (which StringReader subclasses)
        //                        using (var sr = new StringReader(example_html))
        //                        {

        //                            //Parse the HTML
        //                            htmlWorker.Parse(sr);
        //                        }
        //                    }

        //                    /**************************************************
        //                     * Example #2                                     *
        //                     *                                                *
        //                     * Use the XMLWorker to parse the HTML.           *
        //                     * Only inline CSS and absolutely linked          *
        //                     * CSS is supported                               *
        //                     * ************************************************/

        //                    //XMLWorker also reads from a TextReader and not directly from a string
        //                    using (var srHtml = new StringReader(example_html))
        //                    {

        //                        //Parse the HTML
        //                        iTextSharp.tool.xml.XMLWorkerHelper.GetInstance().ParseXHtml(writer, doc, srHtml);
        //                    }

        //                    /**************************************************
        //                     * Example #3                                     *
        //                     *                                                *
        //                     * Use the XMLWorker to parse HTML and CSS        *
        //                     * ************************************************/

        //                    //In order to read CSS as a string we need to switch to a different constructor
        //                    //that takes Streams instead of TextReaders.
        //                    //Below we convert the strings into UTF8 byte array and wrap those in MemoryStreams
        //                    using (var msCss = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(example_css)))
        //                    {
        //                        using (var msHtml = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(example_html)))
        //                        {

        //                            //Parse the HTML
        //                            iTextSharp.tool.xml.XMLWorkerHelper.GetInstance().ParseXHtml(writer, doc, msHtml, msCss);
        //                        }
        //                    }


        //                    doc.Close();
        //                }
        //            }

        //            //After all of the PDF "stuff" above is done and closed but **before** we
        //            //close the MemoryStream, grab all of the active bytes from the stream
        //            bytes = ms.ToArray();
        //        }

        //        //Now we just need to do something with those bytes.
        //        //Here I'm writing them to disk but if you were in ASP.Net you might Response.BinaryWrite() them.
        //        //You could also write the bytes to a database in a varbinary() column (but please don't) or you
        //        //could pass them to another function for further PDF processing.
        //        var testFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "test.pdf");
        //        System.IO.File.WriteAllBytes(testFile, bytes)
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}

        //public void HTMLtoPDFV1()
        //{
        //    try
        //    {
        //        using (StringWriter sw = new StringWriter())
        //        {
        //            using (HtmlTextWriter hw = new HtmlTextWriter(sw))
        //            {
        //                using (StreamReader sr = new StreamReader(Server.MapPath("~/EmailTemplate.htm")))
        //                {
        //                    Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
        //                    HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
        //                    PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
        //                    pdfDoc.Open();
        //                    htmlparser.Parse(sr);
        //                    pdfDoc.Add(pdfTable);
        //                    pdfDoc.Close();
        //                    Response.ContentType = "application/pdf";
        //                    Response.AddHeader("content-disposition", "attachment;filename=HTMLExport.pdf");
        //                    Response.Cache.SetCacheability(HttpCacheability.NoCache);
        //                    Response.Write(pdfDoc);
        //                    Response.End();
        //                }                            
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}

        //public void HTMLtoPDFV2()
        //{
        //    try
        //    {
        //        HtmlToPdfConverter converter = new HtmlToPdfConverter();

        //        //Load html from stream
        //        using (Stream stream = File.OpenRead("sample.html"))
        //        {
        //            converter.Load(stream);
        //        }

        //        //Choose pdf compliance level, PDF or PDF/A
        //        converter.PdfStandard = PdfStandard.Pdf;

        //        //Convert html to pdf, and save it to file stream
        //        using (var stream = File.OpenWrite("convert.pdf"))
        //        {
        //            converter.Save(stream);
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}
    }
}
