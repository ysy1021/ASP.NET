using System;
using System.Web;
using System.Web.UI;

namespace DevASPNET
{

    public partial class FrmResponseWrite : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Hello.<br/>");
        }
        protected void btnClick_Click(object sender, EventArgs e)
        {
            Response.Write(
                "<span style='color:blue;'> Nice to meet you.</span><br/>");
        }
        protected void btnJavaScript_Click(object sender, EventArgs e)
        {
            string strJs = @"
            <script language='JavaScript'>
            window.alert('안녕');
            </script>
         ";
            Response.Write(strJs);
        }
    }
}
