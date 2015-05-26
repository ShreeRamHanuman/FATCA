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
using FATCA.DLL;
namespace FATCA
{
    public partial class FATCACLS : Form
    {
        public FATCACLS()
        {
            InitializeComponent();
        }

        private void FATCACLS_Load(object sender, EventArgs e)
        {
            dataGridFATCAwaitingPolicy.Visible = false;
            ImportToMsSql objImport = new ImportToMsSql();
            objImport.FatcaWaitingPolicy();

            fatcaDAL obj = new fatcaDAL();
            DataSet dt = new DataSet();
            dt = obj.FatcaWaitingPolicy();
            dataGridFATCAwaitingPolicy.DataSource = dt;
            dataGridFATCAwaitingPolicy.DataMember = dt.Tables[0].TableName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExcelCreatorClass obj = new ExcelCreatorClass();
            string pathOfDownloadedFile = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "FATCA Waiting.xlsx");

            obj.ExcelCreatorFxn(dataGridFATCAwaitingPolicy, pathOfDownloadedFile);
        }

        private void btnViewFATCACLS_Click(object sender, EventArgs e)
        {
            dataGridFATCAwaitingPolicy.Visible = true;
        }
    }
}
