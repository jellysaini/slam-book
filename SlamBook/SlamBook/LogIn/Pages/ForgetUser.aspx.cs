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
using mailClassLib;

namespace SlamBook.LogIn.Pages
{
    public partial class ForgetUser : System.Web.UI.Page
    {
        bool res;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void resetbtn_Click(object sender, EventArgs e)
        {
            userBuinessClass fubc = new userBuinessClass();
            if (fubc.forgetFetchPassworddata(usrtxt.Text) == true)
            {
                invtieFriendClass sm = new invtieFriendClass();
                res = sm.sendMailtoForgetUser(usrtxt.Text, fubc.pData);
                if (res == true)
                {
                    result.Text = "mail Sent";
                }
                else
                {
                    result.Text = "Unable to send mail";
                }
            }
            else
            {
                result.Text = "You are not member of site";
            }
            
        }
    }
}
