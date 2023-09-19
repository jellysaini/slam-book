using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataBaseLayer
{
    public class connection
    {
        private SqlConnection conn;
        protected SqlConnection getConnection()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
            return conn;
        }
    }
}
