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
    public partial class newSlamBook : baseclass
    {
        userBuinessSlamBook userBuiSlamBK; 
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                string imgname;
                for (int i = 1; i <= 5; i++)
                {
                    imgname = "Slam" + i + ".jpg";
                    ddselectimg.Items.Add(imgname);
                }
                questionTable1.slamBKId = baseSlamProperty.slamBKId;
                questionTable1.userId = baseProperty.userUserId;
                getdata();
            }
            else
            {
                questionTable1.slamBKId = baseSlamProperty.slamBKId;
                questionTable1.userId = baseProperty.userUserId;
            }
           
        }
        protected void getdata() 
        {
            slamBKInfo1.getOwnerName = baseProperty.userFName+" SlamBook";
            slamBKInfo1.getSlamBKName = baseSlamProperty.slamBKName;
            slamBKInfo1.getTitle = baseSlamProperty.slamBKTitle;
            slamBKInfo1.getImageSrc = "~/slam images/" + baseSlamProperty.slamBKImageName;
            sbnametb.Text = baseSlamProperty.slamBKName;
            sbtitletb.Text = baseSlamProperty. slamBKTitle;
            for (int i = 0; i < 5; i++)
            {
                if (ddselectimg.Items[i].Text == baseSlamProperty.slamBKImageName)
                {
                    ddselectimg.SelectedValue = baseSlamProperty.slamBKImageName;
                    break;
                }
            }
            if (baseSlamProperty.slamBKId > 0)
            {
                edit1.Visible = true;
                edit1.Enabled = true;
                sbnametb.Enabled = false;
                sbtitletb.Enabled = false;
                ddselectimg.Enabled = false;
                save.Visible = false;
                cancel.Visible = false;
            }
        }

        protected void clikhere_Click(object sender, EventArgs e)
        {
            clikhere.Enabled = false;
            questionTable1.Visible = true;
        }

        protected void save_Click(object sender, EventArgs e)
        {
            userBuiSlamBK = new userBuinessSlamBook(baseProperty.userUserId, sbnametb.Text, false, sbtitletb.Text,ddselectimg.SelectedValue);
            userBuiSlamBK.insertSlamBK();
            getSlamData(baseProperty.userUserId);
            getdata();
        }

        protected void edit1_Click(object sender, EventArgs e)
        {
            edit1.Enabled = false;
            sbnametb.Enabled = true;
            sbtitletb.Enabled = true;
            ddselectimg.Enabled = true;
            save.Visible = true;
            cancel.Visible = true;
        }

        protected void ddselectimg_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddselectimg.SelectedValue = ddselectimg.SelectedValue;
        }

       
    }
}
