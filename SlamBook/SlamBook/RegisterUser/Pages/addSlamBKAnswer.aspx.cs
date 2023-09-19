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
using baseclasslib;

namespace SlamBook.RegisterUser.Pages
{
    public partial class addanswer : baseclass
    {
        userBuinessSlamBook ubSB = new userBuinessSlamBook();
        Int32 sbid, totalrec, pageNo, totalPages;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                if (Request.QueryString["qvar"] != "" && Request.QueryString["qvar"] != null)
                {
                    sbid = Convert.ToInt32(Request.QueryString["qvar"]);
                }
                ubSB.updateSlamBookVisitorData(sbid, baseProperty.userUserId);
                ubSB.readslamBKDetailData(sbid);
                slamBKInfo1.getOwnerName = ubSB.name + " SlamBook";
                slamBKInfo1.getSlamBKName = ubSB.slambkName;
                slamBKInfo1.getTitle = ubSB.slambkTitle;
                slamBKInfo1.getImageSrc = "~/slam images/" + ubSB.slambkImage;

                pageNo = 0;
                binduserAnsDL();
                totalrec = ubSB.totalRowsCount;
                if (totalrec <= 5)
                {
                    totalPages = 0;
                    last.Enabled = false;
                    first.Enabled = false;
                    next.Enabled = false;
                    prev.Enabled = false;
                }
                else
                {
                    if ((totalrec % 5) == 0)
                    {
                        totalPages = (totalrec / 5) - 1;
                    }
                    else
                    {
                        totalPages = totalrec / 5;
                    }
                }
                Globals.totalPages = totalPages;
                Globals.pageNo = pageNo;
                Globals.id = sbid;
                pno.Text = Convert.ToString(pageNo + 1);
            }
            else
            {
                sbid = Globals.id;
                totalPages = Globals.totalPages;
                pageNo = Globals.pageNo;
            }
        }
        protected void binduserAnsDL()
        {
            //userAnsDL.DataSource = ubSB.readusersAnsQuestionData(sbid, pageNo);
            userAnsDL.DataSource = ubSB.readSlamBKUserQuestionAnsData(sbid, baseProperty.userUserId, pageNo);
            userAnsDL.DataBind();
        }

        protected void first_Click(object sender, EventArgs e)
        {
            pageNo = 0;
            binduserAnsDL();
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
                binduserAnsDL();
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
                binduserAnsDL();
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
                binduserAnsDL();
            }
            else
            {

                pageNo = totalPages;
                binduserAnsDL();
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
            binduserAnsDL();
            next.Enabled = false;
            last.Enabled = false;
            pno.Text = Convert.ToString(pageNo + 1);
            Globals.pageNo = pageNo;
        }

        protected void ansSave_Click(object sender, EventArgs e)
        {
            Int32 qId;
            string ans;
            for (Int32 i = 0; i < userAnsDL.Items.Count; i++)
            {
                qId = Convert.ToInt32(((HiddenField)(userAnsDL.Items[i].FindControl("qid"))).Value);
                ans = Convert.ToString(((TextBox)(userAnsDL.Items[i].FindControl("userATB"))).Text);
                ubSB.insertUserAnswerData(sbid, qId, baseProperty.userUserId, ans);
            }
        }
    }
}
