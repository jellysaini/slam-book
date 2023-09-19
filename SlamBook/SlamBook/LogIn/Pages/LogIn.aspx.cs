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
using baseclasslib;
using mailClassLib;

namespace SlamBook.LogIn.Pages
{
    public partial class WebForm1 : baseclass
    {
        Int32 fid;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["qfid"] != "" && Request.QueryString["qfid"] != null)
            {
                fid = Convert.ToInt32(Request.QueryString["qfid"]);
            }
            else
            {
                fid = 0;
            } 
        }

        protected void signinbtn_Click(object sender, EventArgs e)
        {
            userBuinessClass ob = new userBuinessClass(Emailtxt.Text, Passwdtxt.Text);
            if (ob.checkUserPass() == true)
            {
                baseclass baseob = new baseclass(Emailtxt.Text, Passwdtxt.Text);                
                baseob.getData();
                getSlamData(baseProperty.userUserId);
                if (fid != 0)
                {
                    userBuinessContacts obcon = new userBuinessContacts();
                    obcon.acceptInviteUserasFrienddata(baseProperty.userUserId, fid);
                }
                Response.Redirect("confirmlogin.aspx");
            }
            else
            {
                Response.Redirect("LogIn.aspx");
            }
        }

        protected void cancelbtn_Click(object sender, EventArgs e)
        {
            Emailtxt.Text = " ";
            Passwdtxt.Text = " ";
        }
    }
}
