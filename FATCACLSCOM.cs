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
    public partial class FATCACLSCOM : Form
    {
        public FATCACLSCOM()
        {
            InitializeComponent();
        }

        private void FATCACLSCOM_Load(object sender, EventArgs e)
        {
            dataGridFatcaCompliantPolicy.Visible = false;
            ImportToMsSql objimp = new ImportToMsSql();
            objimp.FatcaCompliantPolicy();

            fatcaDAL obj = new fatcaDAL();
            DataSet dt = new DataSet();
            dt = obj.FatcaComplaintPolicy();
            dataGridFatcaCompliantPolicy.DataSource = dt;
            dataGridFatcaCompliantPolicy.DataMember = dt.Tables[0].TableName;
        }

        private void btnDownloadCompliant_Click(object sender, EventArgs e)
        {
            ExcelCreatorClass obj = new ExcelCreatorClass();

            string pathOfDownloadedFile = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "FATCA Compliant.xlsx");

            obj.ExcelCreatorFxn(dataGridFatcaCompliantPolicy, pathOfDownloadedFile);
        }

        private void btnViewFatcaCompliantPolicy_Click(object sender, EventArgs e)
        {
            dataGridFatcaCompliantPolicy.Visible = true;
        }
    }
}
