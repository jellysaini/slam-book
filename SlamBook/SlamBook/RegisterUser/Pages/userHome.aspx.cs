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
    public partial class userHome : baseclass
    {
        userBuinessContacts ubc = new userBuinessContacts();
        userBuinessSlamBook ubsb = new userBuinessSlamBook();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                bindScrapRepeater();
                bindfReqRep();
                bindSBReqRep();
                checkSlamBKGenerated();
                bindAcceptRep();
                visitorRepBind();
            }
        }
        protected void visitorRepBind()
        {
            vistorRep.DataSource = ubsb.listRecentUpdatesByFriendData(baseSlamProperty.slamBKId);
            vistorRep.DataBind();
        }
        protected void bindScrapRepeater()
        {
            scrapRep.DataSource = ubc.readScrapDataValues(baseProperty.userUserId, 0);
            scrapRep.DataBind();
        }
        protected void bindfReqRep()
        {
           fReqRep.DataSource = ubc.readhomeFriendReqdata(baseProperty.userUserId);
           fReqRep.DataBind();
        }
        protected void bindSBReqRep()
        {
            sbReqRep.DataSource = ubsb.viewSBReqData(baseProperty.userUserId);
            sbReqRep.DataBind();
        }
        protected void checkSlamBKGenerated()
        {
            bool test = ubsb.checkSlamBKGenData(baseProperty.userUserId);
            if (test == true)
            {
                slamBK.Visible = false;
            }
            else
            {
                slamBK.Visible = true;
            }
        }
        protected void bindAcceptRep()
        {
            sbAccRep.DataSource = ubsb.addSlamBKEnteryData(baseProperty.userUserId);
            sbAccRep.DataBind();
        }
        protected void fReqRep_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                ubc.acceptFriendReqData(baseProperty.userUserId, Convert.ToInt32(e.CommandArgument));
                bindfReqRep();
            }
            else if (e.CommandName == "Cancel")
            {
                ubc.denyFriendReqdata(baseProperty.userUserId, Convert.ToInt32(e.CommandArgument));
                bindfReqRep();
            }
        }     

        protected void sbReqRep_ItemCommand(object source, RepeaterCommandEventArgs e)
        {            
            if (e.CommandName == "accept")
            {
                ubsb.acceptSlamBKReqDate(baseProperty.userUserId, Convert.ToInt32(e.CommandArgument));
                bindSBReqRep();
            }
            else if (e.CommandName == "deny")
            {
                ubsb.denySlamBKReqData(baseProperty.userUserId, Convert.ToInt32(e.CommandArgument));
                bindSBReqRep();
            }
        }

        protected void sbAccRep_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "new")
            {                
                Int32 sbid = Convert.ToInt32(e.CommandArgument);
                Response.Redirect("addSlamBKAnswer.aspx?qvar=" + sbid.ToString());
            }
        }

        protected void vistorRep_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "redirect")
            {
                Int32 uid = Convert.ToInt32(e.CommandArgument);
                string name = (((HiddenField)(e.Item.FindControl("fname"))).Value).ToString();
                name = name +" "+ (((HiddenField)(e.Item.FindControl("lname"))).Value).ToString();
                Response.Redirect("showRecentAnsEntery.aspx?qvar=" + uid.ToString() + "&qvar1=" + name);
            }
        }        
    }
}
