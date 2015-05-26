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
    public partial class FATCACHANGE : Form
    {
        public FATCACHANGE()
        {
            InitializeComponent();
        }


        private void DD_Click(object sender, EventArgs e)
        {

        }

        private void btnDownloadFATCACHANGE_Click(object sender, EventArgs e)
        {
            string dtPick1 = PreApendSpaces.PrependSpaces(20, dateTimePicker1.Text);
            string dtPick2 = PreApendSpaces.PrependSpaces(20, dateTimePicker2.Text);
            ImportToMsSql obj1 = new ImportToMsSql();
            obj1.FatcaChangePolicyByDate(dtPick1, dtPick2); // Retriving the data from Databse IBM
            dataGridFatcaChangePolicy.Visible = false;


            fatcaDAL obj = new fatcaDAL();
            DataSet ds = new DataSet();
            ds = obj.FatcaChangePolicyByDate(dtPick1, dtPick2);
            dataGridFatcaChangePolicy.DataSource = ds;
            dataGridFatcaChangePolicy.DataMember = ds.Tables[0].TableName;// loading data to the Dataview and downolad data same in all form
            ExcelCreatorClass objXl = new ExcelCreatorClass();
            string pathOfDownloadedFile = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "FATCA Change.xlsx");
           
            objXl.ExcelCreatorFxn(dataGridFatcaChangePolicy, pathOfDownloadedFile);
        }

        private void vtnViewFatcaChange_Click(object sender, EventArgs e)
        {

            string dtPick1 = PreApendSpaces.PrependSpaces(20, dateTimePicker1.Text);
            string dtPick2 = PreApendSpaces.PrependSpaces(20, dateTimePicker2.Text);
            ImportToMsSql obj1 = new ImportToMsSql();
            obj1.FatcaChangePolicyByDate(dtPick1, dtPick2);

            fatcaDAL obj = new fatcaDAL();
            DataSet ds = new DataSet();
            ds = obj.FatcaChangePolicyByDate(dtPick1, dtPick2);
            dataGridFatcaChangePolicy.DataSource = ds;
            dataGridFatcaChangePolicy.DataMember = ds.Tables[0].TableName;
            dataGridFatcaChangePolicy.Visible = true;
        }

        private void FATCACHANGE_Load(object sender, EventArgs e)
        {

            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            dataGridFatcaChangePolicy.Visible = false;

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
