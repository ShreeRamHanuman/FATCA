using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.IO;
using FATCA.DLL;
using System.Data.OleDb;
namespace FATCA.BLL
{
    public static class ExceptionManagerClass
    {
        /// <summary>
        /// All exceptions are catched from this page, and exception are 
        /// written in notepad file and, MDB Access database
        /// </summary>
        /// <param name="path"></param>
        /// <param name="errorMessage"></param>
        public static void AppendLog(string path, string errorMessage)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("  MetLife Alico, Nepal,, FATCA");
                sb.AppendLine("  ERROR OCCOUR ON DATE : " +DateTime.Now);
                sb.AppendLine("  USER NAME : " + UserInfoBO.userName);
                sb.AppendLine("  ERROR MESSAGE : " + errorMessage);
                sb.AppendLine("  ERROR PATH :: " + path);
                sb.AppendLine("------------------------------------------------------------------------------------ END --------------------------------------------------------------------------------------------");


                StreamWriter sw = File.AppendText(@"D:FATCA\Error.txt");
                sw.WriteLine(sb);
                sw.Close();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static void IsCorrect(string trueOrFalse)
        {
            StringBuilder sb = new StringBuilder();

        }

        public static void UpdateExceptionInMDB()
        {
            String connect = DbConClass.ConnectionStringMDB;
            OleDbConnection con = new OleDbConnection(connect);
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            con.Close();
            con.Open();
            cmd.CommandText = "Update LastState SET stateValue ='0' where stateValue ='1'";
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
