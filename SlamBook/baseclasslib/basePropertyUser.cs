using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BuinessLayer;
namespace baseclasslib
{
    public class basePropertyUser : userBuinessClass
    {
        private bool _Active;
        private Int32 _UserId;
        private string _FName;
        private string _LName;
        private string _ImageName;
        private Int32 _friendCount;
        private string _userEMail;

        //private bool _IsOnline;
        //private Int32 _SetStatus;

        public basePropertyUser()
        { }
        public basePropertyUser(string EMail, string Pass) : base(EMail, Pass) 
        { }

        public bool userActive
        {
            get { return _Active; }
            set { _Active = value; }
        }
        public Int32 userUserId
        {
            get { return _UserId; }
            set { _UserId = value; }
        }
        public string userFName
        {
            get { return _FName; }
            set { _FName = value; }
        }
        public string userLName
        {
            get { return _LName; }
            set { _LName = value; }
        }
        public string userImage
        {
            get { return _ImageName; }
            set { _ImageName = value; }
        }
        public Int32 userFriends
        {
            get { return _friendCount; }
            set { _friendCount = value; }
        }
        public string userEMail
        {
            get { return _userEMail; }
            set { _userEMail = value; }
        }
        
        // public bool userIsOnline
        //{
          //  get { return _IsOnline; }
           // set { _IsOnline = value; }
        //}
       // public Int32 userSetStatus
       // {
         //   get { return _SetStatus; }
           // set { _SetStatus = value; }
        //}

        public void getValue()
        {            
            getUserData();            
            userActive = Active;
            userUserId = UserId;
            userEMail = EMail;
            userFName = FirstName;
            userLName = LastName;
            userImage = ImageName;
            totalfriend(userUserId);
            userFriends = friendCount;            
           // userIsOnline = IsOnline;
            //userSetStatus = SetStatus;
        }
    }
}
