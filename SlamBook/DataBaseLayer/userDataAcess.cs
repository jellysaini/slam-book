using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace DataBaseLayer
{
    public class userDataAcess : connection
    {
        SqlConnection con;
        SqlCommand cmd;
        private Int32 _UserId;
        private string _EMail;
        private string _Password;
        private bool _Active;
        private string _FName;
        private string _LName;
        private DateTime _DateOfBirth;
        private string _Sex;
        private string _Address;
        private string _City;
        private string _state;
        private string _Country;
        private string _PinCode;
        private string _TelNo;
        private string _MobNo;
        private bool _IsOnline;
        private Int32 _SetStatus;
        private string _ImageName;
        private DateTime _CreatedDate;
        private DateTime _ModifyDate;

        protected Int32 UserId
        {
            get { return _UserId; }
        }
        protected string EMail
        {
            get { return _EMail; }
        }
        protected string Password
        {
            get { return _Password; }
        }
        protected bool Active
        {
            get { return _Active; }
        }
        protected string FirstName
        {
            get { return _FName; }
        }
        protected string LastName
        {
            get { return _LName; }
        }
        protected DateTime DateOfBirth
        {
            get { return _DateOfBirth; }
        }
        protected string Sex
        {
            get { return _Sex; }
        }
        protected string Address
        {
            get { return _Address; }
        }
        protected string City        
        {
            get { return _City; }
        }
        protected string State
        {
            get { return _state; }
        }
        protected string Country
        {
            get { return _Country; }
        }
        protected string PinCode
        {
            get { return _PinCode; }
        }
        protected string TelNo
        {
            get { return _TelNo; }
        }
        protected string MobNo
        {
            get { return _MobNo; }
        }
        protected string ImageName
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

        protected userDataAcess()
        { }
        protected userDataAcess(Int32 id)
        {
            _UserId = id;
        }
        protected userDataAcess(string email, string pass)
        {
            _EMail = email;
            _Password = pass;
        }
        protected userDataAcess(Int32 id, string em, string add, string city, string state, string country, string pin, string telno, string mobno)
        {
            _UserId = id;
            _EMail = em;
            _Address = add;
            _City = city;
            _state = state;
            _Country = country;
            _PinCode = pin;
            _TelNo = telno;
            _MobNo = mobno;
            _ModifyDate = DateTime.Now;
        }
        protected userDataAcess(string fname, string lname,string ImgName, bool isactive, string email, string pass, string dob, string gen, string add, string city, string state, string country, string pin)
        {
            _FName = fname;
            _LName = lname;
            _EMail = email;
            _ImageName = ImgName;
            _Password = pass;
            _Active = isactive;
            _DateOfBirth = Convert.ToDateTime (dob);
            _Sex = gen;
            _Address = add;
            _City = city;
            _state = state;
            _Country = country;
            _PinCode = pin;
            _CreatedDate = DateTime.Now;
            _ModifyDate = DateTime.Now;
        }       
        protected bool insertUserDate()
        {
            Int32 i;
            con = getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand("insertnewuser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@EMail", SqlDbType.VarChar, 50).Value = EMail.Trim();
            cmd.Parameters.Add("@Password", SqlDbType.VarChar, 50).Value = Password.Trim();
            cmd.Parameters.Add("@imgName", SqlDbType.VarChar, 50).Value = ImageName.Trim();
            cmd.Parameters.Add("@Active", SqlDbType.Bit).Value = Active;
            cmd.Parameters.Add("@FirstName", SqlDbType.VarChar, 25).Value = FirstName.Trim();
            cmd.Parameters.Add("@LastName", SqlDbType.VarChar, 25).Value = LastName.Trim();
            cmd.Parameters.Add("@DateOfBirth", SqlDbType.DateTime).Value = DateOfBirth;
            cmd.Parameters.Add("@Sex", SqlDbType.VarChar, 7).Value = Sex.Trim();
            cmd.Parameters.Add("@Address", SqlDbType.VarChar, 150).Value = Address.Trim();
            cmd.Parameters.Add("@City", SqlDbType.VarChar, 50).Value = City.Trim();
            cmd.Parameters.Add("@State", SqlDbType.VarChar, 50).Value = State.Trim();
            cmd.Parameters.Add("@Country", SqlDbType.VarChar, 50).Value = Country.Trim();
            cmd.Parameters.Add("@PinCode", SqlDbType.VarChar, 10).Value = PinCode.Trim();
            cmd.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = CreatedDate;
            cmd.Parameters.Add("@ModifyDate", SqlDbType.DateTime).Value = ModifyDate;
            try
            {
                i=cmd.ExecuteNonQuery();
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
        protected Int32 checkValidUser()
        {
            con = getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand("ValidUserPass", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@EMail", SqlDbType.VarChar, 50).Value = EMail.Trim();
            cmd.Parameters.Add("@Password", SqlDbType.VarChar, 50).Value = Password.Trim();
            SqlParameter P = new SqlParameter("@return", SqlDbType.Int);
            P.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(P);
            try
            {
                cmd.ExecuteNonQuery();
                Int32 i = Convert.ToInt32(cmd.Parameters["@return"].Value);
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
        protected DataSet getUserDetail()
        {
            con = getConnection();
            if (con.State == ConnectionState.Closed )
            {
                con.Open();
            }
            cmd = new SqlCommand("userDetail", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@EMail", SqlDbType.VarChar, 50).Value = EMail.Trim();
            cmd.Parameters.Add("@Password", SqlDbType.VarChar, 50).Value = Password.Trim();
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            try
            {
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
        protected DataTable getUserFriendDetail(Int32 id)
        {
            con = getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand("getUserFriendDetail", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;            
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
        protected DataTable getUserFriendList(Int32 userid,Int32 pn)
        {
            con = getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand("fwPagging", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = userid;
            cmd.Parameters.Add("@PageNumber", SqlDbType.Int).Value = pn;
            cmd.Parameters.Add("@PageSize", SqlDbType.Int).Value = 9;
            DataTable dt = new DataTable();             
            try
            {
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dt.Load(dr);
                dr.Dispose();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally 
            {
                
                con.Close();
            }
        }
        protected Int32 totalFriends(Int32 id)
        {
            con = getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand("totalFriend", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            try
            {
                Int32 i=Convert.ToInt32(cmd.ExecuteScalar());
                return (i);
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
        protected DataTable readUsers()
        {
            con = getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand("readUserDetail", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = UserId;
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
        protected void updateUsers()
        {
            con = getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand("updateUsers", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = UserId;
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = EMail.Trim();
            cmd.Parameters.Add("@add", SqlDbType.VarChar, 150).Value = Address.Trim();
            cmd.Parameters.Add("@city", SqlDbType.VarChar, 50).Value = City.Trim();
            cmd.Parameters.Add("@state", SqlDbType.VarChar, 50).Value = State.Trim();
            cmd.Parameters.Add("@country", SqlDbType.VarChar, 50).Value = Country.Trim();
            cmd.Parameters.Add("@pincode", SqlDbType.VarChar, 10).Value = PinCode.Trim();
            cmd.Parameters.Add("@telNo", SqlDbType.VarChar, 15).Value = TelNo.Trim();
            cmd.Parameters.Add("@mobNo", SqlDbType.VarChar, 15).Value = MobNo.Trim();
            cmd.Parameters.Add("@modifyDate", SqlDbType.DateTime).Value = ModifyDate;
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
        protected string forgetFetchPassword(string email)
        {
            string pass="";
            con = getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand("forgetFetchPassword", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = email;
            cmd.Parameters.Add("@pass", SqlDbType.VarChar, 50);
            cmd.Parameters["@pass"].Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@return", SqlDbType.Int);
            cmd.Parameters["@return"].Direction = ParameterDirection.Output;
            try
            {
                cmd.ExecuteNonQuery();
                if (Convert.ToInt32(cmd.Parameters["@return"].Value) != 0)
                {
                    pass = Convert.ToString(cmd.Parameters["@pass"].Value);
                }
                return pass;
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
        protected void uploadUserImage(Int32 id, string imgname)
        {
            con = getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand("uploadUserImage", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@imgName", SqlDbType.VarChar, 100).Value = "../UserImages/" + imgname;
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
