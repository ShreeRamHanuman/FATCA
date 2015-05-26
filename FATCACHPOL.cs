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
    public partial class FATCACHPOL : Form
    {
        public FATCACHPOL()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FATCACHPOL_Load(object sender, EventArgs e)
        {
            dataGridFATCAchangePolicy.Visible = false;


        }

        private void btnDownloadPolicy_Click(object sender, EventArgs e)
        {
            if (btnDownloadPolicy.Text.Trim().Length == 0)
            {
                MessageBox.Show("Blank and Spaces are not allowed in Password", "Error");
            }
            else
            {
                string Policy = PreApendSpaces.PrependSpaces(10, txtBoxPolicyNumber.Text);
                ImportToMsSql obj1 = new ImportToMsSql();
                obj1.FatcaChangePolicyByPolicyNumber(Policy);

                fatcaDAL obj = new fatcaDAL();
                DataSet dt = new DataSet();
                dt = obj.FatcaChangeByPolicyNumber(Policy);
                dataGridFATCAchangePolicy.DataSource = dt;
                dataGridFATCAchangePolicy.DataMember = dt.Tables[0].TableName;

                ExcelCreatorClass obj2 = new ExcelCreatorClass();
                string pathOfDownloadedFile = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "FATCA ChangePolicy.xlsx");

                obj2.ExcelCreatorFxn(dataGridFATCAchangePolicy, pathOfDownloadedFile);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (btnDownloadPolicy.Text.Trim().Length == 0)
            {
                MessageBox.Show("Blank and Spaces are not allowed in Password", "Error");
            }
            else
            {
                string Policy = PreApendSpaces.PrependSpaces(10, txtBoxPolicyNumber.Text);
                ImportToMsSql obj1 = new ImportToMsSql();
                obj1.FatcaChangePolicyByPolicyNumber(txtBoxPolicyNumber.Text);

                fatcaDAL obj = new fatcaDAL();
                DataSet dt = new DataSet();
                dt = obj.FatcaChangeByPolicyNumber(Policy);
                dataGridFATCAchangePolicy.DataSource = dt;
                dataGridFATCAchangePolicy.DataMember = dt.Tables[0].TableName;

                dataGridFATCAchangePolicy.Visible = true;
            }
        }
    }
}
