using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace FATCA
{
    public partial class frmErrorLogFile : Form
    {
        public frmErrorLogFile()
        {
            InitializeComponent();
        }

        private void frmErrorLogFile_Load(object sender, EventArgs e)
        {
            StreamReader sr = File.OpenText(@"D:\FATCA\Error.txt");
            rchTxtErrorLogFile.Text = sr.ReadToEnd();
            sr.Close();
        }
    }
}
