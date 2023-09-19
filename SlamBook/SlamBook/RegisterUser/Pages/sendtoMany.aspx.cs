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
using BuinessLayer;
namespace SlamBook.RegisterUser.Pages
{
    public partial class sendtoMany : baseclass
    {
        userBuinessContacts ubc = new userBuinessContacts();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                slamlbl.Text = " ";
                bindscrapdlist();                
            }
            else
            {
                slamlbl.Text = "Enter text First and Try again";
            }
        }
        protected void bindscrapdlist()
        {
            scrapdlist.DataSource = ubc.readFLSlamRecord(baseProperty.userUserId);
            scrapdlist.DataBind();
        }

        protected void scrapsend_Click(object sender, EventArgs e)
        {
            if (slamtb.Text != "")
            {
                for (int i = 0; i < scrapdlist.Items.Count; i++)
                {
                    if ((((CheckBox)(scrapdlist.Items[i].FindControl("slamcheck"))).Checked) == true)
                    {
                        Int32 id = Convert.ToInt32(((HiddenField)(scrapdlist.Items[i].FindControl("slamhdn"))).Value);
                        ubc.insertScrapRecord(id, baseProperty.userUserId, slamtb.Text);
                    }
                }
                Response.Redirect("userHome.aspx");
            }
            else
            {
                Response.Redirect("sendtoMany.aspx");
            }
        }       
    }
}
