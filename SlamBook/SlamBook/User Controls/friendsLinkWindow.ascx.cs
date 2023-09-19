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
using BuinessLayer;
using baseclasslib;
namespace SlamBook.User_Controls
{
    public partial class friendsLinkWindow : System.Web.UI.UserControl
    {
        Int32 PNo;
        Int32 totalPNo;
        Int32 count;
        baseclass ob1 = new baseclass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                PNo = 0;
                myimg.ImageUrl = ob1.baseProperty.userImage;
                count = ob1.baseProperty.userFriends;
                if (count < 10)
                {
                    Next.Visible = false;
                    Previous.Visible = false;
                    First.Visible = false;
                    Last.Visible = false;
                }
                else
                {
                    if ((count % 9) != 0)
                    {
                        totalPNo = count / 9;
                    }
                    else
                    {
                        totalPNo = (count / 9) - 1;
                    }
                }
                dlBind1();
            }            
        }
        protected void dlBind()
        {     
            userBuinessClass ob = new userBuinessClass();
            DataTable dt = ob.getUserFL(ob1.baseProperty.userUserId);
            fclbl.Text = Convert.ToString(ob1.baseProperty.userFriends);            
            flDL.DataSource = dt;
            flDL.DataBind();
        }
        protected void dlBind1()
        {
            
            userBuinessClass ob = new userBuinessClass();
            DataTable dt = ob.getUserFriend(ob1.baseProperty.userUserId, PNo);
            fclbl.Text = Convert.ToString(count);
            flDL.DataSource = dt;
            flDL.DataBind();
        }

        protected void flDL_ItemDataBound(object sender, DataListItemEventArgs e)
        {
            Int32 i;
            i = Convert.ToInt32(((HiddenField)(e.Item.FindControl("hdnfrstatus"))).Value );
            if (i == 1)
            {
                ((Image)(e.Item.FindControl("simg"))).ImageUrl = "~/App_Themes/RegisterUser/Images/green.JPG";
            }
            else if (i == 2)
            {
                ((Image)(e.Item.FindControl("simg"))).ImageUrl = "~/App_Themes/RegisterUser/Images/yellow.JPG";
            }
            else if (i == 3)
            {
                ((Image)(e.Item.FindControl("simg"))).ImageUrl = "~/App_Themes/RegisterUser/Images/red.JPG";
            }
        }

        protected void Previous_Click(object sender, EventArgs e)
        {
            if (PNo > 0)
            {
                PNo = PNo - 1;
                dlBind1();
            }
            else
            {
                PNo = 0;
                dlBind1();
            }
        }

        protected void Next_Click(object sender, EventArgs e)
        {
            if (PNo < totalPNo)
            {
                PNo = PNo + 1;
                dlBind1();
            }
            else
            {
                PNo = totalPNo;
                dlBind1();
            }
        }

        protected void Last_Click(object sender, EventArgs e)
        {
            PNo = totalPNo;
            dlBind1();
        }

        protected void First_Click(object sender, EventArgs e)
        {
            PNo = 0;
            dlBind1();
        }
        
    }
}