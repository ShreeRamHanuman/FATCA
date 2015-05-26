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
    public partial class frmFataCureDocExpiry : Form
    {
        public frmFataCureDocExpiry()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnViewFatcaCure_Click(object sender, EventArgs e)
        {
            dgCureDocExp.Visible = true;
        }

        private void frmFataCureDocExpiry_Load(object sender, EventArgs e)
        {

            ImportToMsSql obj1 = new ImportToMsSql();
            obj1.FatcaCureDocExpiery();
            dgCureDocExp.Visible = false;
            

            fatcaDAL obj = new fatcaDAL();
            DataSet ds = new DataSet();
            ds = obj.FatcaCureDocExpiry();
            dgCureDocExp.DataSource = ds;
            dgCureDocExp.DataMember = ds.Tables[0].TableName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExcelCreatorClass obj = new ExcelCreatorClass();
            string pathOfDownloadedFile = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "FATCA Cure Doc Expiry.xlsx");
            obj.ExcelCreatorFxn(dgCureDocExp, pathOfDownloadedFile);
        }
    }
}
