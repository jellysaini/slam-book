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
    public partial class showUsersSlamBK : baseclass
    {
        userBuinessSlamBook objBui;
        private string div1;
        private string div2;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                slamBKInfo1.getOwnerName = baseProperty.userFName + " SlamBook";
                slamBKInfo1.getSlamBKName = baseSlamProperty.slamBKName;
                slamBKInfo1.getTitle = baseSlamProperty.slamBKTitle;
                slamBKInfo1.getImageSrc = "~/slam images/" + baseSlamProperty.slamBKImageName;
                datalist_bind();                
            }
        }
        protected void datalist_bind()
        {
            objBui = new userBuinessSlamBook();            
            dl1.DataSource = objBui.readSlamBKUserQuestions(baseSlamProperty.slamBKId);
            dl1.DataBind(); 
        }

        protected void dl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            div1 = dl1.FindControl("d1").ID.ToString();
            div2 = dl1.FindControl("p1").ID.ToString();
        }
    }
}
