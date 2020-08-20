using System;
using System.Web;
using System.Web.UI;

namespace DevASPNET
{

    public partial class FrmRequest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string strUserId = "";
            string strPassword = String.Empty;
            string strName = "";
            string strAge = String.Empty;

            // [1] QueryString Collection of Request object
            strUserId = Request["UserID"];
            // [2] Params Collection of Request object
            strPassword = Request.Params["Password"];
            // [3] Form Collection of Request object
            strName = Request.Form["Name"];
            // [4] Get Request object
            strAge = Request["Age"];

            string strMsg = String.Format("Entered ID is {0},<br />" + "Password is {1}.<br />"
                + "Name is {2}<br />" + "Age is {3}.<br />", strUserId, strPassword, strName, strAge);

            Response.Write(strMsg);
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            // Get Value using the Attribute of Control not Request object in ASP.NET.
            string name = Name.Text;  //
            int age = Convert.ToInt16(Age.Text);  //
        }
    }
}
