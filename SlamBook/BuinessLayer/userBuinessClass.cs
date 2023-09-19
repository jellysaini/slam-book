using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataBaseLayer;

namespace BuinessLayer
{
    public class userBuinessClass : userDataAcess
    {
        private Int32 _UserId;
        private string _EMail;
        private string _Password;
        private string _pdata;
        private bool _Active;
        private string _FName;
        private string _LName;
        private DateTime _DateOfBirth;
        private string _Sex;
        private string _Address;
        private string _city;
        private string _State;
        private string _Country;
        private string _PinCode;
        private string _TelNo;
        private string _MobNo;
        private bool _IsOnline;
        private Int32 _SetStatus;
        private string _ImageName;
        private DateTime _CreatedDate;
        private DateTime _ModifyDate;
        private Int32 _totfriend;
        
        protected Int32 UserId
        {
            get { return _UserId; }
        }
        public string EMail
        {
            get { return _EMail; }
        }
        public string pData
        {
            get { return _pdata; }
        }
        protected string Password
        {
            get { return _Password; }
        }
        protected bool Active
        {
            get { return _Active; }
        }
        public string FirstName
        {
            get { return _FName; }
        }
        public string LastName
        {
            get { return _LName; }
        }
        public DateTime DateOfBirth
        {
            get { return _DateOfBirth; }
        }
        public string Sex
        {
            get { return _Sex; }
        }
        public string Address
        {
            get { return _Address; }
        }
        public string City
        {
            get { return _city; }
        }
        public string State
        {
            get { return _State; }
        }
        public string Country
        {
            get { return _Country; }
        }
        public string PinCode
        {
            get { return _PinCode; }
        }
        public string TelNo
        {
            get { return _TelNo; }
        }
        public string MobNo
        {
            get { return _MobNo; }
        }
        protected bool IsOnline
        {
            get { return _IsOnline; }
        }
        protected Int32 SetStatus
        {
            get { return _SetStatus; }
        }
        public string ImageName
        {
            get { return _ImageName; }
        }
        protected DateTime CreatedDate
        {
            get { return _CreatedDate; }
        }
        protected DateTime ModifyDate
        {
            get { return _ModifyDate; }
        }
        protected Int32 friendCount
        {
            get { return _totfriend; }
        }       

        public userBuinessClass()
        { }
        public userBuinessClass(Int32 id):base(id)
        { }
        public userBuinessClass(string EMail, string Password)
            : base(EMail, Password)
        { }
        public userBuinessClass(Int32 id, string em, string add, string city, string state, string coun, string pin, string tel, string mob)
            : base(id, em, add, city, state, coun, pin, tel, mob)
        { }
        public userBuinessClass(string fname, string lname,string ImgName,bool isactive, string email, string pass, string dob, string gen, string add, string city, string state, string country, string pin)
            : base(fname, lname, ImgName, isactive, email, pass, dob, gen, add, city, state, country, pin)
        { }
        
        public void updateUsersDetail()
        {
            updateUsers();
        }
        public bool insertnewuser()
        {
            return insertUserDate();
        }
        public bool checkUserPass()
        {
            Int32 i = checkValidUser();
            if (i == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void getUserData()
        {
            DataSet ds = getUserDetail();
            DataRow dr = ds.Tables[0].Rows[0];
            _UserId = Convert.ToInt32(dr[ds.Tables[0].Columns[0]]);
            _EMail = Convert.ToString(dr[ds.Tables[0].Columns[1]]);
            _Password = Convert.ToString(dr[ds.Tables[0].Columns[2]]);
            _Active = Convert.ToBoolean(dr[ds.Tables[0].Columns[3]]);
            _FName = Convert.ToString(dr[ds.Tables[0].Columns[4]]);
            _LName = Convert.ToString(dr[ds.Tables[0].Columns[5]]);
            _DateOfBirth = Convert.ToDateTime(dr[ds.Tables[0].Columns[6]]);
            _Sex = Convert.ToString(dr[ds.Tables[0].Columns[7]]);
            _Address = Convert.ToString(dr[ds.Tables[0].Columns[8]]);
            _city = Convert.ToString(dr[ds.Tables[0].Columns[9]]);
            _State = Convert.ToString(dr[ds.Tables[0].Columns[10]]);
            _Country = Convert.ToString(dr[ds.Tables[0].Columns[11]]);
            _PinCode = Convert.ToString(dr[ds.Tables[0].Columns[12]]);
            _TelNo = Convert.ToString(dr[ds.Tables[0].Columns[13]]);
            _MobNo = Convert.ToString(dr[ds.Tables[0].Columns[14]]);
            _IsOnline =Convert.ToBoolean (dr[ds.Tables[0].Columns[15]]);
            _SetStatus = Convert.ToInt32(dr[ds.Tables[0].Columns[16]]);
            _ImageName = Convert.ToString(dr[ds.Tables[0].Columns[17]]);
            _CreatedDate = Convert.ToDateTime(dr[ds.Tables[0].Columns[18]]);
            _ModifyDate = Convert.ToDateTime(dr[ds.Tables[0].Columns[19]]);
        }
        public void readUsersDetail()
        {
            DataTable dt = readUsers();
            _UserId = Convert.ToInt32(dt.Rows[0][0]);
            _EMail = Convert.ToString(dt.Rows[0][1]);
            _Password = Convert.ToString(dt.Rows[0][2]);
            _Active = Convert.ToBoolean(dt.Rows[0][3]);
            _FName = Convert.ToString(dt.Rows[0][4]);
            _LName = Convert.ToString(dt.Rows[0][5]);
            _DateOfBirth = Convert.ToDateTime(dt.Rows[0][6]);
            _Sex = Convert.ToString(dt.Rows[0][7]);
            _Address = Convert.ToString(dt.Rows[0][8]);
            _city = Convert.ToString(dt.Rows[0][9]);
            _State = Convert.ToString(dt.Rows[0][10]);
            _Country = Convert.ToString(dt.Rows[0][11]);
            _PinCode = Convert.ToString(dt.Rows[0][12]);
            _TelNo = Convert.ToString(dt.Rows[0][13]);
            _MobNo = Convert.ToString(dt.Rows[0][14]);
            _IsOnline = Convert.ToBoolean(dt.Rows[0][15]);
            _SetStatus = Convert.ToInt32(dt.Rows[0][16]);
            _ImageName = Convert.ToString(dt.Rows[0][17]);
            _CreatedDate = Convert.ToDateTime(dt.Rows[0][18]);
            _ModifyDate = Convert.ToDateTime(dt.Rows[0][19]);
        }
        public DataTable getUserFL(Int32 id)
        {
            DataTable dt = getUserFriendDetail(id);
            return dt;
        }
        public DataTable getUserFriend(Int32 userid,Int32 pn)
        {
            DataTable dt = getUserFriendList(userid,pn);            
            return dt;
        }
        public void totalfriend(Int32 id)
        {
            _totfriend = totalFriends(id); 
        }
        public bool forgetFetchPassworddata(string email)
        {
            string p=forgetFetchPassword(email);
            if(p=="")
            {
                return false;    
            }
            else
            {
                _pdata = p;
                return true;
            }
        }
        public void uploadUserImageData(Int32 id, string imgname)
        {
            uploadUserImage(id, imgname);
        }
    }
}