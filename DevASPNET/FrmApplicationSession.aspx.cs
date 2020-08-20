using System;
using System.Web;
using System.Web.UI;

namespace DevASPNET
{

    public partial class FrmApplicationSession : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // [1] Application Variable increases 1
            if (Application["Count"] == null)
            {
                Application.Lock(); // User who came faster lock the variable editing
                Application["Count"] = 1; // Declare Variable of Application Program and Initialize
                Application.UnLock(); // Unlock : Other users can use
            }
            else
            {
                Application["Count"] = (int)Application["Count"] + 1;
            }
            // [2] Session Variable increases 1
            if (Session["Count"] == null)
            {
                Session["Count"] = 1; // Declare Session Variable and Initialize to 1 at the same time.
            }
            else
            {
                Session["Count"] = (int)Session["Count"] + 1;
            }
            // [3] Print
            // Everyone increases 1
            this.lblApplication.Text = Application["Count"].ToString();
            // Only Current Access User increases 1
            this.lblSession.Text = Session["Count"].ToString();
            // Own Access Number of Current Access User
            this.lblSessionID.Text = Session.SessionID;
            // Maintenance Time of Current Session
            this.lblTimeout.Text = Session.Timeout.ToString();
        }
    }
}
