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
    public partial class frmStaff : Form
    {
        BUS_Staff staff;
        public frmStaff()
        {
            InitializeComponent();
        }

        private void setField()
        {
            dgvStaff.Columns["s_id"].HeaderText = "ID";
            dgvStaff.Columns["s_password"].HeaderText = "Password";
            dgvStaff.Columns["s_name"].HeaderText = "Name";
            dgvStaff.Columns["s_address"].HeaderText = "Address";
            dgvStaff.Columns["s_phone_number"].HeaderText = "Phone number";
            dgvStaff.Columns["s_email"].HeaderText = "Email";
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            staff = new BUS_Staff();
            dgvStaff.DataSource = staff.LoadDataGridViewStaff();
            setField();
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnE_Click(sender, e);
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            if (checkNull())
            {
                DTO_Staff staffDTO = new DTO_Staff();
                staffDTO.ID = int.Parse(txtID.Text);
                staffDTO.Password = txtPass.Text;
                staffDTO.Name = txtName.Text;
                staffDTO.Email = txtEmail.Text;
                staffDTO.Addr = txtAddr.Text;
                staffDTO.Phone = txtPhone.Text;
                if (staff.InsertStaff(staffDTO) > 0)
                {
                    MessageBox.Show("Thành công");
                    frmStaff_Load(sender, e);
                }
                else
                    MessageBox.Show("Không thành công");
            }
            else
            {
                MessageBox.Show("Hãy nhập đủ thông tin");
            }


        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (checkNull())
            {
                DTO_Staff staffDTO = new DTO_Staff();
                staffDTO.ID = int.Parse(txtID.Text);
                staffDTO.Password = txtPass.Text;
                staffDTO.Name = txtName.Text;
                staffDTO.Email = txtEmail.Text;
                staffDTO.Addr = txtAddr.Text;
                staffDTO.Phone = txtPhone.Text;
                if (staff.UpdateStaff(staffDTO) > 0)
                {
                    MessageBox.Show("Thành công");
                    frmStaff_Load(sender, e);
                }
                else
                    MessageBox.Show("Không thành công");
            }
            else
            {
                MessageBox.Show("Hãy nhập đủ thông tin");
            }

        }

        private bool checkNull()
        {
            if (txtID.Text == "" || txtName.Text == "" || txtPass.Text == "" || txtEmail.Text == ""
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
                DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin nhân viên "
                    + txtName.Text + "?", "Thông báo", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (DialogResult.Yes == dlr)
                {
                    if (staff.DeleteStaff(txtID.Text) > 0)
                    {
                        MessageBox.Show("Thành công");
                        frmStaff_Load(sender, e);
                        btnR_Click(sender, e);
                    }
                    else
                        MessageBox.Show("Không thành công");
                }
                if (DialogResult.No == dlr)
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Hãy tìm thông tin sách cần xóa hoặc chọn item sách trong bảng sách!");
            }
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            txtID.ResetText();
            txtPass.ResetText();
            txtName.ResetText();
            txtAddr.ResetText();
            txtEmail.ResetText();
            txtPhone.ResetText();
        }

        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvStaff.Rows[e.RowIndex].Selected = true;
                txtID.Text = dgvStaff.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtPass.Text = dgvStaff.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtName.Text = dgvStaff.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtAddr.Text = dgvStaff.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtEmail.Text = dgvStaff.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtPhone.Text = dgvStaff.Rows[e.RowIndex].Cells[5].Value.ToString();
                //txtID.Enabled = false;
            }
            catch (ArgumentOutOfRangeException)
            { }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                dgvStaff.DataSource = staff.SearchStaff("s_id", txtID.Text);
            }
            else
            {
                MessageBox.Show("Vui lòng điền ID để tìm kiếm");
            }

        }
    }
}
