using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace GUI
{
    public partial class frmBorrow : Form
    {
        DataTable dataTable = new DataTable();
        BUS_Borrow br = new BUS_Borrow();
        BUS_Reader bus_read = new BUS_Reader();
        BUS_Staff bus_staff = new BUS_Staff();
        BUS_Card bus_card = new BUS_Card();
        public frmBorrow()
        {
            InitializeComponent();
        }



        private void btnE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                DTO_Borrow dto_book = new DTO_Borrow();
                String id = txtID.Text;
                dto_book = br.SearchBorrow("br_id", txtID.Text);
                if (dto_book != null)
                {
                    txtQuanity.Text = dto_book.Quanity.ToString();
                    txtDeposit.Text = dto_book.Deposit.ToString();
                    cbxBookID.Text = dto_book.BookID.ToString();
                    dateTimePicker1.Text = dto_book.TakeDate.ToShortDateString();
                    dateTimePicker2.Text = dto_book.ReturnDate.ToShortDateString();
                    a.Text = dto_book.StaffID.ToString();
                    cbxReadID.Text = dto_book.ReaderID.ToString();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy!");
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập mã sách cần tìm!");
            }
        }

        private bool checkNull()
        {
            if (txtID.Text == "" || cbxBookID.Text == "" || txtDeposit.Text == "" || txtQuanity.Text == ""
                || txtQuanity.Text == "" || cbxBookID.Text == "" || cbxReadID.Text == "")
            {
                return false;
            }
            return true;
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            cbxBookID.Text = "";
            txtDeposit.Clear();
            txtID.Clear();
            txtQuanity.Clear();
            cbxReadID.Text = "";
            a.Text = "";
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            if (checkNull())
            {
                DTO_Borrow b = new DTO_Borrow();
                b.ID = int.Parse(txtID.Text);
                b.ReturnDate = DateTime.Parse(dateTimePicker2.Value.ToShortDateString());
                b.TakeDate = DateTime.Parse(dateTimePicker1.Value.ToShortDateString());
                b.Quanity = Int32.Parse(txtQuanity.Text);
                b.Deposit = int.Parse(txtDeposit.Text);
                b.BookID = int.Parse(cbxBookID.Text);
                b.StaffID = int.Parse(a.Text);
                b.ReaderID = int.Parse(cbxReadID.Text);
                if (br.InsertBorrow(b) == 1)
                {
                    MessageBox.Show("Thành công");
                    frmBorrow_Load(sender, e);
                }
                else if (br.InsertBorrow(b) == -5)
                {
                    MessageBox.Show("Nhập mã sách bị trùng!");
                    txtID.Text = "";
                    txtID.Focus();
                }
                else
                    MessageBox.Show("Không thành công");
            }
            else
            {
                MessageBox.Show("Hãy nhập đủ thông tin");
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            if (checkNull())
            {
                DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin the muon "
                    + txtID.Text + "?", "Thông báo", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (DialogResult.Yes == dlr)
                {
                    if (br.DeleteBorrow(txtID.Text) == 1)
                    {
                        MessageBox.Show("Thành công");
                        frmBorrow_Load(sender, e);
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

        private void frmBorrow_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            // Load DataGridView
            dataTable = new DataTable();
            dataTable = br.LoadDataGridViewBorrow();
            dgvBorrow.DataSource = dataTable;

            // Load ComboxReadID
            dataTable = new DataTable();
            dataTable = bus_read.LoadDataGridViewReader();
            cbxReadID.DataSource = dataTable;
            cbxReadID.DisplayMember = "r_id";

            // Load ComboxStaff
            dataTable = new DataTable();
            dataTable = bus_staff.LoadDataGridViewStaff();
            cbxStaffID.DataSource = dataTable;
            cbxStaffID.DisplayMember = "s_id";

            // Load ComboxPublisher
            dataTable = new DataTable();
            dataTable = bus_staff.LoadDataGridViewStaff();
            cbxBookID.DataSource = dataTable;
            cbxBookID.DisplayMember = "b_id";

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (checkNull())
            {
                DTO_Borrow b = new DTO_Borrow();
                b.ID = int.Parse(txtID.Text);
                b.ReturnDate = DateTime.Parse(dateTimePicker2.Value.ToShortDateString());
                b.TakeDate = DateTime.Parse(dateTimePicker1.Value.ToShortDateString());
                b.Quanity = Int32.Parse(txtQuanity.Text);
                b.Deposit = int.Parse(txtDeposit.Text);
                b.BookID = int.Parse(cbxBookID.Text);
                b.StaffID = int.Parse(a.Text);
                b.ReaderID = int.Parse(cbxReadID.Text);
                if (br.UpdateBorrow(b) == 1)
                {
                    MessageBox.Show("Thành công");
                    frmBorrow_Load(sender, e);
                }
                else
                    MessageBox.Show("Không thành công");

            }
            else
            {
                MessageBox.Show("Hãy điển đủ thông tin!");
            }
        }
    }
}
