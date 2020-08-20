using System;
using System.Web;
using System.Web.UI;

namespace DevASPNET
{

    public partial class FrmResponseBuffer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // [0] Read the current page every times newly.
            Response.Expires = -1;
            // Encoding for Japanese
            Response.Charset = "utf-8";
            // [1] Use Buffer
            Response.Buffer = true;
            // [2] Write to Display
            Response.Write("［１］現在文言は見える。<br/>");
            // [3] Print statement which is in Buffer
            Response.Flush();
            // [4] Write to Display
            Response.Write("［２］現在の文言は見えない。<br/>");
            // [5] Clear the Buffer
            Response.Clear();
            // [6] Print the statement
            Response.Write("［３］見える。<br/>");
            // [7] End the current page
            Response.End();
            // [8] Print statement
            Response.Write("［４］実行出来ない。<br/>");
        }
    }
}
