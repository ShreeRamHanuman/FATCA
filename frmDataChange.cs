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
    public partial class frmDataChange : Form
    {
        public frmDataChange()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnDownloadByDate_Click(object sender, EventArgs e)
        {
            FATCACHANGE frmFatcaChange = new FATCACHANGE();
            frmFatcaChange.ShowDialog();
        }

        private void btnDownloadByPolicy_Click(object sender, EventArgs e)
        {
            FATCACHPOL frmFatcaChpol = new FATCACHPOL();
            frmFatcaChpol.ShowDialog();
        }

        private void frmDataChange_Load(object sender, EventArgs e)
        {

        }
    }
}
