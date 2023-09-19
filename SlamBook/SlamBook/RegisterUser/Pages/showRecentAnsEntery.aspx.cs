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
    public partial class showRecentAnsEntery : baseclass
    {
        userBuinessSlamBook ubsb = new userBuinessSlamBook();
        Int32 totalrec, pageNo, totalPages, uid;
        string name;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                if ((Request.QueryString["qvar"] != "" && Request.QueryString["qvar"] != null)&&(Request.QueryString["qvar1"] != "" && Request.QueryString["qvar1"] != null))
                {
                    uid = Convert.ToInt32(Request.QueryString["qvar"]);
                    name = Request.QueryString["qvar1"];
                }
                slamBKInfo1.getOwnerName = baseProperty.userFName + " SlamBook";
                slamBKInfo1.getSlamBKName = baseSlamProperty.slamBKName;
                slamBKInfo1.getTitle = baseSlamProperty.slamBKTitle;
                slamBKInfo1.getImageSrc = "~/slam images/" + baseSlamProperty.slamBKImageName;
                Globals.id = uid;
                Globals.name = name;
                friendname.Text = "Entries Made by Friend : - " + name;
                pageNo = 0;
                bind_dl1();
                totalrec = ubsb.totalRowsCount;
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
                pno.Text = Convert.ToString(pageNo + 1);
            }
            else
            {
                uid = Globals.id;
                name = Globals.name;
                totalPages = Globals.totalPages;
                pageNo=Globals.pageNo;
                friendname.Text = "Entries Made by Friend : - " + name;
            }
        }
        protected void bind_dl1()
        {
            dl1.DataSource = ubsb.readSlamBKUserQuestionAnsData(baseSlamProperty.slamBKId, uid, pageNo);
            dl1.DataBind();
        }

        protected void first_Click(object sender, EventArgs e)
        {
            pageNo = 0;
            bind_dl1();
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
                bind_dl1();
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
                bind_dl1();
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
                bind_dl1();
            }
            else
            {

                pageNo = totalPages;
                bind_dl1();
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
            bind_dl1();
            next.Enabled = false;
            last.Enabled = false;
            pno.Text = Convert.ToString(pageNo + 1);
            Globals.pageNo = pageNo;
        }
    }
}
