using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
////using System.Threading.Tasks;
using System.Windows.Forms;
using FATCA.BLL;
using FATCA.DLL;
namespace FATCA
{
    public partial class FATCAEXTG1M : Form
    {
        public FATCAEXTG1M()
        {
            InitializeComponent();
        }

        private void FATCAEXTG1M_Load(object sender, EventArgs e)
        {
            dataGridFatcaInscope.Visible = false;
            
        }

        private void btnDownloadEXtScope_Click(object sender, EventArgs e)
        {

            string year = PreApendSpaces.PrependSpaces(20, nmUpDownYear.ToString());
            ImportToMsSql objimp = new ImportToMsSql();
            objimp.FatcaExt1MilUSDYearly(year);


            dataGridFatcaInscope.Visible = false;
            fatcaDAL obj = new fatcaDAL();
            DataSet dt = new DataSet();

            dt = obj.FatcaExt1MilUSDYearly(year);
            dataGridFatcaInscope.DataSource = dt;
            dataGridFatcaInscope.DataMember = dt.Tables[0].TableName;

            ExcelCreatorClass objxl = new ExcelCreatorClass();
            string pathOfDownloadedFile = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "FATCA 1 Million USD.xlsx");

            objxl.ExcelCreatorFxn(dataGridFatcaInscope, pathOfDownloadedFile);
        }

        private void btnViewFatcaInScopePolicy_Click(object sender, EventArgs e)
        {
            string year = PreApendSpaces.PrependSpaces(20, nmUpDownYear.ToString());
            ImportToMsSql objimp = new ImportToMsSql();
            objimp.FatcaExt1MilUSDYearly(year);

            fatcaDAL obj = new fatcaDAL();
            DataSet dt = new DataSet();

            dt = obj.FatcaExt1MilUSDYearly(year);
            dataGridFatcaInscope.DataSource = dt;
            dataGridFatcaInscope.DataMember = dt.Tables[0].TableName;


            dataGridFatcaInscope.Visible = true;
        }
    }
}
