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
    public partial class FATCAUS : Form
    {
        public FATCAUS()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FATCAUS_Load(object sender, EventArgs e)
        {
            dataGridFatcaUsPerson.Visible = false;

            ImportToMsSql objimp = new ImportToMsSql();
            objimp.FatcaUSPerson();
            
            fatcaDAL obj = new fatcaDAL();
            DataSet dt = new DataSet();
            dt = obj.FatcaUSPerson();
            dataGridFatcaUsPerson.DataSource = dt;
            dataGridFatcaUsPerson.DataMember = dt.Tables[0].TableName;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ExcelCreatorClass obj = new ExcelCreatorClass();
            string pathOfDownloadedFile = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "FATCA US Person.xlsx");

            obj.ExcelCreatorFxn(dataGridFatcaUsPerson, pathOfDownloadedFile);
        }

        private void btnViewFatcaUsPerson_Click(object sender, EventArgs e)
        {
            dataGridFatcaUsPerson.Visible = true;
        }
    }
}
