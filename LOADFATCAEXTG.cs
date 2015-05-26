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
    public partial class LOADFATCAEXTG : Form
    {
        public LOADFATCAEXTG()
        {
            InitializeComponent();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void LOADFATCAEXTG_Load(object sender, EventArgs e)
        {
            //dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            //dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            dataGridFatcaInScopePolicy.Visible = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string dt1 = PreApendSpaces.PrependSpaces(20, dateTimePicker1.Text);
            //string dt2 = PreApendSpaces.PrependSpaces(20, dateTimePicker2.Text);


            ImportToMsSql objimp = new ImportToMsSql();
            objimp.FatcaInScopePolicy();

            fatcaDAL objFatc = new fatcaDAL();
            DataSet dt = new DataSet();
            dt = objFatc.FatcaInScopePolicy();
            dataGridFatcaInScopePolicy.DataSource = dt;
            dataGridFatcaInScopePolicy.DataMember = dt.Tables[0].TableName;

            ExcelCreatorClass obj = new ExcelCreatorClass();
            string pathOfDownloadedFile = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "FATCA InScopePolicy.xlsx");

            obj.ExcelCreatorFxn(dataGridFatcaInScopePolicy, pathOfDownloadedFile);
        }

        private void btnViewFATCAInscopePolicy_Click(object sender, EventArgs e)
        {
            

            ImportToMsSql objimp = new ImportToMsSql();
            objimp.FatcaInScopePolicy();

            fatcaDAL objFatc = new fatcaDAL();
            DataSet dt = new DataSet();
            dt = objFatc.FatcaInScopePolicy();
            dataGridFatcaInScopePolicy.DataSource = dt;
            dataGridFatcaInScopePolicy.DataMember = dt.Tables[0].TableName;

            dataGridFatcaInScopePolicy.Visible = true;
        }
    }
}
