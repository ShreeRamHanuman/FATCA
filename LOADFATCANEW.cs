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
    public partial class LOADFATCANEW : Form
    {
        public LOADFATCANEW()
        {
            InitializeComponent();
        }

        private void LOADFATCANEW_Load(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";

            dataGridFatcaNewPolicy.Visible = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dt1 = PreApendSpaces.PrependSpaces(20,dateTimePicker1.Text);
            string dt2 = PreApendSpaces.PrependSpaces(20, dateTimePicker2.Text);

            ImportToMsSql objImp =new ImportToMsSql();
            objImp.FatcaNewPolicy(dt1,dt2);

            fatcaDAL objFat = new fatcaDAL();
            DataSet dt = new DataSet();
            dt = objFat.FatcaNewPolicy(dt1,dt2);
            dataGridFatcaNewPolicy.DataSource = dt;
            dataGridFatcaNewPolicy.DataMember = dt.Tables[0].TableName;

            ExcelCreatorClass obj = new ExcelCreatorClass();
            string pathOfDownloadedFile = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "FATCA New Policy.xlsx");

            obj.ExcelCreatorFxn(dataGridFatcaNewPolicy, pathOfDownloadedFile);
        }

        private void btnViewFatcaNewPolicy_Click(object sender, EventArgs e)
        {
            string dt1 = PreApendSpaces.PrependSpaces(20, dateTimePicker1.Text);
            string dt2 = PreApendSpaces.PrependSpaces(20, dateTimePicker2.Text);

            ImportToMsSql objImp = new ImportToMsSql();
            objImp.FatcaNewPolicy(dt1, dt2);

            fatcaDAL objFat = new fatcaDAL();
            DataSet dt = new DataSet();
            dt = objFat.FatcaNewPolicy(dt1, dt2);
            dataGridFatcaNewPolicy.DataSource = dt;
            dataGridFatcaNewPolicy.DataMember = dt.Tables[0].TableName;

            dataGridFatcaNewPolicy.Visible = true;
        }
    }
}
