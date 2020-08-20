using System;
using System.Web;
using System.Web.UI;

namespace DevASPNET
{

    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Redirect("FrmResponseRedirect.aspx");
            //Response.Redirect("FrmRequest.aspx");
            //Response.Redirect("FrmRequestUserHostAddress.aspx");
            //Response.Redirect("FrmServerMapPath.aspx");
            Response.Redirect("FrmApplicationSession.aspx");
        }

        protected void btnClick_Click(object sender, EventArgs e)
        {
            //Response.Write("Nice to meet you<br/>");
            //Response.Redirect("FrmResponseWrite.aspx");
            //Response.Redirect("FrmResponseBuffer.aspx");
            //Response.Redirect("FrmResponseRedirect.aspx");
        }
    }
}
