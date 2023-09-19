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
    public partial class addfriend : baseclass
    {       
        userBuinessContacts ubc = new userBuinessContacts();
        DataTable dt;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {                
                // bindGrid();
            }
        }
        protected void bindGrid()
        {
            grdview.DataSource = dt;
            grdview.DataBind();
        }

        protected void byname_Click(object sender, EventArgs e)
        {
            Globals.searchindex = 1;
            searchlbl.Text = "Enter Name for Searching";
            searchbtn.Enabled = true;
            cancelbtn.Enabled = true;
        }

        protected void bystate_Click(object sender, EventArgs e)
        {
            Globals.searchindex = 2;
            searchlbl.Text = "Enter State Name for Searching";
            searchbtn.Enabled = true;
            cancelbtn.Enabled = true;
        }

        protected void bycountry_Click(object sender, EventArgs e)
        {
            Globals.searchindex = 3;
            searchlbl.Text = "Enter Country Name for Searching";
            searchbtn.Enabled = true;
            cancelbtn.Enabled = true;
        }

        protected void searchbtn_Click(object sender, EventArgs e)
        {
            if ( Globals.searchindex == 1)
            {
                dt = ubc.searchbyname(baseProperty.userUserId, searchtb.Text);
                bindGrid();
            }
            else if (Globals.searchindex == 2)
            {
                dt = ubc.searchbystate(baseProperty.userUserId, searchtb.Text);
                bindGrid();
            }
            else if (Globals.searchindex == 3)
            {
                dt = ubc.searchbycountry(baseProperty.userUserId, searchtb.Text);
                bindGrid();
            }
            if (ubc.totalSearchRecord == 0)
            {
                searchmsg.Text = "No Record has been found";
            }
            else
            {
                msgarea.Visible = true;
            }
            searchbtn.Enabled = false;
            cancelbtn.Enabled = false;
        }

        protected void msgabtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < grdview.Rows.Count; i++)
            {
                if (((CheckBox)(grdview.Rows[i].FindControl("grdchk"))).Checked == true)
                {
                    int j = Convert.ToInt32(((HiddenField)(grdview.Rows[i].FindControl("searchid"))).Value);
                    ubc.insertFriendRequest(baseProperty.userUserId, j, msgtxt.Text);
                }                
            }
            Response.Redirect("addfriend.aspx"); 
        }
    }
}
