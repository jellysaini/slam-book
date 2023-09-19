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
    public partial class userProfile : baseclass
    {
        Int32 i, ret, varify;
        userProfileBuinessClass userPBC;
        userBuinessClass ob1;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                i = Globals.checkPageValue;                
            }      
            userPBC = new userProfileBuinessClass(baseProperty.userUserId);
            ret = userPBC.checkDetailValue();
            pageValue();            
        }
        protected void pageValue()
        {
            if (i == 1)
            {
                edit1.Visible = false;
                edit2.Visible = false;
                edit3.Visible = false;
                edit4.Visible = false;
                save1.Visible = false;
                save2.Visible = false;
                save3.Visible = false;
                save4.Visible = false;
                cancel1.Visible = false;
                cancel2.Visible = false;
                cancel3.Visible = false;
                cancel4.Visible = false;
                imgUp.Enabled = false;
                imgUpBtn.Enabled = false;
                bindProfile();
            }
            else if (i == 2)
            {
                edit1.Visible = true;
                edit2.Visible = true;
                edit3.Visible = true;
                edit4.Visible = true;
                save1.Visible = false;
                save2.Visible = false;
                save3.Visible = false;
                save4.Visible = false;
                cancel1.Visible = false;
                cancel2.Visible = false;
                cancel3.Visible = false;
                cancel4.Visible = false;
                imgUp.Enabled = true;
                imgUpBtn.Enabled = true;
                bindProfile();
            }
            else if (i == 3)
            {
                edit1.Visible = false;
                edit2.Visible = false;
                edit3.Visible = false;
                edit4.Visible = false;
                
                httxt.ReadOnly = false;
                haircol.ReadOnly = false;
                bart.ReadOnly = false;
                Looks.ReadOnly = false;
                feaboutme.ReadOnly = false;
                thing.ReadOnly = false;
                five.ReadOnly = false;
                lookfor.ReadOnly = false;
                match.ReadOnly = false;

                reltxt.ReadOnly = false;
                Flan.ReadOnly = false;
                Slan.ReadOnly = false;
                Tlan.ReadOnly = false;
                religion.ReadOnly = false;
                Smoking.ReadOnly = false;
                Drinking.ReadOnly = false;
                hometxt.ReadOnly = false;
                linesaboutme.ReadOnly = false;
                supp.ReadOnly = false;
                Books.ReadOnly = false;
                music.ReadOnly = false;
                tvshow.ReadOnly = false;
                movies.ReadOnly = false;
                cuision.ReadOnly = false;

                edu.ReadOnly = false;
                HighSch.ReadOnly = false;
                college.ReadOnly = false;
                occupa.ReadOnly = false;
                skill.ReadOnly = false;
                intrest.ReadOnly = false;
                jobdes.ReadOnly = false;
                Industry.ReadOnly = false;
                indname.ReadOnly = false;
                indadd.ReadOnly = false;
                jobphone.ReadOnly = false;
                jobEmail.ReadOnly = false;

                email.ReadOnly = false;
                address.ReadOnly = false;
                city.ReadOnly = false;
                state.ReadOnly = false;
                country.ReadOnly = false;
                pincode.ReadOnly = false;
                telno.ReadOnly = false;
                mobno.ReadOnly = false;

                if (ret == 0)
                {
                    save1.Text="Save Changes";
                    save2.Text = "Save Changes";
                    save3.Text = "Save Changes";
                }
                else if (ret == 1)
                {
                    save1.Text = "Save Changes";
                    save2.Text = "Save Changes";
                    save3.Text = "Update Changes";
                }
                else if (ret == 2)
                {
                    save1.Text = "Save Changes";
                    save2.Text = "Update Changes";
                    save3.Text = "Save Changes";
                }
                else if (ret == 3)
                {
                    save1.Text = "Save Changes";
                    save2.Text = "Update Changes";
                    save3.Text = "Update Changes";
                }
                else if (ret == 4)
                {
                    save1.Text = "Update Changes";
                    save2.Text = "Save Changes";
                    save3.Text = "Save Changes";
                }
                else if (ret == 5)
                {
                    save1.Text = "Update Changes";
                    save2.Text = "Save Changes";
                    save3.Text = "Update Changes";
                }
                else if (ret == 6)
                {
                    save1.Text = "Update Changes";
                    save2.Text = "Update Changes";
                    save3.Text = "Save Changes";
                }
                else if (ret == 7)
                {
                    save1.Text = "Update Changes";
                    save2.Text = "Update Changes";
                    save3.Text = "Update Changes";                    
                }
                imgUp.Enabled = true;
                bindProfile();
            }
            else if (i == 4)
            {
                edit1.Visible = false;
                edit2.Visible = false;
                edit3.Visible = false;
                edit4.Visible = false;
                save1.Visible = false;
                save2.Visible = false;
                save3.Visible = false;
                save4.Visible = false;
                cancel1.Visible = false;
                cancel2.Visible = false;
                cancel3.Visible = false;
                cancel4.Visible = false;
                imgUp.Enabled = false;
                bindProfile();
            }
            else if (i == 5)
            {
                edit1.Visible = false;
                edit2.Visible = false;
                edit3.Visible = false;
                edit4.Visible = false;
                save1.Visible = false;
                save2.Visible = false;
                save3.Visible = false;
                save4.Visible = false;
                cancel1.Visible = false;
                cancel2.Visible = false;
                cancel3.Visible = false;
                cancel4.Visible = false;
                imgUp.Enabled = false;
                bindProfile();
            }
        }
        protected void bindProfile()
        {
            userPBC = new userProfileBuinessClass(baseProperty.userUserId);
            userPBC.readData();
            ob1 = new userBuinessClass(baseProperty.userUserId);
            ob1.readUsersDetail();

            FName.Text = ob1.FirstName;
            LName.Text = ob1.LastName;
            dob.Text = ob1.DateOfBirth.ToString("dd MMM yyyy");
            sex.Text = ob1.Sex;
            email.Text = ob1.EMail;
            address.Text = ob1.Address;
            city.Text = ob1.City;
            state.Text = ob1.State;
            country.Text = ob1.Country;
            pincode.Text = ob1.PinCode;
            telno.Text = ob1.TelNo;
            mobno.Text = ob1.MobNo;

            httxt.Text = Convert.ToString(userPBC.Height);
            haircol.Text = userPBC.HairColor;
            bart.Text = userPBC.BodyArt;
            Looks.Text = userPBC.Looks;
            feaboutme.Text = userPBC.BestFeature;
            thing.Text = userPBC.FirstThing;
            five.Text = userPBC.FiveThings;
            lookfor.Text = userPBC.LookingFor;
            match.Text = userPBC.IdealMatch;
            reltxt.Text = userPBC.RelStatus;
            Flan.Text = userPBC.FirstLanguage;
            Slan.Text = userPBC.SecondLanguage;
            Tlan.Text = userPBC.ThirldLanguage;
            religion.Text = userPBC.Religion;
            hometxt.Text = userPBC.HomeTown;
            linesaboutme.Text = userPBC.LinesAboutMe;
            Smoking.Text = userPBC.Smoking;
            Drinking.Text = userPBC.Drinking;
            supp.Text = userPBC.Sports;
            Books.Text = userPBC.Books;
            music.Text = userPBC.Music;
            tvshow.Text = userPBC.TVShows;
            movies.Text = userPBC.Movies;
            cuision.Text = userPBC.Cuision;
            edu.Text = userPBC.EducationLevel;
            HighSch.Text = userPBC.HighSchool;
            college.Text = userPBC.CollegeUniversity;
            occupa.Text = userPBC.Occupation;
            skill.Text = userPBC.Skills;
            intrest.Text = userPBC.Intrest;
            jobdes.Text = userPBC.Jobdescription;
            Industry.Text = userPBC.Industry;
            indname.Text = userPBC.IndustryName;
            indadd.Text = userPBC.IndustryAddress;
            jobphone.Text = userPBC.JobPhoneNo;
            jobEmail.Text = userPBC.JobEMail;

        }        

        protected void save1_Click(object sender, EventArgs e)
        {
            if (save1.Text == "Save Changes")
            {
                varify = 1;
            }
            else if (save1.Text == "Update Changes")
            {
                varify = 2;
            }
            userPBC = new userProfileBuinessClass(baseProperty.userUserId, Convert.ToInt32(httxt.Text), haircol.Text, bart.Text, Looks.Text, feaboutme.Text, thing.Text, five.Text, lookfor.Text, match.Text,varify);
            userPBC.insertPersonalDetail();
            bindProfile();
            save1.Enabled = false;
            cancel1.Enabled = false;
        }

        protected void save2_Click(object sender, EventArgs e)
        {
            if (save2.Text == "Save Changes")
            {
                varify = 1;
            }
            else if (save2.Text == "Update Changes")
            {
                varify = 2;
            }
            userPBC = new userProfileBuinessClass(baseProperty.userUserId, reltxt.Text, Flan.Text, Slan.Text, Tlan.Text, religion.Text, Smoking.Text, Drinking.Text, hometxt.Text, linesaboutme.Text, supp.Text, Books.Text, music.Text, tvshow.Text, movies.Text, cuision.Text,varify);
            userPBC.insertSocialDetail();
            bindProfile();
            save2.Enabled = false;
            cancel2.Enabled = false;
        }

        protected void save3_Click(object sender, EventArgs e)
        {
            if (save3.Text == "Save Changes")
            {
                varify = 1;
            }
            else if (save3.Text == "Update Changes")
            {
                varify = 2;
            }
            userPBC = new userProfileBuinessClass(baseProperty.userUserId, edu.Text, HighSch.Text, college.Text, occupa.Text, skill.Text, intrest.Text, jobdes.Text, Industry.Text, indname.Text, indadd.Text, jobphone.Text, jobEmail.Text,varify);
            userPBC.insertProfessionalDetail();
            bindProfile();
            save3.Enabled = false;
            cancel3.Enabled = false;
        }

        protected void save4_Click(object sender, EventArgs e)
        {
            ob1 = new userBuinessClass(baseProperty.userUserId, email.Text, address.Text, city.Text, state.Text, country.Text, pincode.Text, telno.Text, mobno.Text);
            ob1.updateUsersDetail();
            bindProfile();
            save4.Enabled = false;
            cancel4.Enabled = false;
        }

        protected void cancel1_Click(object sender, EventArgs e)
        {
            Response.Redirect("../../RegisterUser/Pages/userHome.aspx");
        }

        protected void cancel2_Click(object sender, EventArgs e)
        {
            Response.Redirect("../../RegisterUser/Pages/userHome.aspx");
        }

        protected void cancel3_Click(object sender, EventArgs e)
        {
            Response.Redirect("../../RegisterUser/Pages/userHome.aspx");
        }

        protected void cancel4_Click(object sender, EventArgs e)
        {
            Response.Redirect("../../RegisterUser/Pages/userHome.aspx");
        }

        protected void edit1_Click(object sender, EventArgs e)
        {
            save1.Text = "Update Changes";
            save1.Visible = true;
            cancel1.Visible = true;
            edit1.Enabled = false;
            imgUp.Enabled = true;
            imgUpBtn.Enabled = true;
        }

        protected void edit2_Click(object sender, EventArgs e)
        {
            save2.Text = "Update Changes";
            save2.Visible = true;
            cancel2.Visible = true;
            edit2.Enabled = false;
        }

        protected void edit3_Click(object sender, EventArgs e)
        {
            save3.Text = "Update Changes";
            save3.Visible = true;
            cancel3.Visible = true;
            edit3.Enabled = false;
        }

        protected void edit4_Click(object sender, EventArgs e)
        {
            save4.Text = "Update Changes";
            save4.Visible = true;
            cancel4.Visible = true;
            edit4.Enabled = false;
        }

        protected void imgUpBtn_Click(object sender, EventArgs e)
        {
            ob1 = new userBuinessClass();
            Int32 fileMaxSize = 500;
            string fileNamewithPath = imgUp.PostedFile.FileName;
            string extension = System.IO.Path.GetExtension(fileNamewithPath);
            string fileName = System.IO.Path.GetFileName(fileNamewithPath);
            Int32 fileSize = imgUp.PostedFile.ContentLength / 1024;
            extension = extension.ToLower();
            if (extension.Equals(".jpg") || extension.Equals(".gif"))
            {
                if (fileSize < fileMaxSize)
                {
                    imgUp.PostedFile.SaveAs(Server.MapPath("~/UserImages/") + baseProperty.userUserId.ToString() + extension);
                    string fname=baseProperty.userUserId.ToString()+extension;
                    Int32 id = baseProperty.userUserId;
                    ob1.uploadUserImageData(id, fname);
                    upmsg.Text = "Your File Has Sucessfully UpLoaded";
                    upmsg.ForeColor = System.Drawing.Color.Green;
                    imgUp.Enabled = false;
                    imgUpBtn.Enabled = false;
                }
                else
                {
                    upmsg.Text = "File must be between 500kb.";
                    upmsg.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                upmsg.Text = "Invalid file type";
                upmsg.ForeColor = System.Drawing.Color.Red;
            }
        }
        
    }
}
