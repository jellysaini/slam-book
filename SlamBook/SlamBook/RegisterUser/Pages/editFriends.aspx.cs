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
    public partial class editFriends : baseclass
    {
        userBuinessContacts ubc = new userBuinessContacts();
        Int32 pageNo, totalPages; 
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                pageNo = 0;
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
                Globals.pageNo = pageNo;
                Globals.totalPages = totalPages;
                pno.Text = Convert.ToString(pageNo + 1);
            }
            else
            {
                pageNo = Globals.pageNo;
                totalPages = Globals.totalPages;
            }
        }
        protected void bindDataList()
        {
            fdl.DataSource = ubc.readFriendListDetail(baseProperty.userUserId, pageNo);
            fdl.DataBind();
        }

        protected void fdl_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "delete")
            {
                Int32 fuid = Convert.ToInt32(e.CommandArgument);
                ubc.editFriendListdata(baseProperty.userUserId, fuid);
                bindDataList();
            }
        }

        protected void first_Click(object sender, EventArgs e)
        {
            pageNo = 0;
            bindDataList();
            next.Enabled = true;
            last.Enabled = true;
            prev.Enabled = false;
            first.Enabled = false;
            pno.Text = Convert.ToString(pageNo + 1);
            Globals.pageNo = pageNo;
        }

        protected void prev_Click(object sender, EventArgs e)
        {
            if (pageNo > 0)
            {
                pageNo = pageNo - 1;
                bindDataList();
                next.Enabled = true;
                prev.Enabled = true;
                last.Enabled = true;
                first.Enabled = true;
            }
            else
            {
                next.Enabled = true;
                last.Enabled = true;
                pageNo = 0;
                bindDataList();
                prev.Enabled = false;
                first.Enabled = false;
            }
            pno.Text = Convert.ToString(pageNo + 1);
            Globals.pageNo = pageNo;
        }

        protected void next_Click(object sender, EventArgs e)
        {
            if (pageNo < totalPages)
            {
                next.Enabled = true;
                prev.Enabled = true;
                last.Enabled = true;
                first.Enabled = true;
                pageNo = pageNo + 1;
                bindDataList();
            }
            else
            {

                pageNo = totalPages;
                bindDataList();
                next.Enabled = false;
                last.Enabled = false;
            }
            pno.Text = Convert.ToString(pageNo + 1);
            Globals.pageNo = pageNo;
        }

        protected void last_Click(object sender, EventArgs e)
        {
            first.Enabled = true;
            prev.Enabled = true;
            pageNo = totalPages;
            bindDataList();
            next.Enabled = false;
            last.Enabled = false;
            pno.Text = Convert.ToString(pageNo + 1);
            Globals.pageNo = pageNo;
        }
    }
}
