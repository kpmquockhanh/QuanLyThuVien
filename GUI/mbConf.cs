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
    public partial class mbConf : Form
    {
        public DialogResult result = DialogResult.Cancel;
        public mbConf(String title, String content)
        {

            InitializeComponent();
            lblTitle.Text = title;
            txtContent.Text = content;
            lblTitle.Location = new Point((this.Width - lblTitle.Width) / 2, lblTitle.Height);
            this.ShowDialog();
            result = DialogResult.Cancel;

        }
        private void btnE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}