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
    public partial class showAllScrap : baseclass
    {
        userBuinessContacts ubc = new userBuinessContacts();
        Int32 pageNo, totalRecord, totalPages;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                pageNo = 0;
                scrapDListBind();
                totalRecord = ubc.totalSearchRecord;
                if (totalRecord <= 10)
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
                        totalPages = (totalRecord / 10) - 1;
                    }
                    else
                    {
                        totalPages = totalRecord / 10;
                    }
                }
                Globals.totalPages = totalPages;
                Globals.pageNo = pageNo;
                pno.Text = Convert.ToString(pageNo + 1);
            }
            else
            {
                totalPages = Globals.totalPages;
                pageNo = Globals.pageNo;
            }
        }
        protected void scrapDListBind()
        {
            scrapDList.DataSource = ubc.readScrapDataValues(baseProperty.userUserId, pageNo);
            scrapDList.DataBind();
        }

        protected void scrapDList_ItemDataBound(object sender, DataListItemEventArgs e)
        {
            if ((e.Item.ItemType == ListItemType.Item) || (e.Item.ItemType == ListItemType.AlternatingItem))
            {
                Int32 i = Convert.ToInt32(((HiddenField)(e.Item.FindControl("scrapHdn"))).Value);
                if (i == 0)
                {
                    ((Label)(e.Item.FindControl("slamDate"))).Text = "Today";
                }
                else
                {
                    ((Label)(e.Item.FindControl("slamDate"))).Text = i.ToString() + " " + "Day Ago";
                }
            }
        }

        protected void next_Click(object sender, EventArgs e)
        {
            if (pageNo < totalPages)
            {
                pageNo = pageNo + 1;
                scrapDListBind();
                last.Enabled = true;
                first.Enabled = true;
                next.Enabled = true;
                prev.Enabled = true;
            }
            else
            {
                first.Enabled = true;
                prev.Enabled = true;
                pageNo = totalPages;
                scrapDListBind();
                next.Enabled = false;
                last.Enabled = false;
            }
            pno.Text = Convert.ToString(pageNo + 1);
            Globals.pageNo = pageNo;
        }

        protected void prev_Click(object sender, EventArgs e)
        {
            if (pageNo > 0)
            {
                pageNo = pageNo - 1;
                scrapDListBind();
                last.Enabled = true;
                first.Enabled = true;
                next.Enabled = true;
                prev.Enabled = true;
            }
            else
            {
                last.Enabled = true;
                next.Enabled = true;
                pageNo = 0;
                scrapDListBind();
                prev.Enabled = false;
                first.Enabled = false;
            }
            pno.Text = Convert.ToString(pageNo + 1);
            Globals.pageNo = pageNo;
        }

        protected void last_Click(object sender, EventArgs e)
        {
            first.Enabled = true;
            prev.Enabled = true;
            pageNo = totalPages;
            scrapDListBind();
            next.Enabled = false;
            last.Enabled = false;
            pno.Text = Convert.ToString(pageNo + 1);
            Globals.pageNo = pageNo;
        }

        protected void first_Click(object sender, EventArgs e)
        {
            pageNo = 0;
            last.Enabled = true;
            next.Enabled = true;
            scrapDListBind();
            prev.Enabled = false;
            first.Enabled = false;
            pno.Text = Convert.ToString(pageNo + 1);
            Globals.pageNo = pageNo;
        }

        protected void scrapDList_EditCommand(object source, DataListCommandEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                scrapDList.EditItemIndex = e.Item.ItemIndex;
                Int32 i = Convert.ToInt32(((HiddenField)(e.Item.FindControl("scrapHdn"))).Value);
                scrapDListBind();               
            }
        }       

        protected void scrapDList_CancelCommand(object source, DataListCommandEventArgs e)
        {
            scrapDList.EditItemIndex = -1;
            scrapDListBind();
        }

        protected void scrapDList_UpdateCommand(object source, DataListCommandEventArgs e)
        {
            Int32 id;
            string msg;
            id = Convert.ToInt32(scrapDList.DataKeys[e.Item.ItemIndex]);
            msg = ((TextBox)(e.Item.FindControl("scrapRepTB"))).Text;
            ubc.insertScrapRecord(id, baseProperty.userUserId, msg);
            scrapDList.EditItemIndex = -1;
            scrapDListBind();
        }
    }
}
