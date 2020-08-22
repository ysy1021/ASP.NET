using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls; // Add Namespace
using System.Web.UI.WebControls;

namespace DevASPNET
{

    public partial class FrmPageLoad : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Three Ways of Changing the Title of Page dynamically
            Title = "Title is changed.";
            Page.Title = "Title is printed";
            Page.Header.Title = "Page Class";

            // Adjust External StyleSheet
            HtmlLink objHtmlLink = new HtmlLink();
            objHtmlLink.Href = "DevASPNET.css";
            objHtmlLink.Attributes.Add("rel", "stylesheet");
            objHtmlLink.Attributes.Add("type", "text/css");

            // Adjust Head Tag, Add External Style and Metatag
            HtmlHead objHtmlHead = Page.Header;
            objHtmlHead.Controls.Add(objHtmlLink);
            // The Way of Applying stylesheet in page dynamically
            Style objButtonStyle = new Style();
            objButtonStyle.ForeColor = System.Drawing.Color.Navy;   // Color:Navy;
            objButtonStyle.Font.Size = 9;   // font-size:9pt
            objButtonStyle.Font.Name = "Verdana";
            Page.Header.StyleSheet.RegisterStyle(objButtonStyle, null);
            this.btnNewLoad.CssClass = objButtonStyle.RegisteredCssClass;
            this.btnPostBack.CssClass = objButtonStyle.RegisteredCssClass;

            Style objDivStyle = new Style();
            objDivStyle.ForeColor = System.Drawing.Color.Blue;
            objDivStyle.Font.Size = 9;
            objDivStyle.Font.Name = "Verdana";
            objDivStyle.Font.Italic = true;
            Page.Header.StyleSheet.CreateStyleRule(objDivStyle, null, "body, div");

            // If you click the button, Code Number [1],[2] are not executed.
            if (!Page.IsPostBack)
            {
                Response.Write("Only Execute when Form[1] loaded at first<br />");
            }
            if (Page.IsPostBack == false)
            {
                Response.Write("Only Execute when Form[2] loaded at first<br />");
            }
            Response.Write("Execute whenever Form[3] loaded<br />");
        }

        protected void btnPostBack_Click(object sender, EventArgs e)
        {
            string strJs = @"
            <script>
            window.alert('Postbacked');
            <script>
            ";
            ClientScript.RegisterClientScriptBlock(this.GetType(), "MyScript", strJs);
        }

        protected void btnNewLoad_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmPageLoad.aspx");
        }
    }
}
