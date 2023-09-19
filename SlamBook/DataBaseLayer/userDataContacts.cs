using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataBaseLayer
{
    public class userDataContacts:connection
    {
        SqlConnection con;
        SqlCommand cmd;
        private Int32 _totalrec;
        private Int32 _totalsearchrec;
        private Int32 _UserId;
        private Int32 _SNo;
        private string _ImageName;
        private string _FName;
        private string _LName;
        private string _DateOfBirth;
        private string _Sex;
        private string _City;
        private string _State;
        private string _Country;
        private string _MobNo;
        private string _EMail;
        private Int32 _SetStatus;

        protected Int32 userId
        {
            get { return _UserId; }
        }
        protected Int32 sno
        {
            get { return _SNo; }
        }
        protected string imageName
        {
            get { return _ImageName; }
        }
        protected string firstName
        {
            get { return _FName; }
        }
        protected string lastName
        {
            get { return _LName; }
        }
        protected string dob
        {
            get { return _DateOfBirth; }
        }
        protected string sex
        {
            get { return _Sex; }
        }
        protected string city
        {
            get { return _City; }
        }
        protected string state
        {
            get { return _State; }
        }
        protected string country
        {
            get { return _Country; }
        }
        protected string mobNo
        {
            get { return _MobNo; }
        }
        protected string email
        {
            get { return _EMail; }
        }
        protected Int32 setStatus
        {
            get { return _SetStatus; }
        }
        protected Int32 totalrec
        {
            get { return _totalrec; }
        }
        protected Int32 totalSearchRec
        {
            get { return _totalsearchrec; }
        }

        protected DataTable readFriendList(Int32 userId,Int32 pno)
        {            
            con = getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand("showFriendsList", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@userId", SqlDbType.Int).Value = userId;
            cmd.Parameters.Add("@PageNumber",SqlDbType.Int).Value=pno;
            cmd.Parameters.Add("@PageSize", SqlDbType.Int).Value = 10;
            cmd.Parameters.Add("@totalRec", SqlDbType.Int);
            cmd.Parameters["@totalRec"].Direction = ParameterDirection.Output;
            DataTable dt = new DataTable();
            try
            {
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);                 
                dt.Load(dr);                
                _totalrec = (Int32)cmd.Parameters["@totalRec"].Value;
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
        protected DataTable SearchByNamedata(Int32 id, string fname)
        {
            con = getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand("searchByName", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("ID", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@FN", SqlDbType.VarChar, 25).Value = fname.Trim();                         
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
        protected DataTable SearchByStatedata(Int32 id, string stateName)
        {
            con = getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand("searchByState", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("ID", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@SN", SqlDbType.VarChar, 25).Value = stateName.Trim();
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
        protected DataTable SearchByCountrydata(Int32 id, string Country)
        {
            con = getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand("searchByCountry", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("ID", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@CN", SqlDbType.VarChar, 25).Value = Country.Trim();
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
        protected void insertFriendReq(Int32 reqOutId, Int32 reqInId, string myMsg)
        {
            con = getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand("insertFriendReq", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@reqOutId", SqlDbType.Int).Value = reqOutId;
            cmd.Parameters.Add("@reqInId",SqlDbType.Int).Value=reqInId;
            cmd.Parameters.Add("@isAccept", SqlDbType.Bit).Value = false;
            cmd.Parameters.Add("@msg", SqlDbType.VarChar, 100).Value = myMsg.Trim();
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
        protected DataTable readSlamBKContactReq(Int32 userid, Int32 sbId,Int32 pno)
        {
            con = getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand("readSBReqContacts", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@userid", SqlDbType.Int).Value = userid;
            cmd.Parameters.Add("@sbid", SqlDbType.Int).Value = sbId;
            cmd.Parameters.Add("@pageno", SqlDbType.Int).Value = pno;
            cmd.Parameters.Add("@pagesize", SqlDbType.Int).Value = 10;
            cmd.Parameters.Add("@totalrec", SqlDbType.Int);
            cmd.Parameters["@totalrec"].Direction = ParameterDirection.Output;
            DataTable dt = new DataTable();
            try
            {
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dt.Load(dr);
                _totalsearchrec = (Int32)cmd.Parameters["@totalrec"].Value;   
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
        protected void insertSBReq(Int32 uId, Int32 sbId, Int32 modiId)
        {
            con = getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand("insertSBRequest", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@userId",SqlDbType.Int).Value=uId;
            cmd.Parameters.Add("@sbId",SqlDbType.Int).Value=sbId;
            cmd.Parameters.Add("@accept",SqlDbType.Bit).Value=false;
            cmd.Parameters.Add("@modiId", SqlDbType.Int).Value = modiId;
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
        protected DataTable readFLSlamRec(Int32 id)
        {
            con = getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand("readFListSlam", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@userId", SqlDbType.Int).Value = id;
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
        protected void insertScrapRec(Int32 tid, Int32 fid, string msg)
        {
            con = getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand("insertDailyScrap", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@toUId",SqlDbType.Int).Value=tid;
            cmd.Parameters.Add("@fromUId",SqlDbType.Int).Value=fid;
            cmd.Parameters.Add("@msg", SqlDbType.VarChar, 250).Value = msg.Trim();
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
        protected DataTable readScrapData(Int32 uid,Int32 pno)
        {
            con = getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand("readScrapData", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@userId",SqlDbType.Int).Value=uid;
            cmd.Parameters.Add("@pageNo",SqlDbType.Int).Value=pno;
            cmd.Parameters.Add("@pageSize", SqlDbType.Int).Value = 10;
            cmd.Parameters.Add("@totalrec", SqlDbType.Int);
            cmd.Parameters["@totalrec"].Direction = ParameterDirection.Output;
            DataTable dt = new DataTable();
            try
            {
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dt.Load(dr);
                _totalsearchrec = (Int32)cmd.Parameters["@totalrec"].Value;
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
        protected void updateActiveUsers(Int32 id)
        {
            con = getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand("updateActiveUsers", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@value", SqlDbType.Bit).Value = true;
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
        protected void acceptInviteUserasFriend(Int32 uid, Int32 ruid)
        {
            con = getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand("acceptInviteUserasFriend", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@userId", SqlDbType.Int).Value = uid;
            cmd.Parameters.Add("@relUserId", SqlDbType.Int).Value = ruid;
            cmd.Parameters.Add("@isActive", SqlDbType.Bit).Value = true;
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
        protected void acceptFriendRequest(Int32 uid, Int32 ruid)
        {
            con = getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand("acceptFriendReq", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@userId", SqlDbType.Int).Value = uid;
            cmd.Parameters.Add("@relUserId", SqlDbType.Int).Value = ruid;
            cmd.Parameters.Add("@isActive", SqlDbType.Bit).Value = true;
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
        protected DataTable readhomeFriendReq(Int32 uid)
        {
            con = getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand("homeFriendReq", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = uid;
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
        protected void denyFriendReq(Int32 uId, Int32 relId)
        {
            con = getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand("denayFriendReq", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("userId", SqlDbType.Int).Value = uId;
            cmd.Parameters.Add("@relUserId", SqlDbType.Int).Value = relId;
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
        protected void inviteOutContacts(Int32 uid, string email, string sentId)
        {
            con = getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand("InviteFriends", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@uid", SqlDbType.Int).Value = uid;
            cmd.Parameters.Add("@emailId", SqlDbType.VarChar, 20).Value = email;
            cmd.Parameters.Add("@isAccept", SqlDbType.Bit).Value = false;
            cmd.Parameters.Add("@sentId", SqlDbType.VarChar, 50).Value = sentId;
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
        protected void editFriendList(Int32 uid, Int32 fid)
        {
            con = getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand("editFriendList", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@uid", SqlDbType.Int).Value = uid;
            cmd.Parameters.Add("@fuid", SqlDbType.Int).Value = fid;
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
        protected void editScrap(Int32 id)
        {
            con = getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand("editScrap", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
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
    }
}
