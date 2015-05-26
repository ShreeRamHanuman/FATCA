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
    public partial class FATCAEXTG : Form
    {
        public FATCAEXTG()
        {
            InitializeComponent();
        }

        private void FATCAEXTG_Load(object sender, EventArgs e)
        {
            //dataGridFatcaExistingPolicy.Visible = false;
            //fatcaDAL obj = new fatcaDAL();
            //DataSet dt = new DataSet();
            //// dt = obj.FatcaChangePolicy();
            //dataGridFatcaExistingPolicy.DataSource = dt;
            //dataGridFatcaExistingPolicy.DataMember = dt.Tables[0].TableName;
        }

        private void btnDownloadFATCAExistingPolicy_Click(object sender, EventArgs e)
        {
            //ExcelCreatorClass obj = new ExcelCreatorClass();
            //obj.ExcelCreatorFxn(dataGridFatcaExistingPolicy, "D:\\fatcaExistingPolicy");
        }

        private void btnViewFATCAexixtingPolicy_Click(object sender, EventArgs e)
        {
           // dataGridFatcaExistingPolicy.Visible = true;
        }
    }
}
