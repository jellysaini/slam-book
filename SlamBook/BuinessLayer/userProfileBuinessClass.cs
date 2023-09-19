using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DataBaseLayer;

namespace BuinessLayer
{
    public class userProfileBuinessClass : userDataProfileClass
    {
     //global data
        //database fields
        private Int32 _userId;
        private DateTime _createdDate;
        private DateTime _modifyDate;

        //start of global properties

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

        //start of global constructor

        public userProfileBuinessClass()
        { }

        public userProfileBuinessClass(Int32 id)
            : base(id)
        { }

        //for social profile

        //private variable for social profile

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

        //public properties for social profile

        public string RelStatus
        {
            get { return _relStatus; }
        }
        public string FirstLanguage
        {
            get { return _fLang; }
        }
        public string SecondLanguage
        {
            get { return _sLang; }
        }
        public string ThirldLanguage
        {
            get { return _tLang; }
        }
        public string Religion
        {
            get { return _religion; }
        }
        public string Smoking
        {
            get { return _smoking; }
        }
        public string Drinking
        {
            get { return _drinking; }
        }
        public string HomeTown
        {
            get { return _homeTown; }
        }
        public string LinesAboutMe
        {
            get { return _linesAboutMe; }
        }
        public string Sports
        {
            get { return _sports; }
        }
        public string Books
        {
            get { return _books; }
        }
        public string Music
        {
            get { return _music; }
        }
        public string TVShows
        {
            get { return _tvShows; }
        }
        public string Movies
        {
            get { return _movies; }
        }
        public string Cuision
        {
            get { return _cuision; }
        }

        //constructor and functions

        public userProfileBuinessClass(Int32 id, string relStatus, string fLang, string sLang, string tLang, string religion, string smoking, string drinking, string homeTown, string linesAboutme, string sports, string books, string music, string tvShows, string movies, string cuision,Int32 vari)
            : base(id, relStatus, fLang, sLang, tLang, religion, smoking, drinking, homeTown, linesAboutme, sports, books, music, tvShows, movies, cuision,vari)
        { }

        public void insertSocialDetail()
        {
            insertSocial();
        }

        protected void readSocialData()
        {
            DataTable dt = readSocialDetail();
            if (dt.Rows.Count > 0)
            { 
                _userId = Convert.ToInt32(dt.Rows[0][0]);
                _relStatus = Convert.ToString(dt.Rows[0][1]);
                _fLang = Convert.ToString(dt.Rows[0][2]);
                _sLang = Convert.ToString(dt.Rows[0][3]);
                _tLang = Convert.ToString(dt.Rows[0][4]);
                _religion = Convert.ToString(dt.Rows[0][5]);
                _smoking = Convert.ToString(dt.Rows[0][6]);
                _drinking = Convert.ToString(dt.Rows[0][7]);
                _homeTown = Convert.ToString(dt.Rows[0][8]);
                _linesAboutMe = Convert.ToString(dt.Rows[0][9]);
                _sports = Convert.ToString(dt.Rows[0][10]);
                _books = Convert.ToString(dt.Rows[0][11]);
                _music = Convert.ToString(dt.Rows[0][12]);
                _tvShows = Convert.ToString(dt.Rows[0][13]);
                _movies = Convert.ToString(dt.Rows[0][14]);
                _cuision = Convert.ToString(dt.Rows[0][15]);
                _createdDate = Convert.ToDateTime (dt.Rows[0][16]);
                _modifyDate = Convert.ToDateTime(dt.Rows[0][17]);
            }
        }

    //for Professional profile

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

        //for Professional Details table properties

        public string EducationLevel
        {
            get { return _eduLevel; }
        }
        public string HighSchool
        {
            get { return _highSchool; }
        }
        public string CollegeUniversity
        {
            get { return _collUni; }
        }
        public string Occupation
        {
            get { return _occupation; }
        }
        public string Skills
        {
            get { return _skills; }
        }
        public string Intrest
        {
            get { return _intrest; }
        }
        public string Jobdescription
        {
            get { return _jobDesc; }
        }
        public string Industry
        {
            get { return _industry; }
        }
        public string IndustryName
        {
            get { return _industryName; }
        }
        public string IndustryAddress
        {
            get { return _industryAddress; }
        }
        public string JobPhoneNo
        {
            get { return _jobPhone; }
        }
        public string JobEMail
        {
            get { return _jobEmail; }
        }

        //constructor and functions

        public userProfileBuinessClass(Int32 id, string eduLevel, string highSchool, string collUni, string occupation, string skills, string intrest, string jobDesc, string industry, string industryName, string industryAddress, string jobPhone, string jobEmail,Int32 vari)
            : base(id, eduLevel, highSchool, collUni, occupation, skills, intrest, jobDesc, industry, industryName, industryAddress, jobPhone, jobEmail,vari)
        { }

        public void insertProfessionalDetail()
        {
            insertProfessonal();
        }

        protected void readProfessionalDetail()
        {
            DataTable dt = readProfessional();
            if (dt.Rows.Count > 0)
            {
                _userId = Convert.ToInt32(dt.Rows[0][0]);
                _eduLevel=Convert.ToString(dt.Rows[0][1]);
                _highSchool = Convert.ToString(dt.Rows[0][2]);
                _collUni = Convert.ToString(dt.Rows[0][3]);
                _occupation = Convert.ToString(dt.Rows[0][4]);
                _skills = Convert.ToString(dt.Rows[0][5]);
                _intrest = Convert.ToString(dt.Rows[0][6]);
                _jobDesc = Convert.ToString(dt.Rows[0][7]);
                _industry = Convert.ToString(dt.Rows[0][8]);
                _industryName = Convert.ToString(dt.Rows[0][9]);
                _industryAddress = Convert.ToString(dt.Rows[0][10]);
                _jobPhone = Convert.ToString(dt.Rows[0][11]);
                _jobEmail = Convert.ToString(dt.Rows[0][12]);
                _createdDate = Convert.ToDateTime(dt.Rows[0][13]);
                _modifyDate = Convert.ToDateTime(dt.Rows[0][14]);
            }
        }

    //for Personal Profile
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

        //for Personal Details table

        public Int32 Height
        {
            get { return _height; }
        }
        public string HairColor
        {
            get { return _hairColor; }
        }
        public string BodyArt
        {
            get { return _bodyArt; }
        }
        public string Looks
        {
            get { return _looks; }
        }
        public string BestFeature
        {
            get { return _bestFeatures; }
        }
        public string FirstThing
        {
            get { return _firstThing; }
        }
        public string FiveThings
        {
            get { return _fiveThings; }
        }
        public string LookingFor
        {
            get { return _lookingFor; }
        }
        public string IdealMatch
        {
            get { return _idealMatch; }
        }

        //constructor and functions

        public userProfileBuinessClass(Int32 id, Int32 height, string hairColor, string bodyArt, string looks, string bestFeatures, string firstThing, string fiveThings, string lookingFor, string idealMatch,Int32 vari)
            : base(id, height, hairColor, bodyArt, looks, bestFeatures, firstThing, fiveThings, lookingFor, idealMatch,vari)
        { }

        public void insertPersonalDetail()
        {
            insertPersonal();
        }

        protected void readPersonalDetail()
        {
            DataTable dt = readPersonal();
            if (dt.Rows.Count > 0)
            {
                _userId = Convert.ToInt32(dt.Rows[0][0]);
                _height = Convert.ToInt32(dt.Rows[0][1]);
                _hairColor = Convert.ToString(dt.Rows[0][2]);
                _bodyArt = Convert.ToString(dt.Rows[0][3]);
                _looks = Convert.ToString(dt.Rows[0][4]);
                _bestFeatures = Convert.ToString(dt.Rows[0][5]);
                _firstThing = Convert.ToString(dt.Rows[0][6]);
                _fiveThings = Convert.ToString(dt.Rows[0][7]);
                _lookingFor = Convert.ToString(dt.Rows[0][8]);
                _idealMatch = Convert.ToString(dt.Rows[0][9]);
                _createdDate = Convert.ToDateTime(dt.Rows[0][10]);
                _modifyDate = Convert.ToDateTime(dt.Rows[0][11]);
            }
        }

        //for check detail

        public Int32 checkDetailValue()
        {
            Int32 i = checkDetail();
            return i;
        }
        public void readData()
        {
            readSocialData();
            readProfessionalDetail();
            readPersonalDetail();
        }
    }
}
