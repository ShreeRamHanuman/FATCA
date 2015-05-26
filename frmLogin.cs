using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using FATCA.BLL;
using FATCA.DLL;

namespace FATCA
{
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
           

        }




        private void btnLogin_Click(object sender, EventArgs e)
        {

            //try
            //{
                UserManagerClass obj = new UserManagerClass();
                DataTable dt = new DataTable();
                dt = obj.CheckUser(txtBoxUserName.Text, txtBoxPassword.Text);
                if (dt != null && dt.Rows.Count > 0)
                {
                    this.Hide(); // for hiding this form after checking username and password

                    // storing user info temporiraly for current user
                    UserInfoBO.userName = dt.Rows[0]["User_Name"].ToString();
                    UserInfoBO.password = dt.Rows[0]["User_Password"].ToString();
                    UserInfoBO.LastAccessed = dt.Rows[0]["LastAccessed"].ToString();
                    frmMain frmMain = new frmMain();
                    frmMain.ShowDialog();
                }
                else
                {
                    txtBoxUserName.Text = "";
                    txtBoxPassword.Text = "";
                    txtBoxUserName.Focus();
                    MessageBox.Show("Login Failled!!! ", "Error");
                }
            //}
            //catch (Exception ex)
            //{
            //    //ExceptionManagerClass.a
            //    ExceptionManagerClass.AppendLog(ex.StackTrace, ex.Message);
            //    MessageBox.Show(" Error!!  Contact IT Dept. Or Check error Log in Settings -> View Error Log", "Error Found!!!");
            //}


        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
          

            //fatcaBLL objFatcaBll = new fatcaBLL();
            //this.dataGridView1.DataSource = objFatcaBll.GetUserValidationData("DPOSMT","lifesuck1");
        }

        private void txtBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxPassword_TextChanged(object sender, KeyEventArgs e)
        {

        }

        private void txtBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    ActiveForm.AcceptButton = btnLogin;// when user press enter key in this field
                }
            }
            catch (Exception ex)
            {
                //ExceptionManagerClass.a
                ExceptionManagerClass.AppendLog(ex.StackTrace, ex.Message);
                MessageBox.Show(" Error!! Contact IT Dept. Or Check error Log in Settings -> View Error Log", "Error Found!!!");
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

    }
}
