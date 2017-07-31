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
        public WebDocumentViewrHandler():base(){

            this.AnnotationDataRequested += WebDocumentViewrHandler_AnnotationDataRequested;
            
        }

        private void WebDocumentViewrHandler_AnnotationDataRequested(object sender, AnnotationDataRequestedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("WebDocumentViewrHandler_AnnotationDataRequested");
            
        }
    }
}