using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using IBM.Data.DB2.iSeries;
using System.Windows.Forms;
using System.IO;
using FATCA.BLL;
namespace FATCA.DLL
{
    public class fatcaDAL
    {
        public SqlDataAdapter da;
        public SqlCommandBuilder builder;
        public DataSet dsDept = new DataSet();
        DataSet ds;
        SqlCommand cmd;
        public string tableName = "importedTable";
        SqlConnection conDB = new SqlConnection(DbConClass.ConnectionString);// test for the ibm database
        /// <summary>
        /// this page is used to display data in the View part,, generally this page selects data from the SQL Server
        /// </summary>
        /// <returns></returns>
        public DataSet GetFatcaIBM()
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = "Select * from LLBFATCA";
                ds = new DataSet();
                conDB.Open();
                this.da = new SqlDataAdapter(cmd.CommandText, conDB); // Disconnected mode..
                builder = new SqlCommandBuilder(this.da);
                this.da.Fill(ds, tableName);
                conDB.Close();
            }
            catch (Exception ex)
            {
                ExceptionManagerClass.AppendLog(ex.StackTrace, ex.Message);
               // File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "LastState.txt", "0");
                ExceptionManagerClass.UpdateExceptionInMDB();
                MessageBox.Show("Oops!!, we got some error, Please Contact It Dept", "Error");
                Application.Exit();
            }
            return ds;
        }

        public DataSet FatcaCureDocExpiry() // fatca cure doc expiry
        {
           
            cmd = new SqlCommand();
           DataSet dsFatcaCurDocExpiry = new DataSet();
           try
           {
            cmd.CommandText = "Select POLNUM,USINDCM,USINDCMDES,CUREDOCNO,CUREDOCNM,CUREDOCDT,FATCACLS FROM FATCACEXP ";
            conDB.Open();
            SqlDataAdapter daFatcaCureDocExpiry = new SqlDataAdapter(cmd.CommandText, conDB); // Disconnected mode..
            builder = new SqlCommandBuilder(daFatcaCureDocExpiry);
            daFatcaCureDocExpiry.Fill(dsFatcaCurDocExpiry, tableName);
            conDB.Close();
            }
            catch (Exception ex)
            {
                ExceptionManagerClass.AppendLog(ex.StackTrace, ex.Message);
              //  File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "LastState.txt", "0");
                ExceptionManagerClass.UpdateExceptionInMDB();
                MessageBox.Show("Oops!!, we got some error, Please Contact It Dept", "Error");
                Application.Exit();
            }
            return dsFatcaCurDocExpiry;
        }
        public DataSet FatcaChangePolicyByDate(string dtPick1, string dtPick2)
        {
            
            cmd = new SqlCommand();
            DataSet dsFatcaChangePolicyByDate = new DataSet();
            try
            {
                cmd.CommandText = "Select POLNUM,USINDCM,USINDCMD,BIRTHCOUN,RESICOUN1,RESICOUN2,RESICOUN3,CUREDOCNO,CUREDOCNM,CUREDOCDT,FATCAUPD,FATCACLS FROM FATCACHG  Where FATCAUPD  between '" + dtPick1 + "'  AND      '" + dtPick2 + "'";
                conDB.Open();
                SqlDataAdapter daFatcaChangePolicyByDate = new SqlDataAdapter(cmd.CommandText, conDB); // Disconnected mode..
                builder = new SqlCommandBuilder(daFatcaChangePolicyByDate);
                daFatcaChangePolicyByDate.Fill(dsFatcaChangePolicyByDate, tableName);
                conDB.Close();
            }
            catch (Exception ex)
            {
                ExceptionManagerClass.AppendLog(ex.StackTrace, ex.Message);
               // File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "LastState.txt", "0");
                ExceptionManagerClass.UpdateExceptionInMDB();
                MessageBox.Show("Oops!!, we got some error, Please Contact It Dept", "Error");
                Application.Exit();
            }
            return dsFatcaChangePolicyByDate;
        }

        public DataSet FatcaChangeByPolicyNumber(string policyNumber)
        {
            cmd = new SqlCommand();
            DataSet dsFatcaChangePolicyByDate = new DataSet();
            try
            {
                cmd.CommandText = "Select POLNUM,USINDCM,USINDCMD,BIRTHCOUN,RESICOUN1,RESICOUN2,RESICOUN3,CUREDOCNO,CUREDOCNM,CUREDOCDT,FATCACLS FROM FATCACHG where POLNUM = '" + policyNumber + "' ";
                conDB.Open();
                SqlDataAdapter daFatcaChangePolicyByDate = new SqlDataAdapter(cmd.CommandText, conDB); // Disconnected mode..
                builder = new SqlCommandBuilder(daFatcaChangePolicyByDate);
                daFatcaChangePolicyByDate.Fill(dsFatcaChangePolicyByDate, tableName);
                conDB.Close();
            }
            catch (Exception ex)
            {
                ExceptionManagerClass.AppendLog(ex.StackTrace, ex.Message);
               // File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "LastState.txt", "0");
                ExceptionManagerClass.UpdateExceptionInMDB();
                MessageBox.Show("Oops!!, we got some error, Please Contact It Dept", "Error");
                Application.Exit();
            }
            return dsFatcaChangePolicyByDate;
        }
        public DataSet FatcaWaitingPolicy()
        {
            cmd = new SqlCommand();
            DataSet dsFatcaWaitingPolicy = new DataSet();
            try
            {
                cmd.CommandText = "Select POLNUM,USINDCM,USINDCMDES,CUREDOCNO,CUREDOCNM,CUREDOCDT,FATCACLS FROM FATCACLS";
                conDB.Open();
                SqlDataAdapter daFatcaWaitingPolicy = new SqlDataAdapter(cmd.CommandText, conDB); // Disconnected mode..
                builder = new SqlCommandBuilder(daFatcaWaitingPolicy);
                daFatcaWaitingPolicy.Fill(dsFatcaWaitingPolicy, tableName);
                conDB.Close();
            }
            
            catch (Exception ex)
            {
                ExceptionManagerClass.AppendLog(ex.StackTrace, ex.Message);
             //   File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "LastState.txt", "0");
                ExceptionManagerClass.UpdateExceptionInMDB();
                MessageBox.Show("Oops!!, we got some error, Please Contact It Dept", "Error");
                Application.Exit();
            }
            return dsFatcaWaitingPolicy;
        }

        public DataSet FatcaComplaintPolicy()
        {
            cmd = new SqlCommand();
            DataSet dsFatcaComplaintPolicy = new DataSet();
            try
            {
                cmd.CommandText = "Select POLNUM,USINDCM,USINDCMDES,CUREDOCNO,CUREDOCNM,CUREDOCDT,FATCACLS FROM FATCACLS";
                conDB.Open();
                SqlDataAdapter daFatcaCompliantPolicy = new SqlDataAdapter(cmd.CommandText, conDB); // Disconnected mode..
                builder = new SqlCommandBuilder(daFatcaCompliantPolicy);
                daFatcaCompliantPolicy.Fill(dsFatcaComplaintPolicy, tableName);
                conDB.Close();
            }
            
            catch (Exception ex)
            {
                ExceptionManagerClass.AppendLog(ex.StackTrace, ex.Message);
              //  File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "LastState.txt", "0");
                ExceptionManagerClass.UpdateExceptionInMDB();
                MessageBox.Show("Oops!!, we got some error, Please Contact It Dept", "Error");
                Application.Exit();
            }
            return dsFatcaComplaintPolicy;
        }

        public DataSet FatcaNonComplaintPolicy()
        {
            cmd = new SqlCommand();
            DataSet dsFatcaNonComplaintPolicy = new DataSet();
            try{
            cmd.CommandText = "Select POLNUM,USINDCM,USINDCMDES,CUREDOCNO,CUREDOCNM,CUREDOCDT,FATCACLS FROM FATCACLS";
            conDB.Open();
            SqlDataAdapter daFatcaNonCompliantPolicy = new SqlDataAdapter(cmd.CommandText, conDB); // Disconnected mode..
            builder = new SqlCommandBuilder(daFatcaNonCompliantPolicy);
            daFatcaNonCompliantPolicy.Fill(dsFatcaNonComplaintPolicy, tableName);
            conDB.Close();
            }
            catch (Exception ex)
            {
                ExceptionManagerClass.AppendLog(ex.StackTrace, ex.Message);
             //   File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "LastState.txt", "0");
                ExceptionManagerClass.UpdateExceptionInMDB();
                MessageBox.Show("Oops!!, we got some error, Please Contact It Dept", "Error");
                Application.Exit();
            }
            return dsFatcaNonComplaintPolicy;
        }

        public DataSet FatcaUSPerson()
        {
            cmd = new SqlCommand();
            DataSet dsFatcaUSPerson = new DataSet();
            try{
            cmd.CommandText = "Select POLNUM,USINDCM,USINDCMDES,CUREDOCNO,CUREDOCNM,CUREDOCDT,FATCACLS FROM FATCACLS";
            conDB.Open();
            SqlDataAdapter daFatcaUSPerson = new SqlDataAdapter(cmd.CommandText, conDB); // Disconnected mode..
            builder = new SqlCommandBuilder(daFatcaUSPerson);
            daFatcaUSPerson.Fill(dsFatcaUSPerson, tableName);
            conDB.Close();
            }
            catch (Exception ex)
            {
                ExceptionManagerClass.AppendLog(ex.StackTrace, ex.Message);
             //   File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "LastState.txt", "0");
                ExceptionManagerClass.UpdateExceptionInMDB();
                MessageBox.Show("Oops!!, we got some error, Please Contact It Dept", "Error");
                Application.Exit();
            }
            return dsFatcaUSPerson;
        }

        public DataSet FatcaExt1MilUSDYearly(string Year)
        {
            cmd = new SqlCommand();
            DataSet dsFatcaUSPerson = new DataSet();
            try{
            cmd.CommandText = "Select POLNUM,PLOB,PLANCODE,STSCODE,CASHVALUE,CDATE FROM FATCAEXTG WHERE substring(CDATE,1,4) = '"+ Year+"'";
            conDB.Open();
            SqlDataAdapter daFatcaUSPerson = new SqlDataAdapter(cmd.CommandText, conDB); // Disconnected mode..
            builder = new SqlCommandBuilder(daFatcaUSPerson);
            daFatcaUSPerson.Fill(dsFatcaUSPerson, tableName);
            conDB.Close();
            }
            catch (Exception ex)
            {
                ExceptionManagerClass.AppendLog(ex.StackTrace, ex.Message);
             //   File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "LastState.txt", "0");
                ExceptionManagerClass.UpdateExceptionInMDB();
                MessageBox.Show("Oops!!, we got some error, Please Contact It Dept", "Error");
                Application.Exit();
            }
            return dsFatcaUSPerson;
        }

        public DataSet FatcaInScopePolicy()
        {
            cmd = new SqlCommand();
            DataSet dsFatcaUSPerson = new DataSet();
            try{
            cmd.CommandText = "Select POLNUM,PLOB,PLANCODE,STSCODE,CASHVALUE,CDATE FROM FATCAEXTG";
            conDB.Open();
            SqlDataAdapter daFatcaUSPerson = new SqlDataAdapter(cmd.CommandText, conDB); // Disconnected mode..
            builder = new SqlCommandBuilder(daFatcaUSPerson);
            daFatcaUSPerson.Fill(dsFatcaUSPerson, tableName);
            conDB.Close();
            }
            catch (Exception ex)
            {
                ExceptionManagerClass.AppendLog(ex.StackTrace, ex.Message);
             //   File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "LastState.txt", "0");
                ExceptionManagerClass.UpdateExceptionInMDB();
                MessageBox.Show("Oops!!, we got some error, Please Contact It Dept", "Error");
                Application.Exit();
            }
            return dsFatcaUSPerson;
        }

        public DataSet FatcaNewPolicy(string dt1, string dt2)
        {
            cmd = new SqlCommand();
            DataSet dsFatcaUSPerson = new DataSet();
            try{
            cmd.CommandText = "Select POLNUM,USINDCM,USINDCMDES,CDATE FROM FATCANEW where CDATE between '" + dt1 + "' and '" + dt2 + "'";
            conDB.Open();
            SqlDataAdapter daFatcaUSPerson = new SqlDataAdapter(cmd.CommandText, conDB); // Disconnected mode..
            builder = new SqlCommandBuilder(daFatcaUSPerson);
            daFatcaUSPerson.Fill(dsFatcaUSPerson, tableName);
            conDB.Close();
            }
            catch (Exception ex)
            {
                ExceptionManagerClass.AppendLog(ex.StackTrace, ex.Message);
              //  File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "LastState.txt", "0");
                ExceptionManagerClass.UpdateExceptionInMDB();
                MessageBox.Show("Oops!!, we got some error, Please Contact It Dept", "Error");
                Application.Exit();
            }
            return dsFatcaUSPerson;
        }

    }
}
