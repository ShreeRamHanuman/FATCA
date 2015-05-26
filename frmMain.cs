using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using FATCA.BLL;
using System.IO;
using IBM.Data.DB2;
using ADOX;
using System.Data.OleDb;
using FATCA.DLL;
namespace FATCA
{
    public partial class frmMain : Form
    {
        int checkState;
        public frmMain()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //fatca class
            new frmFatcaClass().ShowDialog();
        }

        private void btnDataEligPolicy_Click(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {
            new frmChangePassword().ShowDialog();
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            new frmChangePassword().ShowDialog();
        }

        private void btnDataEligPolicy_MouseClick(object sender, MouseEventArgs e)
        {
            new dataEligliPolicy().ShowDialog();
        }

        private void btnDocExpiry_Click(object sender, EventArgs e)
        {
            new frmFataCureDocExpiry().ShowDialog();
        }

        private void btnPolicyChange_Click(object sender, EventArgs e)
        {
            new frmDataChange().ShowDialog();
        }

        private void btnDataDowmload_Click(object sender, EventArgs e)
        {
            new frmDataDownload().ShowDialog();
        }

        private void btnDataEligPolicy_Click_1(object sender, EventArgs e)
        {

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
          //  MessageBox.Show("Do you want to close the application");
           // e.Cancel = true;
            UserManagerClass objUser = new UserManagerClass();
            objUser.UpdateLastUseDate(DateTime.Now.ToString(), UserInfoBO.userName.ToString());
            Environment.Exit(0);
        }




        private void frmMain_Load(object sender, EventArgs e)
        {



            lblWelcomeUser.Text = "Welcome User:  " + UserInfoBO.userName.ToString();
            lblLastAccessed.Text = "Last Used On:  " + UserInfoBO.LastAccessed.ToString();
            string errorFile = @"D:\FATCA\Error.txt";
            if (File.Exists(errorFile))
            {
                // this variable is for checking the Last State of the Program
                // string reader = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "LastState.txt");
                //   int checkState = Convert.ToInt32(reader);
                //  MessageBox.Show(checkState);
                String connect = DbConClass.ConnectionStringMDB;
                OleDbConnection con = new OleDbConnection(connect);
                con.Open();
                OleDbCommand cmd = con.CreateCommand();

                cmd.CommandText = "Select*from LastState";
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    checkState = Convert.ToInt32(dr.GetValue(0).ToString());
                    
                }
                con.Close();

                if (checkState == 0)
                {
                    MessageBox.Show("Application has encountered Error, Please Contace IT Dept", "Error");
                    Application.Exit();
                }

            }
            else
            {

                File.Create(@"D:\FATCA\Error.txt");
                //File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "LastState.txt", "1");

                ADOX.Catalog catalog = new ADOX.Catalog();
                string connectionStringAccess = DbConClass.ConnectionStringMDB;
                catalog.Create(connectionStringAccess);
                catalog = null;
                //  if (catalog == null) { MessageBox.Show("db created"); }


                String connect = connectionStringAccess;
                OleDbConnection con = new OleDbConnection(connect);
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandText = "CREATE TABLE LastState (stateValue CHAR(4))";//, CustomerName VARCHAR(25), Address "
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO LastState VALUES (1)";
                cmd.ExecuteNonQuery();
                con.Close();

            }

            try
            {
                //int a = 5;
                //int b = 0;
                //int c = a / b; // test check of the exception,, no use of this try and catch,, for check purpose

            }
            catch (Exception ex)
            {
                ExceptionManagerClass.AppendLog(ex.StackTrace, ex.Message);
                ExceptionManagerClass.UpdateExceptionInMDB();
                MessageBox.Show("Oops!!, we got some error, Please Contact It Dept", "Error");
                Application.Exit();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            new dataEligliPolicy().ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            new frmFataCureDocExpiry().ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            new frmFatcaClass().ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            new frmDataChange().ShowDialog();
        }

    }
}
