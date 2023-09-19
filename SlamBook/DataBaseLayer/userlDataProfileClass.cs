using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace DataBaseLayer
{
    public class userDataProfileClass:connection 
    {

    //database fields
        private Int32 _userId;
        private DateTime _createdDate;
        private DateTime _modifyDate;
        private Int32 _varify;
        private SqlConnection con;
        private SqlCommand cmd;
        //start of social database fields
        
        private string _relStatus;
        private string _fLang;
        private string _sLang;
        private string _tLang;
        private string _religion;
        private string _smoking;
        private string _drinking;
        private string _homeTown;
        private string _linesAboutMe;
        private string _sports;
        private string _books;
        private string _music;
        private string _tvShows;
        private string _movies;
        private string _cuision;        

        //start of Professional database fields

        private string _eduLevel;
        private string _highSchool;
        private string _collUni;
        private string _occupation;
        private string _skills;
        private string _intrest;
        private string _jobDesc;
        private string _industry;
        private string _industryName;
        private string _industryAddress;
        private string _jobPhone;
        private string _jobEmail;

        //start of Personal Detail table fields

        private Int32 _height;
        private string _hairColor;
        private string _bodyArt;
        private string _looks;
        private string _bestFeatures;
        private string _firstThing;
        private string _fiveThings;
        private string _lookingFor;
        private string _idealMatch;
        
    //start of readonly properties

        protected Int32 userId
        {
            get { return _userId; }
        }
        protected DateTime CreatedDate
        {
            get { return _createdDate; }
        }
        protected DateTime ModifyDate
        {
            get { return _modifyDate; }
        }
        protected Int32 Varify
        {
            get { return _varify; }
        }
        //for Social Profile

        protected string RelStatus
        {
            get { return _relStatus; }
        }
        protected string FirstLanguage
        {
            get { return _fLang; }
        }
        protected string SecondLanguage
        {
            get { return _sLang; }
        }
        protected string ThirldLanguage
        {
            get { return _tLang; }
        }
        protected string Religion
        {
            get { return _religion; }
        }
        protected string Smoking
        {
            get { return _smoking; }
        }
        protected string Drinking
        {
            get { return _drinking; }
        }
        protected string HomeTown
        {
            get { return _homeTown; }
        }
        protected string LinesAboutMe
        {
            get { return _linesAboutMe; }
        }
        protected string Sports
        {
            get { return _sports; }
        }
        protected string Books
        {
            get { return _books; }
        }
        protected string Music
        {
            get { return _music; }
        }
        protected string TVShows
        {
            get { return _tvShows; }
        }
        protected string Movies
        {
            get { return _movies; }
        }
        protected string Cuision
        {
            get { return _cuision; }
        }        

        //for Professional Details table
        
        protected string EducationLevel
        {
            get { return _eduLevel; }
        }
        protected string HighSchool
        {
            get { return _highSchool; }
        }
        protected string CollegeUniversity
        {
            get { return _collUni; }
        }
        protected string Occupation
        {
            get { return _occupation; }
        }
        protected string Skills
        {
            get { return _skills; }
        }
        protected string Intrest
        {
            get { return _intrest; }
        }
        protected string Jobdescription
        {
            get { return _jobDesc; }
        }
        protected string Industry
        {
            get { return _industry; }
        }
        protected string IndustryName
        {
            get { return _industryName; }
        }
        protected string IndustryAddress
        {
            get { return _industryAddress; }
        }
        protected string JobPhoneNo
        {
            get { return _jobPhone; }
        }
        protected string JobEMail
        {
            get { return _jobEmail; }
        }
        
        //for Personal Details table

        protected Int32 Height
        {
            get { return _height; }
        }
        protected string HairColor
        {
            get { return _hairColor; }
        }
        protected string BodyArt
        {
            get { return _bodyArt; }
        }
        protected string Looks
        {
            get { return _looks; }
        }
        protected string BestFeature
        {
            get { return _bestFeatures; }
        }
        protected string FirstThing
        {
            get { return _firstThing; }
        }
        protected string FiveThings
        {
            get { return _fiveThings; }
        }
        protected string LookingFor
        {
            get { return _lookingFor; }
        }
        protected string IdealMatch
        {
            get { return _idealMatch; }
        }

    //start of user defined constructor 
        
        protected userDataProfileClass()
        { }
        protected userDataProfileClass(Int32 id)
        {
            _userId = id;
        }
        //For passing social profile values
        protected userDataProfileClass(Int32 id, string relStatus, string fLang, string sLang, string tLang, string religion, string smoking, string drinking, string homeTown, string linesAboutMe, string sports, string books, string music, string tvShow, string movies, string cuision,Int32 vari)
        {
            _userId = id;
            _relStatus = relStatus;
            _fLang = fLang;
            _sLang = sLang;
            _tLang = tLang;
            _religion = religion;
            _smoking = smoking;
            _drinking = drinking;
            _homeTown = homeTown;
            _linesAboutMe = linesAboutMe;
            _sports = sports;
            _books = books;
            _music = music;
            _tvShows = tvShow;
            _movies = movies;
            _cuision = cuision;
            _createdDate = DateTime.Now;
            _modifyDate = DateTime.Now;
            _varify = vari;
        }

        //for Professional Profile table
        protected userDataProfileClass(Int32 id, string eduLevel, string highSchool, string collUni, string occu, string skill, string intrest, string jobDesc, string industry, string industryName, string industryAdd, string jobPhone, string jobEmail, Int32 vari)
        {
            _userId = id;
            _eduLevel = eduLevel;
            _highSchool = highSchool;
            _collUni = collUni;
            _occupation = occu;
            _skills = skill;
            _intrest = intrest;
            _jobDesc = jobDesc;
            _industry = industry;
            _industryName = industryName;
            _industryAddress = industryAdd;
            _jobPhone = jobPhone;
            _jobEmail = jobEmail;
            _createdDate = DateTime.Now;
            _modifyDate = DateTime.Now;
            _varify = vari;
        }

        //for Personal detail table

        protected userDataProfileClass(Int32 id, Int32 height, string hairColor, string bodyArt, string looks, string bestFeatures, string firstThing, string fiveThings, string lookingFor, string idealMatch,Int32 Vari)
        {
            _userId = id;
            _height = height;
            _hairColor = hairColor;
            _bodyArt = bodyArt;
            _looks = looks;
            _bestFeatures = bestFeatures;
            _firstThing = firstThing;
            _fiveThings = fiveThings;
            _lookingFor = lookingFor;
            _idealMatch = idealMatch;
            _createdDate = DateTime.Now;
            _modifyDate = DateTime.Now;
            _varify = Vari;
        }

    //start of userdefined functions

        protected Int32 checkDetail()
        {
            con = getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand("checkRecordExist", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = userId;
            SqlParameter p = new SqlParameter("@ret", SqlDbType.Int);
            p.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p);
            try
            {
                cmd.ExecuteNonQuery();
                Int32 i = Convert.ToInt32(cmd.Parameters["@ret"].Value);
                return i;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
        }

        //For social profile functions 

        protected void insertSocial()
        {
            con = getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand("insertSocialProfile", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = userId;
            cmd.Parameters.Add("@RelStatus", SqlDbType.VarChar, 20).Value = RelStatus.Trim();
            cmd.Parameters.Add("@FLang", SqlDbType.VarChar, 20).Value = FirstLanguage.Trim();
            cmd.Parameters.Add("@SLang", SqlDbType.VarChar, 20).Value = SecondLanguage.Trim();
            cmd.Parameters.Add("@TLang", SqlDbType.VarChar, 20).Value = ThirldLanguage.Trim();
            cmd.Parameters.Add("@Religion", SqlDbType.VarChar, 25).Value = Religion.Trim();
            cmd.Parameters.Add("@Smoking", SqlDbType.VarChar, 7).Value = Smoking.Trim();
            cmd.Parameters.Add("@Drinking", SqlDbType.VarChar, 7).Value = Drinking.Trim();
            cmd.Parameters.Add("@HomeTown", SqlDbType.VarChar, 50).Value = HomeTown.Trim();
            cmd.Parameters.Add("@LinesAboutMe", SqlDbType.VarChar, 150).Value = LinesAboutMe.Trim();
            cmd.Parameters.Add("@Sports", SqlDbType.VarChar, 100).Value = Sports.Trim();
            cmd.Parameters.Add("@Books", SqlDbType.VarChar, 100).Value = Books.Trim();
            cmd.Parameters.Add("@Music", SqlDbType.VarChar, 100).Value = Music.Trim();
            cmd.Parameters.Add("@TVShows", SqlDbType.VarChar, 100).Value = TVShows.Trim();
            cmd.Parameters.Add("@Movies", SqlDbType.VarChar, 100).Value = Movies.Trim();
            cmd.Parameters.Add("@Cuision", SqlDbType.VarChar, 100).Value = Cuision.Trim();
            cmd.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = CreatedDate;
            cmd.Parameters.Add("@ModifyDate", SqlDbType.DateTime).Value = ModifyDate;
            cmd.Parameters.Add("@Varify", SqlDbType.Int).Value = Varify;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally 
            {
                cmd.Dispose();
                con.Close();
            }
        }

        protected DataTable readSocialDetail()
        {
            con = getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("readSocial", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = userId;
            DataTable dt = new DataTable();
            try
            {
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dt.Load(dr);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
        }

        //For Personal profile functions
        protected void insertPersonal()
        {
            con = getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand("insertPersonalDetail", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = userId;
            cmd.Parameters.Add("@Height", SqlDbType.Int).Value = Height;
            cmd.Parameters.Add("@HairColor", SqlDbType.VarChar, 15).Value = HairColor.Trim();
            cmd.Parameters.Add("@BodyArt", SqlDbType.VarChar, 15).Value = BodyArt.Trim();
            cmd.Parameters.Add("@Looks", SqlDbType.VarChar, 20).Value = Looks.Trim();
            cmd.Parameters.Add("@BestFeature", SqlDbType.VarChar, 50).Value = BestFeature.Trim();
            cmd.Parameters.Add("@FirstThing", SqlDbType.VarChar, 50).Value = FirstThing.Trim();
            cmd.Parameters.Add("@FiveThings", SqlDbType.VarChar, 150).Value = FiveThings.Trim();
            cmd.Parameters.Add("@LookingFor", SqlDbType.VarChar, 50).Value = LookingFor.Trim();
            cmd.Parameters.Add("@IdealMatch", SqlDbType.VarChar, 150).Value = IdealMatch.Trim();
            cmd.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = CreatedDate;
            cmd.Parameters.Add("@ModifyDate", SqlDbType.DateTime).Value = ModifyDate;
            cmd.Parameters.Add("@Varify", SqlDbType.Int).Value = Varify;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally 
            {
                cmd.Dispose();
                con.Close();
            }
        }

        protected DataTable readPersonal()
        {
            con = getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand("readPersonal", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = userId;
            DataTable dt = new DataTable();
            try
            {
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dt.Load(dr);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }

        }

        //for Professional profile functions

        protected void insertProfessonal()
        {
            con = getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand("insertProfessionalDetail", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = userId;
            cmd.Parameters.Add("@EducationalLevel", SqlDbType.VarChar, 15).Value = EducationLevel.Trim();
            cmd.Parameters.Add("@HighSchool", SqlDbType.VarChar, 50).Value = HighSchool.Trim();
            cmd.Parameters.Add("@CollegeUni", SqlDbType.VarChar, 50).Value = CollegeUniversity.Trim();
            cmd.Parameters.Add("@Occupation", SqlDbType.VarChar, 25).Value = Occupation.Trim();
            cmd.Parameters.Add("@Skills", SqlDbType.VarChar, 50).Value = Skills.Trim();
            cmd.Parameters.Add("@Intrest", SqlDbType.VarChar, 50).Value = Intrest.Trim();
            cmd.Parameters.Add("@JobDesc", SqlDbType.VarChar, 50).Value = Jobdescription.Trim();
            cmd.Parameters.Add("@Industry", SqlDbType.VarChar, 50).Value = Industry.Trim();
            cmd.Parameters.Add("@IndustryName", SqlDbType.VarChar, 50).Value = IndustryName.Trim();
            cmd.Parameters.Add("@IndustryAddress", SqlDbType.VarChar, 150).Value = IndustryAddress.Trim();
            cmd.Parameters.Add("@JobPhone", SqlDbType.VarChar, 15).Value = JobPhoneNo.Trim();
            cmd.Parameters.Add("@JobEmail", SqlDbType.VarChar, 50).Value = JobEMail.Trim();
            cmd.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = CreatedDate;
            cmd.Parameters.Add("@ModifyDate", SqlDbType.DateTime).Value = ModifyDate;
            cmd.Parameters.Add("@Varify", SqlDbType.Int).Value = Varify;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
        }

        protected DataTable readProfessional()
        {
            con = getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand("readProfessional", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = userId;            
            DataTable dt = new DataTable();
            try
            {
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dt.Load(dr);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
        }
    
    }
}
