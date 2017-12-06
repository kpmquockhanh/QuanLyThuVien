using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using BUS;
using DTO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmAuthor : Form
    {
        DataTable dataTable;
        BUS_Book bus_book = new BUS_Book();
        String id;
        BUS_Author bus_author = new BUS_Author();
        public frmAuthor()
        {
            InitializeComponent();
        }

        private void frmAuthor_Load(object sender, EventArgs e)
        {
            dataTable = new DataTable();
            dataTable = bus_author.LoadDataGridViewAuthor();
            dgvAuthor.DataSource = dataTable;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeach_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (checkNull())
            {
                DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin tác giả "
                    + txtAuthorName.Text + " và các sách của " + txtAuthorName.Text + "?", "Thông báo", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (DialogResult.Yes == dlr)
                {
                    if ((bus_book.DeleteBookByAuthor(txtAuthorID.Text) == 1
                         && bus_author.DeleteAuthor(txtAuthorID.Text) == 1)
                         || (bus_book.DeleteBookByAuthor(txtAuthorID.Text) == 0
                         && bus_author.DeleteAuthor(txtAuthorID.Text) == 1))
                    {
                        MessageBox.Show("Thành công");
                        frmAuthor_Load(sender, e);
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
                MessageBox.Show("Hãy tìm thông tin tác giả cần xóa hoặc chọn item tác giả trong bảng tác giả!");
            }
        }
        private bool checkNull()
        {
            if (txtAuthorID.Text == "" || txtAuthorName.Text == "")
            {
                return false;
            }
            return true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            if (checkNull())
            {
                DTO_Author b = new DTO_Author();
                b.Author_id = int.Parse(txtAuthorID.Text);
                b.Author_name = txtAuthorName.Text;

                if (bus_author.InsertAuthor(b) == 1)
                {
                    MessageBox.Show("Thành công");
                    frmAuthor_Load(sender, e);


                }
                else
                    MessageBox.Show("Không thành công");
            }
            else
            {
                MessageBox.Show("Hãy nhập đủ thông tin");
            }
        }

        private void txtAuthorID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAuthorID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Hãy nhập số!");
            }
        }

        private void dgvAuthor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            try
            {
                dgvAuthor.Rows[e.RowIndex].Selected = true;
                txtAuthorID.Text = dgvAuthor.Rows[e.RowIndex].Cells[0].Value.ToString();
                id = txtAuthorID.Text;
                txtAuthorName.Text = dgvAuthor.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtAuthorID.Enabled = false;
            }
            catch (ArgumentOutOfRangeException)
            { }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void lb_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }


        private void frmAuthor_Load_1(object sender, EventArgs e)
        {

        }
    }
}
