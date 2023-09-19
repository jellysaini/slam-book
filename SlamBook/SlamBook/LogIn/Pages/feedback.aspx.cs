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
using mailClassLib;

namespace SlamBook.LogIn.Pages
{
    public partial class feedback : System.Web.UI.Page
    {
        invtieFriendClass ifc = new invtieFriendClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
 
            }
        }

        protected void emailbtn_Click(object sender, EventArgs e)
        {
            string selection = rank.SelectedItem.Value;
            string name = fnametxt.Text;
            string from = emailtxt.Text;
            string add = adresstxt.Text;
            string suggestion = suggestionstxt.Text;
            bool resultto = ifc.sendThanxForFeedback(from);
            if (resultto == true)
            {
                bool resultback = ifc.sendFeedBackMail(from, name, add, selection, suggestion);
                if (resultback == true)
                {
                    result.Text = "Your Mail has been sent";
                }
                else
                {
                    result.Text = "Sorry, There has some problem. Please Try again";
                }
            }
            else
            {
                result.Text = "Sorry, Enter valid from email Id";
            }
        }
    }
}
