using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmMenu : Form
    {
        frmBook b = new frmBook();
        frmReader r = new frmReader();
        frmStaff s = new frmStaff();
        frmBorrow br = new frmBorrow();
        frmCard c = new frmCard();
        frmAuthor a = new frmAuthor();
        frmPublisher p = new frmPublisher();
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            b.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            r.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            s.ShowDialog();
            this.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            br.ShowDialog();
            this.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            c.ShowDialog();
            this.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            a.ShowDialog();
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            p.ShowDialog();
            this.Show();
        }
    }
}
