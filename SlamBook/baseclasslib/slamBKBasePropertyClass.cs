using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BuinessLayer;

namespace baseclasslib
{
    public class slamBKBasePropertyClass: userBuinessClass
    {
        private Int32 _UserId;
        private Int32 _slambkId;
        private string _slambkName;
        private bool _isQuest;
        private string _slambkTitle;
        private string _slamImageName;

        public Int32 userUserId
        {
            get { return _UserId; }
            set { _UserId = value; }
        }
        public Int32 slamBKId
        {
            get { return _slambkId; }
        }
        public string slamBKName
        {
            get { return _slambkName; }
        }
        public bool isSlamQuestion
        {
            get { return _isQuest; }
        }
        public string slamBKTitle
        {
            get { return _slambkTitle; }
        }
        public string slamBKImageName
        {
            get { return _slamImageName; }
        }

        public void getSlamData(Int32 userId)
        {
            userBuinessSlamBook ob = new userBuinessSlamBook();
            ob.getSlamBase(userId);
            _UserId = ob.userID;
            _slambkId = ob.slambkId;
            _slambkName = ob.slambkName;
            _isQuest = ob.isquestionTb;
            _slambkTitle = ob.slambkTitle;
            _slamImageName = ob.slambkImage;
        }
    }
}
