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
using baseclasslib;
using mailClassLib;
using BuinessLayer;

namespace SlamBook.LogIn.Pages
{
    public partial class confirmlogin : baseclass
    {
        Int32 i, q;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                checkvalid();
            }
            checkvalid();
        }

        protected void checkvalid()
        {
            if (baseProperty.userActive == true)
            {
                i = 1;
                lnkbtn.Text = "Click Here to Surf into Your Account";
            }
            else
            {
                i = -1;
                lnkbtn.Text = "Click Here to send Confirm EMail Mail";
            }
        }

        protected void lnkbtn_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                Response.Redirect("../../RegisterUser/Pages/userHome.aspx");
            }
            else if (i == -1)
            {
                invtieFriendClass ifc = new invtieFriendClass();
                if (ifc.sendMailtoConfirm(baseProperty.userEMail, baseProperty.userUserId) == true)
                {
                    lnkbtn.Text = "Your Mail has been sent, Go and check your Mail Account";
                }
                else
                {
                    lnkbtn.Text = "There is sone Problem, so Mail Can't be Sent";
                }
            }
        }
    }
}
