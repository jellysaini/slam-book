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
    public partial class addSlamBKRequest : baseclass
    {
        userBuinessContacts ubc = new userBuinessContacts();
        Int32 pageNo, totalRecords, totalPages;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                pageNo = 0;
                bindDataList();
                totalRecords=ubc.totalSearchRecord;
                if (totalRecords <= 10)
                {
                    sbfirst.Enabled = false;
                    sblast.Enabled = false;
                    sbprev.Enabled = false;
                    sbnext.Enabled = false;
                }
                else
                {
                    if ((totalRecords % 10) == 0)
                    {
                        totalPages = (totalRecords / 10) - 1;
                    }
                    else
                    {
                        totalPages = totalRecords / 10;
                    }
                    sbfirst.Enabled = false;
                    sblast.Enabled = true;
                    sbprev.Enabled = false;
                    sbnext.Enabled = true;
                }
                sbpno.Text = Convert.ToString (pageNo + 1);
            }
            if (totalRecords == 0)
            {
                sbmsg.Visible = true;
                sbreqsubmit.Visible = false;
            }
            else
            {
                sbmsg.Visible = false;
                sbreqsubmit.Visible = true;
            }
        }
        protected void bindDataList()
        {
            sbdlist.DataSource = ubc.readSlamBKContactRequest(baseProperty.userUserId, baseSlamProperty.slamBKId, pageNo);
            sbdlist.DataBind();
        }

        protected void sbfirst_Click(object sender, EventArgs e)
        {
            pageNo = 0;
            bindDataList();
            sblast.Enabled = true;
            sbnext.Enabled = true;
            sbfirst.Enabled = false;
            sbprev.Enabled = false;
            sbpno.Text = Convert.ToString(pageNo + 1);
        }

        protected void sblast_Click(object sender, EventArgs e)
        {
            pageNo = totalPages;
            bindDataList();
            sblast.Enabled = false;
            sbnext.Enabled = false;
            sbfirst.Enabled = true;
            sbprev.Enabled = true;
            sbpno.Text = Convert.ToString(pageNo + 1);
        }

        protected void sbnext_Click(object sender, EventArgs e)
        {
            if (pageNo < totalPages)
            {
                pageNo = pageNo + 1;
                bindDataList();
                sblast.Enabled = true;
                sbnext.Enabled = true;
                sbfirst.Enabled = true;
                sbprev.Enabled = true;
            }
            else
            {
                pageNo = totalPages;
                bindDataList();
                sblast.Enabled = false;
                sbnext.Enabled = false;
                sbfirst.Enabled = true;
                sbprev.Enabled = true;
            }
            sbpno.Text = Convert.ToString(pageNo + 1);
        }

        protected void sbprev_Click(object sender, EventArgs e)
        {
            if (pageNo > 0)
            {
                pageNo = pageNo - 1;
                bindDataList();
                sblast.Enabled = true;
                sbnext.Enabled = true;
                sbfirst.Enabled = true;
                sbprev.Enabled = true;
            }
            else
            {
                pageNo = 0;
                bindDataList();
                sbfirst.Enabled = false;
                sbprev.Enabled = false;
                sblast.Enabled = true;
                sbnext.Enabled = true;                
            }
            sbpno.Text = Convert.ToString(pageNo + 1);
        }

        protected void sbreqsubmit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < sbdlist.Items.Count; i++)
            {
                if (((CheckBox)(sbdlist.Items[i].FindControl("sbchkbox"))).Checked == true)
                {
                    Int32 id = Convert.ToInt32(((HiddenField)(sbdlist.Items[i].FindControl("sbhdn"))).Value);
                    ubc.insertSBRequest(id, baseSlamProperty.slamBKId, baseProperty.userUserId);
                    bindDataList();
                }
            }
        }
    }
}
