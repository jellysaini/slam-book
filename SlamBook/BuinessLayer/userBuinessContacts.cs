using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DataBaseLayer;
namespace BuinessLayer
{
    public class userBuinessContacts : userDataContacts
    {
        private Int32 _totalrecord;
        private Int32 _totalsearchrecord;
        public Int32 totalSearchRecord
        {
            get { return _totalsearchrecord; }
        }
        public Int32 totalRecord
        {
            get { return _totalrecord; }
        }
        public DataTable readFriendListDetail(Int32 userId, Int32 pno)
        {
            DataTable dt = readFriendList(userId, pno);
            _totalrecord = totalrec;
            return dt;
        }
        public DataTable searchbyname(Int32 id, string fname)
        {
            DataTable dt = SearchByNamedata(id, fname);
            _totalsearchrecord = dt.Rows.Count;
            return dt;
        }
        public DataTable searchbystate(int id, string sname)
        {
            DataTable dt = SearchByStatedata(id, sname);
            _totalsearchrecord = dt.Rows.Count;
            return dt;
        }
        public DataTable searchbycountry(int id, string cname)
        {
            DataTable dt = SearchByCountrydata(id, cname);
            _totalsearchrecord = dt.Rows.Count;
            return dt;
        }
        public void insertFriendRequest(Int32 outId, Int32 inId, string myMsg)
        {
            insertFriendReq(outId, inId, myMsg);
        }
        public DataTable readSlamBKContactRequest(Int32 uid, Int32 sbId,Int32 pno)
        {
            DataTable dt = readSlamBKContactReq(uid, sbId,pno);
            _totalsearchrecord = totalSearchRec;
            return dt;
        }
        public void insertSBRequest(Int32 id, Int32 sbId, Int32 modiId)
        {
            insertSBReq(id, sbId, modiId);
        }
        public DataTable readFLSlamRecord(Int32 id)
        {
            DataTable dt = readFLSlamRec(id);
            _totalsearchrecord = dt.Rows.Count;
            return dt;
        }
        public void insertScrapRecord(Int32 tid, Int32 fid, string msg)
        {
            insertScrapRec(tid, fid, msg);
        }
        public DataTable readScrapDataValues(int uid, Int32 pno)
        {
            DataTable dt = readScrapData(uid, pno);
            _totalsearchrecord = totalSearchRec;
            return dt;
        }
        public void updateActiveUsersData(Int32 id)
        {
            updateActiveUsers(id);
        }
        public void acceptInviteUserasFrienddata(Int32 id, Int32 rid)
        {
            acceptInviteUserasFriend(id, rid);
        }
        public DataTable readhomeFriendReqdata(int id)
        {
            DataTable dt = readhomeFriendReq(id);
            return dt;
        }
        public void acceptFriendReqData(Int32 uid, Int32 relId)
        {
            acceptFriendRequest(uid, relId);
        }
        public void denyFriendReqdata(Int32 uid, Int32 relid)
        {
            denyFriendReq(uid, relid);
        }
        public void inviteOutContactsData(Int32 uid, string email, string sentId)
        {
            inviteOutContacts(uid, email, sentId);
        }
        public void editFriendListdata(Int32 uid, Int32 fid)
        {
            editFriendList(uid, fid);
        }
        public void editScrapData(Int32 id)
        {
            editScrap(id);
        }
    }
}
