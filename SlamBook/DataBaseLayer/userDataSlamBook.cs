using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Data;
using System.Text;
using System.Data.SqlClient;
namespace DataBaseLayer
{
    public class userDataSlamBook:connection
    {
        SqlConnection con;
        SqlCommand cmd;

        private Int32 _userId;
        private Int32 _totalRows;
        private string _slamBKName;
        private bool _isQuestionTB;
        private string _titleMsg;
        private string _slambkImage;
        private DateTime _createdDate;
        private DateTime _modifyDate;

        protected Int32 userId
        {
            get { return _userId; }
        }
        protected Int32 totalRows
        {
            get { return _totalRows; }
        }
        protected string slamBKName
        {
            get { return _slamBKName; }
        }
        protected bool isQuestionTable 
        {
            get { return _isQuestionTB; }
        }
        protected string titleMsg
        {
            get { return _titleMsg; }
        }
        protected string slambkImage
        { 
            get { return _slambkImage; } 
        }
        protected DateTime createdDate
        {
            get { return _createdDate; }
        }
        protected DateTime modifyDate
        {
            get { return _modifyDate; }
        }

        protected userDataSlamBook()
        { }
        protected userDataSlamBook(Int32 id, string slamBK,bool isQuest, string title, string slamImage)
        {
            _userId = id;
            _slamBKName = slamBK;
            _isQuestionTB = isQuest;
            _titleMsg = title;
            _slambkImage = slamImage;
            _createdDate = DateTime.Now;
            _modifyDate = DateTime.Now;
        }

        protected void insertSlamBKUsersQuestions(Int32 sbId,Int32 QId)
        {
            con = getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand("insertSlamBKUserQuestion", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@slamBKId", SqlDbType.Int).Value = sbId;
            cmd.Parameters.Add("@userQId", SqlDbType.Int).Value = QId;
            cmd.Parameters.Add("@createdDate", SqlDbType.DateTime).Value = DateTime.Now;
            cmd.Parameters.Add("@modifyDate", SqlDbType.DateTime).Value = DateTime.Now;
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
        protected void insertSlamBKUsersNewQuestions(string question, Int32 userID, Int32 slamBKId)
        {
            con = getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand("insertSlamBKUsersNewQuestions", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Question", SqlDbType.VarChar, 100).Value = question.Trim();
            cmd.Parameters.Add("@userId", SqlDbType.Int).Value = userID;
            cmd.Parameters.Add("@slamBKId", SqlDbType.Int).Value = slamBKId;
            cmd.Parameters.Add("@createdDate", SqlDbType.DateTime).Value = DateTime.Now;
            cmd.Parameters.Add("@modifyDate", SqlDbType.DateTime).Value = DateTime.Now;
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
        protected void insertSlamBKData()
        {
            con = getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand("insertSlamData", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = userId;
            cmd.Parameters.Add("@slamBKName", SqlDbType.VarChar, 50).Value = slamBKName.Trim();
            cmd.Parameters.Add("@isQuestionTB", SqlDbType.Bit).Value = isQuestionTable;
            cmd.Parameters.Add("@titleMsg", SqlDbType.VarChar, 50).Value = titleMsg.Trim();
            cmd.Parameters.Add("@imageName", SqlDbType.VarChar, 50).Value = slambkImage.Trim();
            cmd.Parameters.Add("@createdDate", SqlDbType.DateTime).Value = createdDate;
            cmd.Parameters.Add("@modifyDate", SqlDbType.DateTime).Value = modifyDate;
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
        protected DataTable readSlamBase(Int32 id)
        {
            con = getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand("readSlamBkBase", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
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
        protected DataTable readQuestion()
        {
            con = getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand("readQuestions", con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
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
        protected DataSet readSlamBKUserQuestion(Int32 sbId)
        {
            con = getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand("readSlamBKQuestion", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@sbId", SqlDbType.Int).Value = sbId;            
            try
            {
                DataSet ds = new DataSet();            
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                return ds;
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
        protected DataSet readSlamBKUserQuestionEdit( Int32 sbId )
        {
            con = getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand("readSlamBKUserQuestEdit", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@sbId", SqlDbType.Int).Value = sbId;            
            DataSet ds = new DataSet();
            try
            {
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                return ds;
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
        protected void deleteSlamBKUserQuestion(Int32 sbid)
        {
            con = getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand("deleteSlamBKUserQuestion", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@sbid", SqlDbType.Int).Value = sbid;
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
        protected void deleteSlamBKUserNewQuestions(Int32 qid)
        {
            con = getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand("deleteSlamBKUSerNewQuestion", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@qid", SqlDbType.Int).Value = qid;
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
        protected DataTable viewSBReq(Int32 userId)
        {
            con = getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand("viewSlamBKReq", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@uid", SqlDbType.Int).Value = userId;
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
        protected void acceptSlamBKReq(Int32 userId, Int32 sbkId)
        {
            con = getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand("acceptSlamBKReq", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@userId", SqlDbType.Int).Value = userId;            
            cmd.Parameters.Add("@sbkId", SqlDbType.Int).Value = sbkId;
            cmd.Parameters.Add("@accept", SqlDbType.Bit).Value = true;
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
        protected void updateSBStatus(Int32 sbId)
        {
            con = getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand("updateSBStatus", con);
            cmd.CommandType = CommandType.StoredProcedure;            
            cmd.Parameters.Add("@sbId", SqlDbType.Int).Value = sbId;
            cmd.Parameters.Add("@accept", SqlDbType.Bit).Value = true;
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
        protected void denySlamBKReq(Int32 userId, Int32 sbkId)
        {
            con = getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand("denySlamBKReq", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@userId", SqlDbType.Int).Value = userId;
            cmd.Parameters.Add("@sbkId", SqlDbType.Int).Value = sbkId;
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
        protected bool checkSlamBKGen(Int32 uid)
        {
            con = getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand("checkSlamBKGen", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@uid", SqlDbType.Int).Value = uid;
            try
            {
                Int32 i = Convert.ToInt32(cmd.ExecuteScalar());
                if (i > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
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
        protected DataTable addSlamBKEntery(Int32 uid)
        {
            con = getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand("addSlamBKEntery", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@uid", SqlDbType.Int).Value = uid;
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
        protected DataTable readusersAnsQuestion(Int32 sbId,Int32 pno)
        {
            con = getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand("readusersAnsQuestion", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@sbId", SqlDbType.Int).Value = sbId;
            cmd.Parameters.Add("@pno", SqlDbType.Int).Value = pno;
            cmd.Parameters.Add("@ps", SqlDbType.Int).Value = 5;
            cmd.Parameters.Add("@total",SqlDbType.Int);
            cmd.Parameters["@total"].Direction = ParameterDirection.Output;
            DataTable dt = new DataTable();
            try
            {
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dt.Load(dr);
                _totalRows = Convert.ToInt32(cmd.Parameters["@total"].Value);
                return dt;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
        }
        protected DataTable readslamBKDetail(Int32 sbid)
        {
            con = getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand("readslamBKDetail", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("sbid", SqlDbType.Int).Value = sbid;
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
        protected void insertUserAnswer(Int32 sbId, Int32 qid, Int32 uid, string ans)
        {
            con = getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand("insertUsersAnswers", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@slamBKId", SqlDbType.Int).Value = sbId;
            cmd.Parameters.Add("@questionId", SqlDbType.Int).Value = qid;
            cmd.Parameters.Add("@userId", SqlDbType.Int).Value = uid;
            cmd.Parameters.Add("@answer", SqlDbType.VarChar, 200).Value = ans.Trim();
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
        protected DataTable readSlamBKUserQuestionAns(Int32 sbid, Int32 uid, Int32 pno)
        {
            con = getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand("readSlamBKUserQuestion", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@sbid", SqlDbType.Int).Value = sbid;
            cmd.Parameters.Add("@uid", SqlDbType.Int).Value = uid;
            cmd.Parameters.Add("@pno", SqlDbType.Int).Value = pno;
            cmd.Parameters.Add("@psize", SqlDbType.Int).Value = 5;
            cmd.Parameters.Add("@rowCount", SqlDbType.Int);
            cmd.Parameters["@rowCount"].Direction = ParameterDirection.Output;
            DataTable dt = new DataTable();
            try
            {
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dt.Load(dr);
                _totalRows = Convert.ToInt32(cmd.Parameters["@rowCount"].Value);
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
        protected void updateSlamBookVisitor(Int32 sbid, Int32 uid)
        {
            con = getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand("updateSlamBookVisitor", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@sbid", SqlDbType.Int).Value = sbid;
            cmd.Parameters.Add("@uid", SqlDbType.Int).Value = uid;
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
        protected DataTable listRecentUpdatesByFriend(Int32 sbid)
        {
            con = getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand("listRecentUpdatesByFriend", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@sbid", SqlDbType.Int).Value = sbid;
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
