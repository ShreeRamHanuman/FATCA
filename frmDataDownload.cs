using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace FATCA
{
    public partial class frmDataDownload : Form
    {
        public frmDataDownload()
        {
            InitializeComponent();
        }

        private void btnNewDownload_Click(object sender, EventArgs e)
        {
            FATCANEW frmFatcaNew = new FATCANEW();
            frmFatcaNew.ShowDialog();
        }

        private void btnExistingDownload_Click(object sender, EventArgs e)
        {
            FATCAEXTG frmFatcaExtg = new FATCAEXTG();
            frmFatcaExtg.ShowDialog();
        }
    }
}
