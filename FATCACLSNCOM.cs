using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
//////using System.Threading.Tasks;
using System.Windows.Forms;
using FATCA.BLL;
using FATCA.DLL;
namespace FATCA
{
    public partial class FATCACLSNCOM : Form
    {
        public FATCACLSNCOM()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FATCACLSNCOM_Load(object sender, EventArgs e)
        {
            dataGridFatcaNonComplient.Visible = false;
            ImportToMsSql objImport = new ImportToMsSql();
            objImport.FatcaNonCompliantPolicy();

            fatcaDAL obj = new fatcaDAL();
            DataSet dt = new DataSet();
            dt = obj.FatcaNonComplaintPolicy();
            dataGridFatcaNonComplient.DataSource = dt;
            dataGridFatcaNonComplient.DataMember = dt.Tables[0].TableName;
        }

        private void btnDownloadNONCOMPLIANT_Click(object sender, EventArgs e)
        {
            ExcelCreatorClass obj = new ExcelCreatorClass();
            string pathOfDownloadedFile = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "FATCA Non Compliant.xlsx");

            obj.ExcelCreatorFxn(dataGridFatcaNonComplient, pathOfDownloadedFile);
        }

        private void btnViewFatcaNonComp_Click(object sender, EventArgs e)
        {
            dataGridFatcaNonComplient.Visible = true;
        }
    }
}
