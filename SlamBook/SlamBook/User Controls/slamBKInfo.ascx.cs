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

namespace SlamBook.User_Controls
{
    public partial class slamBKInfo : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
 
            }
        }
        public string getImageSrc
        {
            get { return SlamImage.ImageUrl; }
            set { SlamImage.ImageUrl = value; }
        }
        public string getSlamBKName
        {
            get { return sbname.Text; }
            set { sbname.Text = value; }
        }
        public string getTitle
        {
            get { return sbtitle.Text; }
            set { sbtitle.Text = value; }
        }
        public string getOwnerName
        {
            get { return sbUserName.Text; }
            set { sbUserName.Text = value; }
        }
    }
}