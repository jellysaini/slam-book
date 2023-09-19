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

namespace SlamBook.RegisterUser.Pages
{
    public partial class RegisterUser : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                
            }
        }

        protected void home_Click(object sender, EventArgs e)
        {
            Response.Redirect("userHome.aspx");
        }
    }
}
