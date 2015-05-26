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
    public partial class FATCANEW : Form
    {
        public FATCANEW()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ExcelCreatorClass obj = new ExcelCreatorClass();
            //obj.ExcelCreatorFxn(dataGridFATCAnewPolicyData, "D:\\fatcaNewPolicyData.xlsx");
        }

        private void FATCANEW_Load(object sender, EventArgs e)
        {
            dataGridFATCAnewPolicyData.Visible = false;
         //   fatcaDAL obj = new fatcaDAL();
         //   DataSet dt = new DataSet();
         ////   dt = obj.FatcaChangePolicy();
         //   dataGridFATCAnewPolicyData.DataSource = dt;
         //   dataGridFATCAnewPolicyData.DataMember = dt.Tables[0].TableName;
        }

        private void btnViewFatcaNewPolicy_Click(object sender, EventArgs e)
        {
            dataGridFATCAnewPolicyData.Visible = true;
        }
    }
}
