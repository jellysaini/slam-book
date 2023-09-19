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
using BuinessLayer;

namespace SlamBook.User_Controls
{
    public partial class questionTable : System.Web.UI.UserControl
    {
        userBuinessSlamBook userBSB = new userBuinessSlamBook();        
        private Int32 _sbId;
        private Int32 _userId;
        public Int32 userId
        {
            get { return _userId; }
            set { _userId = value; }
        }
        public Int32 slamBKId
        {
            get { return _sbId; }
            set { _sbId = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                //userBSB = new userBuinessSlamBook();
                //bind_grid();
                bind_savegrid();
            }
        }
        protected void bind_grid()
        {
            questionGrid.DataSource = userBSB.getQuestions();
            questionGrid.DataBind();
        }

        protected void bind_savegrid()
        {
            questionGrid.DataSource = userBSB.readSlamBKUserQuestions(slamBKId);
            questionGrid.DataBind();
            questionGrid1.Visible = false;
            questionGrid.Visible = true;
            if (questionGrid.Rows.Count > 0)
            {
                for (int i = 0; i < questionGrid.Rows.Count; i++)
                {
                    ((CheckBox)(questionGrid.Rows[i].FindControl("chkbox"))).Checked = true;
                    ((CheckBox)(questionGrid.Rows[i].FindControl("chkbox"))).Enabled = false;
                }
                grdEdit.Visible = true;
                grdEdit.Enabled = true;
                saveQuest.Visible = false;
                saveQuest.Text = "Update";
                cancelQuest.Visible = false;
            }
            else
            {
                grdEdit.Visible = false;                
                saveQuest.Visible = true;
                cancelQuest.Visible = true;
                bind_grid();
            }
        }
        protected void bind_editgrid()
        {
            questionGrid.Visible = false;
            questionGrid1.Visible = true;
            questionGrid1.DataSource = userBSB.readSlamBKUserQuestEdit(slamBKId);
            questionGrid1.DataBind();
            if (questionGrid1.Rows.Count > 0)
            {
                for (int i = 0; i < questionGrid1.Rows.Count; i++)
                {
                    if (Convert.ToInt32(((HiddenField)(questionGrid1.Rows[i].FindControl("select"))).Value) == 1)
                    {
                        ((CheckBox)(questionGrid1.Rows[i].FindControl("chkbox"))).Checked = true;
                    }
                    else
                    {
                        ((CheckBox)(questionGrid1.Rows[i].FindControl("chkbox"))).Checked = false;
                    }
                }
            }
        }
        protected void saveQuest_Click(object sender, EventArgs e)
        {
            Int32 id,i;
            if (saveQuest.Text == "Save")
            {
                for (i = 0; i < questionGrid.Rows.Count; i++)
                {
                    if ((Convert.ToBoolean(((CheckBox)(questionGrid.Rows[i].FindControl("chkbox"))).Checked)) == true)
                    {
                        id = Convert.ToInt32(((HiddenField)(questionGrid.Rows[i].FindControl("quesHdn"))).Value);
                        userBSB.insertSlamUserQuest(slamBKId, id);                       
                    }
                }
                userBSB.updateSBStatusData(slamBKId);                
            }
            else
            {
                userBSB.deleteSlamBKUserQuest(slamBKId);
                for (i = 0; i < questionGrid1.Rows.Count; i++)
                {
                    id = Convert.ToInt32(((HiddenField)(questionGrid1.Rows[i].FindControl("quesHdn"))).Value);
                    if ((Convert.ToBoolean(((CheckBox)(questionGrid1.Rows[i].FindControl("chkbox"))).Checked)) == true)
                    {                        
                        userBSB.insertSlamUserQuest(slamBKId, id);
                    }
                    else if (id >= 1000)
                    {
                        userBSB.deleteSlamBKUserNewQuest(id);
                    }
                }               
            }
            questionGrid.Visible = true;
            questionGrid1.Visible = false;    
            saveQuest.Visible = false;
            cancelQuest.Visible = false;
            bind_savegrid();
        }

        protected void grdEdit_Click(object sender, EventArgs e)
        {
            bind_editgrid();
            grdEdit.Enabled = false;
            saveQuest.Visible = true;
            cancelQuest.Visible = true;
        }

        protected void newQuestion_Click(object sender, EventArgs e)
        {            
            newQuesttxt.Text = " ";
            newQuest.Visible = true;
        }

        protected void newquestSave_Click(object sender, EventArgs e)
        {
            userBSB.insertSlamBKUsersNewQuest(newQuesttxt.Text, userId, slamBKId);
            userBSB.updateSBStatusData(slamBKId);  
            bind_savegrid();
            newQuest.Visible = false;
        }
    }
}