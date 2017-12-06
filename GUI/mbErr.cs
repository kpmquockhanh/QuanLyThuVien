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
    public partial class mbErr : Form
    {
        public DialogResult result;
        
        public mbErr(String title, String content)
        {

            InitializeComponent();
            lblTitle.Text = title;
            txtContent.Text = content;
            lblTitle.Location = new Point((this.Width - lblTitle.Width) / 2, lblTitle.Height);
            this.ShowDialog();
            result = DialogResult.Cancel;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            result = DialogResult.OK;
            this.Close();
        }
    }
}
