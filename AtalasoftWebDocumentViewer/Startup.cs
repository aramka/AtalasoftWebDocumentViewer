using Atalasoft.Imaging.Codec;
using Atalasoft.Imaging.Codec.Pdf;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AtalasoftWebDocumentViewer.Startup))]
namespace AtalasoftWebDocumentViewer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            RegisteredDecoders.Decoders.Add(new PdfDecoder());
        }
    }
}
