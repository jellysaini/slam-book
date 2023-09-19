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

namespace SlamBook.LogIn.Pages
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            savebtn.Attributes.Add("OnClick", "dobret()");
            gendd.Items.Add("Male");
            gendd.Items.Add("Female");
            coundd.Items.Add("India");            
        }

        protected void savebtn_Click(object sender, EventArgs e)
        {
            bool isActive;
            Int32 fuid;
            string imgname;
            if (Request.QueryString["qvar"] != "" && Request.QueryString["qvar"] != null)
            {
                isActive = true;
                fuid = Convert.ToInt32(Request.QueryString["qvar"]);
            }
            else
            {
                isActive = false;
                fuid = 0;
            }
            string add = addtxt1.Text + " " + addtxt2.Text + " " + addtxt3.Text;
            if (gendd.SelectedValue == "Male")
            {
                imgname = "../UserImages/boy.jpg";
            }
            else
            {
                imgname = "../UserImages/girl.jpg";
            }
            if (chbox.Checked == true)
            {
                userBuinessClass ob = new userBuinessClass(FNtxt.Text, LNtxt.Text, imgname, isActive, EMtxt.Text, Passtxt.Text, hdnfield.Value, gendd.SelectedValue, add, ctytxt.Text, statxt.Text, coundd.SelectedValue, pintxt.Text);
                bool i = ob.insertnewuser();
                if (i == true)
                {
                    if (fuid != 0)
                    {
                        Response.Redirect("LogIn.aspx?qfid=" + fuid.ToString());
                    }
                    else
                    {
                        Response.Redirect("LogIn.aspx");
                    }
                }
                else
                {
                    Response.Redirect("SignUp.aspx");
                }
            }
        }
    }
}
