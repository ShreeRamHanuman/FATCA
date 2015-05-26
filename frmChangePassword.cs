using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using FATCA.DLL;
using FATCA.BLL;

namespace FATCA
{
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
           // UserInfoBO obj = new UserInfoBO();
            txtUserID.Text = UserInfoBO.userName.ToString();
            txtOldPassword.Text = UserInfoBO.password.ToString();
            txtNewPassword.Focus();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text.Trim().Length == 0)
            {
                MessageBox.Show("Blank and Spaces are not allowed in Password", "Error");
            }
            else
            {
                UserManagerClass obj = new UserManagerClass();

                int result = obj.ChangePassword(txtUserID.Text, txtOldPassword.Text, txtNewPassword.Text, txtConfirmPassword.Text);
                if (result > 0)
                {
                    MessageBox.Show("Password Change Successfully!!!!!!!!");
                    this.Close();
                }
                else
                    MessageBox.Show("Failld, New Password and Confirm Password didnot match");
            }
        }

        private void lblErrorMessageLog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmErrorLogFile errorLog = new frmErrorLogFile();
            errorLog.ShowDialog();
        }
    }
}
