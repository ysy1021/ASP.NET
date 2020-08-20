using System;
using System.Web;
using System.Web.UI;

namespace DevASPNET
{

    public partial class FrmRequestUserHostAddress : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Get IP Address of current User in WebForm
            this.Label1.Text = Request.UserHostAddress;
            this.Label2.Text = Request.ServerVariables["REMOTE_HOST"];
            this.Label3.Text = Request.ServerVariables["REMOTE_ADDR"];
        }
    }
}
