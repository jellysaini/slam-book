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
    public partial class friendList : baseclass
    {
        userBuinessContacts ubc = new userBuinessContacts();
        Int32 PageNo;        
        Int32 totalPages;   
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                PageNo = 0;
                bindDataList();              
                if (ubc.totalRecord <= 10)
                {
                    totalPages = 0;
                    last.Enabled = false;
                    first.Enabled = false;
                    next.Enabled = false;
                    prev.Enabled = false;                    
                }
                else
                {
                    if ((ubc.totalRecord % 10) == 0)
                    {
                        totalPages = (ubc.totalRecord / 10) - 1;
                    }
                    else
                    {
                        totalPages = ubc.totalRecord / 10;
                    }                    
                }
                pno.Text = Convert.ToString(PageNo + 1);
            }
        }
        protected void bindDataList()
        {
            fdl.DataSource = ubc.readFriendListDetail(baseProperty.userUserId, PageNo);
            fdl.DataBind();
        }

        protected void fdl_ItemDataBound(object sender, DataListItemEventArgs e)
        {
            Int32 i = 0;            
            if (e.Item.ItemType == ListItemType.Item ||e.Item.ItemType == ListItemType.AlternatingItem)
            {
                i = Convert.ToInt32(((HiddenField)(e.Item.FindControl("hdn"))).Value);
                if (i == 1)
                {
                    ((Label)(e.Item.FindControl("fststus"))).Text = "Available";
                }
                else if (i == 2)
                {
                    ((Label)(e.Item.FindControl("fststus"))).Text = "Busy";
                }
                else
                {
                    ((Label)(e.Item.FindControl("fststus"))).Text = "Offline";
                }
            }
        }

        protected void next_Click(object sender, EventArgs e)
        {
            if (PageNo < totalPages)
            {
                PageNo = PageNo + 1;
                bindDataList();
            }
            else
            {
                PageNo = totalPages;
                bindDataList();
                next.Enabled = false;
                last.Enabled=false;
            }
            pno.Text = Convert.ToString(PageNo + 1);
        }

        protected void prev_Click(object sender, EventArgs e)
        {
            if (PageNo > 0)
            {
                PageNo = PageNo - 1;
                bindDataList();
            }
            else
            {
                PageNo = 0;
                bindDataList();
                prev.Enabled = false;
                first.Enabled = false;
            }
            pno.Text = Convert.ToString(PageNo + 1);
        }

        protected void last_Click(object sender, EventArgs e)
        {
            PageNo = totalPages;
            bindDataList();
            next.Enabled = false;
            last.Enabled = false;
            pno.Text = Convert.ToString(PageNo + 1);
        }

        protected void first_Click(object sender, EventArgs e)
        {
            PageNo = 0;
            bindDataList();
            prev.Enabled = false;
            first.Enabled = false;
            pno.Text = Convert.ToString(PageNo + 1);
        }
    }
}
