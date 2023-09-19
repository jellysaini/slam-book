using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using BuinessLayer;

namespace SlamBook.LogIn.Pages
{
    public partial class confirmMail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {                
                Int32 q = Convert.ToInt32(Request.QueryString["qvar"].ToString());
                userBuinessContacts ob = new userBuinessContacts();
                ob.updateActiveUsersData(q);
                msg.Text = "Your Mail is Scessfully Update";
            }
        }

        protected void movetologin_Click(object sender, EventArgs e)
        {
            Response.Redirect("../../LogIn/Pages/LogIn.aspx");
        }       
    }
}
