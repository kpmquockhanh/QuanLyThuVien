using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace GUI
{
    public partial class frmReader : Form
    {

        BUS_Reader readerBUS;

        public frmReader()
        {
            InitializeComponent();
        }

        private void gb1_Paint(object sender, PaintEventArgs e)
        {
            //Pen p = new Pen(Color.FromArgb(26, 187, 155));
            //Graphics g = e.Graphics;
            //g.DrawRectangle(p, new Rectangle(new Point(txtID.Location.X - 3, txtID.Location.Y - 3), new Size(txtID.Width + 3, txtID.Height + 3)));
            //g.DrawRectangle(p, new Rectangle(new Point(txtName.Location.X - 3, txtName.Location.Y - 3), new Size(txtName.Width + 3, txtName.Height + 3)));
            //g.DrawRectangle(p, new Rectangle(new Point(txtPhone.Location.X - 3, txtPhone.Location.Y - 3), new Size(txtPhone.Width + 3, txtPhone.Height + 3)));
            //g.DrawRectangle(p, new Rectangle(new Point(txtAddr.Location.X - 3, txtAddr.Location.Y - 3), new Size(txtAddr.Width + 3, txtAddr.Height + 3)));
            //g.DrawRectangle(p, new Rectangle(new Point(txtEmail.Location.X - 3, txtEmail.Location.Y - 3), new Size(txtEmail.Width + 3, txtEmail.Height + 3)));
        }

        private void setField()
        {
            dgvReader.Columns["r_id"].HeaderText = "ID";
            dgvReader.Columns["r_name"].HeaderText = "Name";
            dgvReader.Columns["r_address"].HeaderText = "Address";
            dgvReader.Columns["r_phone_number"].HeaderText = "Phone number";
            dgvReader.Columns["r_email"].HeaderText = "Email";
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReader_Load(object sender, EventArgs e)
        {
            readerBUS = new BUS_Reader();
            dgvReader.DataSource = readerBUS.LoadDataGridViewReader();
            setField();
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            txtID.ResetText();
            txtName.ResetText();
            txtAddr.ResetText();
            txtPhone.ResetText();
            txtEmail.ResetText();
        }

        private bool checkNull()
        {
            if (txtID.Text == "" || txtName.Text == "" || txtEmail.Text == ""
                || txtPhone.Text == "" || txtAddr.Text == "")
            {
                return false;
            }
            return true;
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            if (checkNull())
            {
                DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin người đọc "
                    + txtName.Text + "?", "Thông báo", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (DialogResult.Yes == dlr)
                {
                    if (readerBUS.DeleteReader(txtID.Text) > 0)
                    {
                        MessageBox.Show("Thành công");
                        frmReader_Load(sender, e);
                        btnR_Click(sender, e);
                    }
                    else
                        MessageBox.Show("Không thành công");
                }
            }
            else
            {
                MessageBox.Show("Hãy tìm thông tin sách cần xóa hoặc chọn item sách trong bảng sách!");
            }
        }

        private void dgvReader_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvReader.Rows[e.RowIndex].Selected = true;
                txtID.Text = dgvReader.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtName.Text = dgvReader.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtAddr.Text = dgvReader.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtEmail.Text = dgvReader.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtPhone.Text = dgvReader.Rows[e.RowIndex].Cells[4].Value.ToString();
                //txtID.Enabled = false;
            }
            catch (Exception)
            {
               // MessageBox.Show(a.ToString());
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (checkNull())
            {
                DTO_Reader readerDTO = new DTO_Reader();
                readerDTO.ID = int.Parse(txtID.Text);
                readerDTO.Name = txtName.Text;
                readerDTO.Email = txtEmail.Text;
                readerDTO.Addr = txtAddr.Text;
                readerDTO.Phone = txtPhone.Text;
                if (readerBUS.UpdateReader(readerDTO) > 0)
                {
                    MessageBox.Show("Thành công");
                    frmReader_Load(sender, e);
                }
                else
                    MessageBox.Show("Không thành công");
            }
            else
            {
                MessageBox.Show("Hãy nhập đủ thông tin");
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            if (checkNull())
            {
                DTO_Reader readerDTO = new DTO_Reader();
                readerDTO.ID = int.Parse(txtID.Text);
                readerDTO.Name = txtName.Text;
                readerDTO.Email = txtEmail.Text;
                readerDTO.Addr = txtAddr.Text;
                readerDTO.Phone = txtPhone.Text;
                if (readerBUS.InsertReader(readerDTO) > 0)
                {
                    MessageBox.Show("Thành công");
                    frmReader_Load(sender, e);
                }
                else
                    MessageBox.Show("Không thành công");
            }
            else
            {
                MessageBox.Show("Hãy nhập đủ thông tin");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                dgvReader.DataSource = readerBUS.SearchReader("r_id", txtID.Text);
            }
            else
            {
                MessageBox.Show("Vui lòng điền ID để tìm kiếm");
            }
        }
    }
}
