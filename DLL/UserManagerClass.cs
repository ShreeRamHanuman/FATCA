using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using IBM.Data.DB2.iSeries;
namespace FATCA.DLL
{
    public class UserManagerClass
    {
        SqlConnection con = new SqlConnection(DbConClass.ConnectionString); // Sql Connection from DbConClass,
        /// <summary>
        /// for checking user name and pasword,, Validation part
        /// </summary>
        /// <returns></returns>
        public DataTable GetUserInfo()
        {
            SqlCommand cmd = new SqlCommand("Select * from PASS_USER", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            if (dr.HasRows)
            {
                dt.Load(dr);
            }
            return dt;
        }



        public DataTable CheckUser(string userName, string password)
        {
            DataTable dt = new DataTable();
            string cmdCheckUserPwd = @"Select * from PASS_USER where User_Name ='" + userName + "' AND User_Password='" + password + "'";
            SqlCommand cmd = new SqlCommand(cmdCheckUserPwd, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
          
            if (dr.HasRows)
            {
                dt.Load(dr);
            }
            return dt;
        }

        public int ChangePassword(string userName, string password, string newPassword, string confirmPassword)
        {
            string cmdCheckUserPwd = @"Select * from PASS_USER where User_Name ='" + userName + "' AND User_Password='" + password + "'";
            SqlCommand cmd = new SqlCommand(cmdCheckUserPwd, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                if (newPassword == confirmPassword)
                {
                    con.Close();

                    SqlCommand cmdUpdate = new SqlCommand("update PASS_USER set User_Password='" + newPassword + "' Where User_Name='" + userName + "' ", con);
                    con.Open();
                    int result = cmdUpdate.ExecuteNonQuery();
                }
                else
                {
                    return 0;
                }
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public void UpdateLastUseDate(string date, string currentUser)
        {
            con.Close();
            SqlCommand cmdUpdate = new SqlCommand("update PASS_USER set LastAccessed='" + date + "' Where User_Name='" + currentUser + "' ", con);
            con.Open();
            int result = cmdUpdate.ExecuteNonQuery();
            con.Close();
        }
    }
}
