using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Atalasoft.Imaging.WebControls;

namespace AtalasoftWebDocumentViewer
{
    /// <summary>
    /// Summary description for WebDocumentViewrHandler
    /// </summary>
    public class WebDocumentViewrHandler : WebDocumentRequestHandler
    {
        protected override void OnPageTextRequested(PageTextRequestedEventArgs e)
        {
            base.OnPageTextRequested(e);
        }
        protected override void WriteResponseHeaders(HttpContext context)
        {
            System.Diagnostics.Debug.WriteLine("Hello world");
            System.Diagnostics.Debug.WriteLine(context.Request.RawUrl);
            base.WriteResponseHeaders(context);
        }
    }
}