using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using IBM.Data.DB2.iSeries;
using FATCA.BLL;
using System.Windows.Forms;
using System.IO;
namespace FATCA.DLL
{
    public class ImportToMsSql
    {
        /// <summary>
        /// this page is used to retrive data from the IBM Server and Insert into the MSSQL Server.
        /// </summary>


        iDB2Connection ConIBM = new iDB2Connection(DbConClass.ConnectionStringIBMDB2);

        public iDB2DataAdapter da;
        public iDB2CommandBuilder builder;

        public DataTable dsDept = new DataTable();
        public DataSet dsDeptSql = new DataSet();
        public string tableName = "importedTable";
        public SqlDataAdapter daSql;
        public SqlCommandBuilder builderSql;
        SqlConnection ConSQL = new SqlConnection(DbConClass.ConnectionString);



        public DataTable FatcaCureDocExpiery()
        {
            DataTable dt = new DataTable();
            string FATCACLASS = "Y";
            iDB2Command cmd = new iDB2Command("Select Distinct FTPOLNUM,FTUSINDC,FTUSINDCD,CUREDOCNO,CUREDOCNM,CUREDOCDT,FATCACLSTS FROM LMEVULPRNP.LLBFATCA where FATCACLSTS = '" + FATCACLASS + "'", ConIBM);

            try
            {
                ConIBM.Open();
            }
            catch
            {
                MessageBox.Show("IBMDB2 Con Failled!!");
            }

            try
            {
                using (SqlCommand cmdDel = new SqlCommand("Delete from FATCACEXP", ConSQL))
                {
                    ConSQL.Open();
                    cmdDel.ExecuteNonQuery();
                }

                iDB2DataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string ftpolnum = dr.GetValue(0).ToString();
                    string ftusindc = dr.GetValue(1).ToString();
                    string ftusindcd = dr.GetValue(2).ToString();
                    string curedocno = dr.GetValue(3).ToString();
                    string curedocnm = dr.GetValue(4).ToString();
                    string curedocdt = dr.GetValue(5).ToString();
                    string fatcaclsts = dr.GetValue(6).ToString();

                    using (SqlCommand cmdInsertFatcaCureDocExpiery = new SqlCommand("insert into FATCACEXP ( POLNUM,USINDCM,USINDCMDES,CUREDOCNO,CUREDOCNM,CUREDOCDT,FATCACLS)   values ('" + ftpolnum + "','" + ftusindc + "','" + ftusindcd + "','" + curedocno + "','" + curedocnm + "','" + curedocdt + "','" + fatcaclsts + "')", ConSQL))
                    {
                        ConSQL.Close();
                        ConSQL.Open();
                        cmdInsertFatcaCureDocExpiery.ExecuteNonQuery();
                        ConSQL.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionManagerClass.AppendLog(ex.StackTrace, ex.Message);
                // File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "LastState.txt", "0");
                ExceptionManagerClass.UpdateExceptionInMDB();
                MessageBox.Show("Oops!!, we got some error, Please Contact It Dept", "Error");
                Application.Exit();
            }
            return dt;
        }

        public DataTable FatcaChangePolicyByDate(string BGDateN, string BGDateN1)
        {

            iDB2Command cmd = new iDB2Command(("Select Distinct FTPOLNUM,FTUSINDC,FTUSINDCD,BIRTHCOUN,RESICOUN1,RESICOUN2,RESICOUN3,CUREDOCNO,CUREDOCNM,CUREDOCDT,FATCAUPD,FATCACLSTS from LMEVULPRNP.LLBFATCACH  Where FATCAUPD  between '" + BGDateN + "'  AND      '" + BGDateN1 + "'"), ConIBM);

            DataTable dt = new DataTable();
            try
            {
                ConIBM.Open();
            }
            catch
            {
                MessageBox.Show("IBMDB2 Con Failled!!");
            }
            try
            {
                using (SqlCommand cmdDel = new SqlCommand("delete from FATCACHG WHERE FATCAUPD between '" + BGDateN + "' AND  '" + BGDateN1 + "'", ConSQL))
                {
                    ConSQL.Open();
                    cmdDel.ExecuteNonQuery();
                }
                iDB2DataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    string SFTPOLNUM = dr.GetValue(0).ToString();
                    string SFTUSINDC = dr.GetValue(1).ToString();
                    string SFTUSINDCD = dr.GetValue(2).ToString();
                    string SBIRTHCOUN = dr.GetValue(3).ToString();
                    string SRESICOUN1 = dr.GetValue(4).ToString();
                    string SRESICOUN2 = dr.GetValue(5).ToString();
                    string SRESICOUN3 = dr.GetValue(6).ToString();
                    string CUREDOCNO = dr.GetValue(7).ToString();
                    string CUREDOCNM = dr.GetValue(8).ToString();
                    string CUREDOCDT = dr.GetValue(9).ToString();
                    string FATCAUPD = dr.GetValue(10).ToString();
                    string SFATCACLS = dr.GetValue(11).ToString();


                    using (SqlCommand cmdInsertFatcaCureDocExpiery = new SqlCommand("insert into FATCACHG (POLNUM,USINDCM,USINDCMD,BIRTHCOUN,RESICOUN1,RESICOUN2,RESICOUN3,CUREDOCNO,CUREDOCNM,CUREDOCDT,FATCAUPD,FATCACLS)  values  ('" + SFTPOLNUM + "','" + SFTUSINDC + "','" + SFTUSINDCD + "','" + SBIRTHCOUN + "','" + SRESICOUN1 + "','" + SRESICOUN2 + "','" + SRESICOUN3 + "','" + CUREDOCNO + "','" + CUREDOCNM + "','" + CUREDOCDT + "','" + FATCAUPD + "','" + SFATCACLS + "')", ConSQL))
                    {
                        ConSQL.Close();
                        ConSQL.Open();
                        cmdInsertFatcaCureDocExpiery.ExecuteNonQuery();
                        ConSQL.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionManagerClass.AppendLog(ex.StackTrace, ex.Message);
                // File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "LastState.txt", "0");
                ExceptionManagerClass.UpdateExceptionInMDB();
                MessageBox.Show("Oops!!, we got some error, Please Contact It Dept", "Error");
                Application.Exit();
            }
            return dt;
        }


        public DataTable FatcaChangePolicyByPolicyNumber(string policyNumber)
        {

            iDB2Command cmd = new iDB2Command("Select Distinct FTPOLNUM,FTUSINDC,FTUSINDCD,BIRTHCOUN,RESICOUN1,RESICOUN2,RESICOUN3,CUREDOCNO,CUREDOCNM,CUREDOCDT,FATCACLSTS FROM LMEVULPRNP.LLBFATCACH  where FTPOLNUM = '" + policyNumber + "'", ConIBM);
            DataTable dt = new DataTable();
            try
            {
                ConIBM.Open();
            }
            catch
            {
                MessageBox.Show("IBMDB2 Con Failled!!");
            }
            try
            {
                using (SqlCommand cmdDel = new SqlCommand("Delete from FATCACHG where POLNUM ='" + policyNumber + "' ", ConSQL))
                {
                    ConSQL.Open();
                    cmdDel.ExecuteNonQuery();
                }

                iDB2DataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string FTPOLNUM = dr.GetValue(0).ToString();
                    string FTUSINDC = dr.GetValue(1).ToString();
                    string FTUSINDCD = dr.GetValue(2).ToString();
                    string BIRTHCOUN = dr.GetValue(3).ToString();
                    string RESICOUN1 = dr.GetValue(4).ToString();
                    string RESICOUN2 = dr.GetValue(5).ToString();
                    string RESICOUN3 = dr.GetValue(6).ToString();
                    string CUREDOCNO = dr.GetValue(7).ToString();
                    string CUREDOCNM = dr.GetValue(8).ToString();
                    string CUREDOCDT = dr.GetValue(9).ToString();
                    string FATCACLSTS = dr.GetValue(10).ToString();


                    using (SqlCommand cmdInsertFatcaCureDocExpiery = new SqlCommand("insert into FATCACHG (POLNUM,USINDCM,USINDCMD,BIRTHCOUN,RESICOUN1,RESICOUN2,RESICOUN3,CUREDOCNO,CUREDOCNM,CUREDOCDT,FATCACLS) values ('" + FTPOLNUM + "','" + FTUSINDC + "','" + FTUSINDCD + "','" + BIRTHCOUN + "','" + RESICOUN1 + "','" + RESICOUN2 + "','" + RESICOUN3 + "','" + CUREDOCNO + "','" + CUREDOCNM + "','" + CUREDOCDT + "','" + FATCACLSTS + "')", ConSQL))
                    {
                        ConSQL.Close();
                        ConSQL.Open();
                        cmdInsertFatcaCureDocExpiery.ExecuteNonQuery();
                        ConSQL.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionManagerClass.AppendLog(ex.StackTrace, ex.Message);
                //    File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "LastState.txt", "0");
                ExceptionManagerClass.UpdateExceptionInMDB();
                MessageBox.Show("Oops!!, we got some error, Please Contact It Dept", "Error");
                Application.Exit();
            }
            return dt;
        }


        public DataTable FatcaWaitingPolicy()
        {
            string FATCACLASS = "W";
            iDB2Command cmd = new iDB2Command(("Select Distinct FTPOLNUM,FTUSINDC,FTUSINDCD,CUREDOCNO,CUREDOCNM,CUREDOCDT,FATCACLSTS FROM LMEVULPRNP.LLBFATCA Where FATCACLSTS = '" + FATCACLASS + "'"), ConIBM);

            DataTable dt = new DataTable();
            try
            {
                ConIBM.Open();
            }
            catch
            {
                MessageBox.Show("IBMDB2 Con Failled!!");
            }
            try
            {
                using (SqlCommand cmdDel = new SqlCommand("delete from FATCACLS", ConSQL))
                {
                    ConSQL.Open();
                    cmdDel.ExecuteNonQuery();
                }

                iDB2DataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    string POLICY = dr.GetValue(0).ToString();
                    string USINDC = dr.GetValue(1).ToString();
                    string USINDCD = dr.GetValue(2).ToString();
                    string CUREDOCNO = dr.GetValue(3).ToString();
                    string CUREDOCNM = dr.GetValue(4).ToString();
                    string CUREDOCDT = dr.GetValue(5).ToString();
                    string FATCACLS = dr.GetValue(6).ToString();


                    using (SqlCommand cmdInsertFatcaCureDocExpiery = new SqlCommand("insert into FATCACLS (POLNUM,USINDCM,USINDCMDES,CUREDOCNO,CUREDOCNM,CUREDOCDT,FATCACLS)  values('" + POLICY + "','" + USINDC + "','" + USINDCD + "','" + CUREDOCNO + "','" + CUREDOCNM + "','" + CUREDOCDT + "','" + FATCACLS + "'", ConSQL))
                    {
                        ConSQL.Close();
                        ConSQL.Open();
                        cmdInsertFatcaCureDocExpiery.ExecuteNonQuery();
                        ConSQL.Close();

                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionManagerClass.AppendLog(ex.StackTrace, ex.Message);
                //  File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "LastState.txt", "0");
                ExceptionManagerClass.UpdateExceptionInMDB();
                MessageBox.Show("Oops!!, we got some error, Please Contact It Dept", "Error");
                Application.Exit();
            }
            return dt;
        }

        public DataTable FatcaCompliantPolicy()
        {
            string FATCACLASS = "C";
            iDB2Command cmd = new iDB2Command("Select Distinct FTPOLNUM,FTUSINDC,FTUSINDCD,CUREDOCNO,CUREDOCNM,CUREDOCDT,FATCACLSTS FROM LMEVULPRNP.LLBFATCA  WHERE FATCACLSTS =  '" + FATCACLASS + "'", ConIBM);

            DataTable dt = new DataTable();
            try
            {
                ConIBM.Open();
            }
            catch
            {
                MessageBox.Show("IBMDB2 Con Failled!!");
            }
            try
            {
                using (SqlCommand cmdDel = new SqlCommand("delete from FATCACLS", ConSQL))
                {
                    ConSQL.Open();
                    cmdDel.ExecuteNonQuery();
                }

                iDB2DataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    string POLICY = dr.GetValue(0).ToString();
                    string USINDC = dr.GetValue(1).ToString();
                    string USINDCD = dr.GetValue(2).ToString();
                    string CUREDOCNO = dr.GetValue(3).ToString();
                    string CUREDOCNM = dr.GetValue(4).ToString();
                    string CUREDOCDT = dr.GetValue(5).ToString();
                    string FATCACLS = dr.GetValue(6).ToString();


                    using (SqlCommand cmdInsertFatcaCureDocExpiery = new SqlCommand("insert into FATCACLS (POLNUM,USINDCM,USINDCMDES,CUREDOCNO,CUREDOCNM,CUREDOCDT,FATCACLS)  values('" + POLICY + "','" + USINDC + "','" + USINDCD + "','" + CUREDOCNO + "','" + CUREDOCNM + "','" + CUREDOCDT + "','" + FATCACLS + "')", ConSQL))
                    {
                        ConSQL.Close();
                        ConSQL.Open();
                        cmdInsertFatcaCureDocExpiery.ExecuteNonQuery();
                        ConSQL.Close();

                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionManagerClass.AppendLog(ex.StackTrace, ex.Message);
                // File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "LastState.txt", "0");
                ExceptionManagerClass.UpdateExceptionInMDB();
                MessageBox.Show("Oops!!, we got some error, Please Contact It Dept", "Error");
                Application.Exit();
            }
            return dt;
        }

        public DataTable FatcaNonCompliantPolicy()
        {

            string FATCACLASS = "N";
            iDB2Command cmd = new iDB2Command("Select Distinct FTPOLNUM,FTUSINDC,FTUSINDCD,CUREDOCNO,CUREDOCNM,CUREDOCDT,FATCACLSTS FROM LMEVULPRNP.LLBFATCA WHERE FATCACLSTS =  '" + FATCACLASS + "'", ConIBM);

            DataTable dt = new DataTable();
            try
            {
                ConIBM.Open();
            }
            catch
            {
                MessageBox.Show("IBMDB2 Con Failled!!");
            }
            try
            {
                using (SqlCommand cmdDel = new SqlCommand("delete from FATCACLS", ConSQL))
                {
                    ConSQL.Open();
                    cmdDel.ExecuteNonQuery();
                }

                iDB2DataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    string POLICY = dr.GetValue(0).ToString();
                    string USINDC = dr.GetValue(1).ToString();
                    string USINDCD = dr.GetValue(2).ToString();
                    string CUREDOCNO = dr.GetValue(3).ToString();
                    string CUREDOCNM = dr.GetValue(4).ToString();
                    string CUREDOCDT = dr.GetValue(5).ToString();
                    string FATCACLS = dr.GetValue(6).ToString();


                    using (SqlCommand cmdInsertFatcaCureDocExpiery = new SqlCommand("insert into FATCACLS (POLNUM,USINDCM,USINDCMDES,CUREDOCNO,CUREDOCNM,CUREDOCDT,FATCACLS)  values('" + POLICY + "','" + USINDC + "','" + USINDCD + "','" + CUREDOCNO + "','" + CUREDOCNM + "','" + CUREDOCDT + "','" + FATCACLS + "')", ConSQL))
                    {
                        ConSQL.Close();
                        ConSQL.Open();
                        cmdInsertFatcaCureDocExpiery.ExecuteNonQuery();
                        ConSQL.Close();

                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionManagerClass.AppendLog(ex.StackTrace, ex.Message);
                //  File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "LastState.txt", "0");
                ExceptionManagerClass.UpdateExceptionInMDB();
                MessageBox.Show("Oops!!, we got some error, Please Contact It Dept", "Error");
                Application.Exit();
            }
            return dt;
        }

        public DataTable FatcaUSPerson()
        {

            string FATCACLASS = "U";
            iDB2Command cmd = new iDB2Command("Select Distinct FTPOLNUM,FTUSINDC,FTUSINDCD,CUREDOCNO,CUREDOCNM,CUREDOCDT,FATCACLSTS FROM LMEVULPRNP.LLBFATCA WHERE FATCACLSTS =  '" + FATCACLASS + "'", ConIBM);

            DataTable dt = new DataTable();
            try
            {
                ConIBM.Open();
            }
            catch
            {
                MessageBox.Show("IBMDB2 Con Failled!!");
            }
            try
            {
                using (SqlCommand cmdDel = new SqlCommand("delete from FATCACLS", ConSQL))
                {
                    ConSQL.Open();
                    cmdDel.ExecuteNonQuery();
                }

                iDB2DataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    string POLICY = dr.GetValue(0).ToString();
                    string USINDC = dr.GetValue(1).ToString();
                    string USINDCD = dr.GetValue(2).ToString();
                    string CUREDOCNO = dr.GetValue(3).ToString();
                    string CUREDOCNM = dr.GetValue(4).ToString();
                    string CUREDOCDT = dr.GetValue(5).ToString();
                    string FATCACLS = dr.GetValue(6).ToString();
                    using (SqlCommand cmdInsertFatcaCureDocExpiery = new SqlCommand("insert into FATCACLS (POLNUM,USINDCM,USINDCMDES,CUREDOCNO,CUREDOCNM,CUREDOCDT,FATCACLS)  values('" + POLICY + "','" + USINDC + "','" + USINDCD + "','" + CUREDOCNO + "','" + CUREDOCNM + "','" + CUREDOCDT + "','" + FATCACLS + "')", ConSQL))
                    {
                        ConSQL.Close();
                        ConSQL.Open();
                        cmdInsertFatcaCureDocExpiery.ExecuteNonQuery();
                        ConSQL.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionManagerClass.AppendLog(ex.StackTrace, ex.Message);
                // File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "LastState.txt", "0");
                ExceptionManagerClass.UpdateExceptionInMDB();
                MessageBox.Show("Oops!!, we got some error, Please Contact It Dept", "Error");
                Application.Exit();
            }
            return dt;
        }

        public DataTable FatcaExt1MilUSDYearly(string Year)// FATCAEXTG1 not found
        {

            iDB2Command cmd = new iDB2Command("Select Distinct POLNUM,PLOB,PLANCODE,STSCODE,CVNEXT FROM LMEVULPRNP.FATCAEXTG1 where substring(CDATE,1,4) = '" + Year + "'", ConIBM);

            DataTable dt = new DataTable();
            try
            {
                ConIBM.Open();
            }
            catch
            {
                MessageBox.Show("IBMDB2 Con Failled!!");
            }
            try
            {
                using (SqlCommand cmdDel = new SqlCommand("delete from FATCAEXTG", ConSQL))
                {
                    ConSQL.Open();
                    cmdDel.ExecuteNonQuery();
                }

                iDB2DataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    string POLICY = dr.GetValue(0).ToString();
                    string PLOB = dr.GetValue(1).ToString();
                    string PLANCODE = dr.GetValue(2).ToString();
                    string STSCODE = dr.GetValue(3).ToString();
                    string CVNEXT = dr.GetValue(4).ToString();
                    string CDATE1 = "dt";


                    using (SqlCommand cmdInsertFatcaCureDocExpiery = new SqlCommand("insert into FATCAEXTG (POLNUM,PLOB,PLANCODE,STSCODE,CASHVALUE,CDATE)  values('" + POLICY + "','" + PLOB + "','" + PLANCODE + "','" + STSCODE + "','" + CVNEXT + "','" + CDATE1 + "')", ConSQL))
                    {
                        ConSQL.Close();
                        ConSQL.Open();
                        cmdInsertFatcaCureDocExpiery.ExecuteNonQuery();
                        ConSQL.Close();

                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionManagerClass.AppendLog(ex.StackTrace, ex.Message);
                // File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "LastState.txt", "0");
                ExceptionManagerClass.UpdateExceptionInMDB();
                MessageBox.Show("Oops!!, we got some error, Please Contact It Dept", "Error");
                Application.Exit();
            }
            return dt;
        }

        public DataTable FatcaInScopePolicy() // FATCAEXTG not found
        {

            iDB2Command cmd = new iDB2Command("Select Distinct POLNUM,PLOB,PLANCODE,STSCODE,CVNEXT FROM LMEVULPRNP.FATCAEXTG", ConIBM);

            DataTable dt = new DataTable();
            try
            {
                ConIBM.Open();
            }
            catch
            {
                MessageBox.Show("IBMDB2 Con Failled!!");
            }
            try
            {
                using (SqlCommand cmdDel = new SqlCommand("delete from FATCAEXTG", ConSQL))
                {
                    ConSQL.Open();
                    cmdDel.ExecuteNonQuery();
                }

                iDB2DataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    string POLICY = dr.GetValue(0).ToString();
                    string PLOB = dr.GetValue(1).ToString();
                    string PLANCODE = dr.GetValue(2).ToString();
                    string STSCODE = dr.GetValue(3).ToString();
                    string CVNEXT = dr.GetValue(4).ToString();
                    string CDATE1 = "dt";

                    using (SqlCommand cmdInsertFatcaCureDocExpiery = new SqlCommand("insert into FATCAEXTG (POLNUM,PLOB,PLANCODE,STSCODE,CASHVALUE,CDATE)  values('" + POLICY + "','" + PLOB + "','" + PLANCODE + "','" + STSCODE + "','" + CVNEXT + "','" + CDATE1 + "')", ConSQL))
                    {
                        ConSQL.Close();
                        ConSQL.Open();
                        cmdInsertFatcaCureDocExpiery.ExecuteNonQuery();
                        ConSQL.Close();

                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionManagerClass.AppendLog(ex.StackTrace, ex.Message);
                // File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "LastState.txt", "0");
                ExceptionManagerClass.UpdateExceptionInMDB();
                MessageBox.Show("Oops!!, we got some error, Please Contact It Dept", "Error");
                Application.Exit();
            }
            return dt;
        }


        public DataTable FatcaNewPolicy(string dt1, string dt2)
        {

            iDB2Command cmd = new iDB2Command("Select Distinct FTPOLNUM,FTUSINDC,FTUSINDCD,FATCACDT FROM LMEVULPRNP.LLBFATCA where FATCACDT between '" + dt1 + "'  AND      '" + dt2 + "'", ConIBM);

            DataTable dt = new DataTable();
            try
            {
                ConIBM.Open();
            }
            catch
            {
                MessageBox.Show("IBMDB2 Con Failled!!");
            }
            try
            {
                using (SqlCommand cmdDel = new SqlCommand("delete from FATCANEW", ConSQL))
                {
                    ConSQL.Open();
                    cmdDel.ExecuteNonQuery();
                }

                iDB2DataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    string POLICY = dr.GetValue(0).ToString();
                    string USINDCM = dr.GetValue(1).ToString();
                    string USINDCMDES = dr.GetValue(2).ToString();
                    string CDATE1 = dr.GetValue(3).ToString();

                    using (SqlCommand cmdInsertFatcaCureDocExpiery = new SqlCommand("insert into FATCANEW (POLNUM,USINDCM,USINDCMDES,CDATE)  values('" + POLICY + "','" + USINDCM + "','" + USINDCMDES + "','" + CDATE1 + "')", ConSQL))
                    {
                        ConSQL.Close();
                        ConSQL.Open();
                        cmdInsertFatcaCureDocExpiery.ExecuteNonQuery();
                        ConSQL.Close();

                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionManagerClass.AppendLog(ex.StackTrace, ex.Message);
                //   File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "LastState.txt", "0");
                ExceptionManagerClass.UpdateExceptionInMDB();
                MessageBox.Show("Oops!!, we got some error, Please Contact It Dept", "Error");
                Application.Exit();
            }
            return dt;
        }
    }
}
