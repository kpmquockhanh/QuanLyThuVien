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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Paint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.FromArgb(26, 187, 155));
            Graphics g = e.Graphics;
            g.DrawRectangle(p, new Rectangle(new Point(txtUser.Location.X-3, txtUser.Location.Y - 3), new Size(txtUser.Width + 3,txtUser.Height+3)));
            g.DrawRectangle(p, new Rectangle(new Point(txtPass.Location.X - 3, txtPass.Location.Y - 3), new Size(txtPass.Width + 3, txtPass.Height + 3)));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
