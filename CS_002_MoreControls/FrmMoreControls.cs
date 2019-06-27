using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_002_MoreControls
{
    public partial class FrmMoreControls : Form
    {
        public FrmMoreControls()
        {
            InitializeComponent();
        }

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void hsbNumber_Scroll(object sender, ScrollEventArgs e)
        {
            txtNumber.Text = hsbNumber.Value.ToString();
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gainsboro;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Turquoise;
        }

        private void btnGoToSecondForm_Click(object sender, EventArgs e)
        {
            FrmTwo x = new FrmTwo();
            x.Show();
        }
    }
}
