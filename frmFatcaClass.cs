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
    public partial class frmFatcaClass : Form
    {
        public frmFatcaClass()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FATCACLS frmFatcaCls = new FATCACLS();
            frmFatcaCls.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FATCAUS frmFatcaUS = new FATCAUS();
            frmFatcaUS.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FATCACLSCOM frmFatcaClsCompliant = new FATCACLSCOM();
            frmFatcaClsCompliant.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FATCACLSNCOM frmFatcaNonComp = new FATCACLSNCOM();
            frmFatcaNonComp.ShowDialog();
        }
    }
}
