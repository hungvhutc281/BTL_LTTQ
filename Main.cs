using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo_btl
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void quảnLýPhimToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýRạpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rạpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Quay trở về màn hình đăng nhập ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }

        }
    }
}
