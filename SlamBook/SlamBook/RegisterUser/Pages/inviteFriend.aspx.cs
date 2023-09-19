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
using mailClassLib;
using baseclasslib;
using BuinessLayer;

namespace SlamBook.RegisterUser.Pages
{
    public partial class inviteFriend : baseclass
    {
        invtieFriendClass ifc = new invtieFriendClass();
        userBuinessContacts ubc = new userBuinessContacts();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void send_Click(object sender, EventArgs e)
        {
            if (ifc.sendInvitationtoFriend(to.Text,baseProperty.userUserId,baseProperty.FirstName +" "+baseProperty.LastName) == true)
            {
                ubc.inviteOutContactsData(baseProperty.userUserId, to.Text, baseProperty.userUserId.ToString());
                result.Text = "mail has sent";
            }
            else
            {
                result.Text = "unsucessfull";
            }
        }
    }
}
