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


namespace SlamBook.User_Controls
{
    public partial class linkBarControl : System.Web.UI.UserControl
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void mp2r1lk1_Click(object sender, EventArgs e)
        {
            mp2r2lk1.Text = "Show Profile";
            mp2r2lk2.Text = "Edit Profile";
            mp2r2lk3.Text = "New Profile";
            mp2r2lk4.Text = " ";
            mp2r2lk5.Text = " ";
        }

        protected void mp2r1lk2_Click(object sender, EventArgs e)
        {
            mp2r2lk1.Text = "Friend List";
            mp2r2lk2.Text = "Add Friends";
            mp2r2lk3.Text = "Invite Friends";
            mp2r2lk4.Text = "Edit Friends";
            mp2r2lk5.Text = " ";
            mp2r2lk6.Text = " ";
        }

        protected void mp2r1lk3_Click(object sender, EventArgs e)
        {
            mp2r2lk1.Text = "Show";
            mp2r2lk2.Text = "Edit";
            mp2r2lk3.Text = "Send to Many";
            mp2r2lk4.Text = " ";
            mp2r2lk5.Text = " ";
            mp2r2lk6.Text = " ";
        }

        protected void mp2r1lk4_Click(object sender, EventArgs e)
        {
            mp2r2lk1.Text = "Show";
            mp2r2lk2.Text = "New";
            mp2r2lk3.Text = "Sent";
            mp2r2lk4.Text = "Draft";
            mp2r2lk5.Text = " ";
            mp2r2lk6.Text = " ";
        }

        protected void mp2r1lk5_Click(object sender, EventArgs e)
        {
            mp2r2lk1.Text = "Images";
            mp2r2lk2.Text = "Add Image";
            mp2r2lk3.Text = "Add Album";
            mp2r2lk4.Text = "Remove";
            mp2r2lk5.Text = "Add Folder";
            mp2r2lk6.Text = "Add Data";
        }

        protected void mp2r1lk6_Click(object sender, EventArgs e)
        {
            mp2r2lk1.Text = "New/Edit";
            mp2r2lk2.Text = "View";
            mp2r2lk3.Text = "Send Request";
            mp2r2lk4.Text = "";
            mp2r2lk5.Text = "";
            mp2r2lk6.Text = "";
        }

        protected void mp2r2lk1_Click(object sender, EventArgs e)
        {
            if ((mp2r1lk1.Text == "Profile") && (mp2r2lk1.Text == "Show Profile"))
            {
                Globals.checkPageValue = 1;
                Response.Redirect("../../RegisterUser/Pages/userProfile.aspx");
            }
            else if ((mp2r1lk6.Text == "SlamBook") && (mp2r2lk1.Text == "New/Edit"))
            {
                Response.Redirect("../../RegisterUser/Pages/usersSlamBook.aspx");
            }
            else if((mp2r1lk2.Text=="Friends")&&(mp2r2lk1.Text=="Friend List"))
            {
                Response.Redirect("../../RegisterUser/Pages/friendList.aspx");   
            }
            else if ((mp2r1lk3.Text == "Chit-Chat") && (mp2r2lk1.Text == "Show"))
            {
                Response.Redirect("../../RegisterUser/Pages/showAllScrap.aspx");
            }
            mp2r2lk1.Text = " ";
            mp2r2lk2.Text = " ";
            mp2r2lk3.Text = " ";
            mp2r2lk4.Text = " ";
            mp2r2lk5.Text = " ";
            mp2r2lk6.Text = " ";
        }

        protected void mp2r2lk2_Click(object sender, EventArgs e)
        {
            if ((mp2r1lk1.Text == "Profile") && (mp2r2lk2.Text == "Edit Profile"))
            {
                Globals.checkPageValue = 2;
                Response.Redirect("../../RegisterUser/Pages/userProfile.aspx");
            }
            else if ((mp2r1lk6.Text == "SlamBook") && (mp2r2lk2.Text == "View"))
            {
                Response.Redirect("../../RegisterUser/Pages/showUsersSlamBK.aspx");
            }
            else if ((mp2r1lk2.Text == "Friends") && (mp2r2lk2.Text == "Add Friends"))
            {
                Response.Redirect("../../RegisterUser/Pages/addfriend.aspx");
            }
            else if ((mp2r1lk3.Text == "Chit-Chat") && (mp2r2lk2.Text == "Edit"))
            {
                Response.Redirect("../../RegisterUser/Pages/editScrap.aspx");
            }
            mp2r2lk1.Text = " ";
            mp2r2lk2.Text = " ";
            mp2r2lk3.Text = " ";
            mp2r2lk4.Text = " ";
            mp2r2lk5.Text = " ";
            mp2r2lk6.Text = " ";
        }

        protected void mp2r2lk3_Click(object sender, EventArgs e)
        {
            if ((mp2r1lk1.Text == "Profile") && (mp2r2lk3.Text == "New Profile"))
            {
                Globals.checkPageValue = 3;
                Response.Redirect("../../RegisterUser/Pages/userProfile.aspx");
            }
            else if ((mp2r1lk6.Text == "SlamBook") && (mp2r2lk3.Text == "Send Request"))
            {
                Response.Redirect("../../RegisterUser/Pages/addSlamBKRequest.aspx");
            }
            else if ((mp2r1lk3.Text == "Chit-Chat") && (mp2r2lk3.Text == "Send to Many"))
            {
                Response.Redirect("../../RegisterUser/Pages/sendtoMany.aspx");
            }
            else if ((mp2r1lk2.Text == "Friends") && (mp2r2lk3.Text == "Invite Friends"))
            {
                Response.Redirect("../../RegisterUser/Pages/inviteFriend.aspx");
            }
            mp2r2lk1.Text = " ";
            mp2r2lk2.Text = " ";
            mp2r2lk3.Text = " ";
            mp2r2lk4.Text = " ";
            mp2r2lk5.Text = " ";
            mp2r2lk6.Text = " ";
        }

        protected void mp2r2lk4_Click(object sender, EventArgs e)
        {
            if ((mp2r1lk2.Text == "Friends") && (mp2r2lk4.Text == "Edit Friends"))
            {
                Response.Redirect("../../RegisterUser/Pages/editFriends.aspx");
            }
            mp2r2lk1.Text = " ";
            mp2r2lk2.Text = " ";
            mp2r2lk3.Text = " ";
            mp2r2lk4.Text = " ";
            mp2r2lk5.Text = " ";
            mp2r2lk6.Text = " ";
        }

        protected void mp2r2lk5_Click(object sender, EventArgs e)
        {
            mp2r2lk1.Text = " ";
            mp2r2lk2.Text = " ";
            mp2r2lk3.Text = " ";
            mp2r2lk4.Text = " ";
            mp2r2lk5.Text = " ";
            mp2r2lk6.Text = " ";
        }

        protected void mp2r2lk6_Click(object sender, EventArgs e)
        {
            mp2r2lk1.Text = " ";
            mp2r2lk2.Text = " ";
            mp2r2lk3.Text = " ";
            mp2r2lk4.Text = " ";
            mp2r2lk5.Text = " ";
            mp2r2lk6.Text = " ";
        }
    }
}