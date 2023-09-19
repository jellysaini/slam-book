using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using baseclasslib;

namespace SlamBook.User_Controls
{
    public partial class LogOutControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                updateTime();
            }
            else
            {
                updateTime();
            }
        }
        protected void updateTime()
        {
            baseclass ob = new baseclass();
            usrlbl.Text = ob.baseProperty.userFName + " " + ob.baseProperty.userLName;
            watch.Text = string.Format("{0:r}", DateTime.Now);
        }
        protected void logoutlnk_Click(object sender, EventArgs e)
        {
            Response.Redirect("../../LogIn/Pages/LogIn.aspx");
        }
    }
}