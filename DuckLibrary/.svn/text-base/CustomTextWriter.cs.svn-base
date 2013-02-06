using System.IO;
using System.Text;
using System.Web.UI.WebControls;

namespace DuckLibrary
{
    public class CustomTextWriter : TextWriter
    {
        private readonly Literal literalToWriteTo;

        public CustomTextWriter(Literal literalToWriteTo)
        {
            this.literalToWriteTo = literalToWriteTo;
        }

        public override Encoding Encoding
        {
            get { return Encoding.UTF8; }
        }

        public override void WriteLine(string value)
        {
            literalToWriteTo.Text += value + "<br />";
        }
    }
}