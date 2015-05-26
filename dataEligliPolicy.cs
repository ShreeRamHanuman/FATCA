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
    public partial class dataEligliPolicy : Form
    {
        public dataEligliPolicy()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LOADFATCANEW frmLoadFatcaNew = new LOADFATCANEW();
            frmLoadFatcaNew.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LOADFATCAEXTG frmLoadFatcaExtg = new LOADFATCAEXTG();
            frmLoadFatcaExtg.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FATCAEXTG1M frmFactaExtg1M = new FATCAEXTG1M();
            frmFactaExtg1M.ShowDialog();
        }
    }
}
