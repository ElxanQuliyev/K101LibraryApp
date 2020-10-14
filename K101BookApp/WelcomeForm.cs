using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K101BookApp
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            //pcWelImg.Location = new Point((pcWelImg.Parent.ClientSize.Width - pcWelImg.Size.Width) / 2,
            //    (pcWelImg.Parent.ClientSize.Height - pcWelImg.Size.Height) / 2
            //    );
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.ShowDialog();
        }
    }
}
