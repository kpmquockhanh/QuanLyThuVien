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
    public partial class frmBook : Form
    {
        BUS_Book bus_book = new BUS_Book();
        BUS_Author bus_author = new BUS_Author();
        BUS_Publisher bus_publisher = new BUS_Publisher();
        BUS_Category bus_category = new BUS_Category();

        DataTable dataTable;
        String id;
        public frmBook()
        {
            InitializeComponent();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            if (checkNull())
            {
                DTO_Book b = new DTO_Book();
                b.ID = int.Parse(txtID.Text);
                b.Name = txtName.Text;
                b.Price = int.Parse(txtPrice.Text);
                b.Publication_date = DateTime.Parse(dpPubDate.Value.ToShortDateString());
                b.Publisher_id = int.Parse(cbPub.SelectedValue.ToString());
                b.Author_id = int.Parse(cbAuthor.SelectedValue.ToString());
                b.Category_id = int.Parse(cbCate.SelectedValue.ToString());
                b.Quantity = int.Parse(txtQuanity.Text);
                if (bus_book.InsertBook(b) == 1)
                {
                    MessageBox.Show("Thành công");
                    frmBook_Load(sender, e);
                }
                else
                    MessageBox.Show("Không thành công");
            }
            else
            {
                MessageBox.Show("Hãy nhập đủ thông tin");
            }
        }

        private void frmBook_Load(object sender, EventArgs e)
        {
            dpPubDate.Value = DateTime.Now;
            // Load DataGridView
            dataTable = new DataTable();
            dataTable = bus_book.LoadDataGridViewBook();
            dgvBook.DataSource = dataTable;

            // Load ComboxCategory
            dataTable = new DataTable();
            dataTable = bus_category.LoadDataGridViewCategory();
            cbCate.DataSource = dataTable;
            cbCate.DisplayMember = "category_name";
            cbCate.ValueMember = "category_id";

            // Load ComboxAuthor
            dataTable = new DataTable();
            dataTable = bus_author.LoadDataGridViewAuthor();
            cbAuthor.DataSource = dataTable;
            cbAuthor.ValueMember = "author_id";
            cbAuthor.DisplayMember = "author_name";

            // Load ComboxPublisher
            dataTable = new DataTable();
            dataTable = bus_publisher.LoadDataGridViewPublisher();
            cbPub.DataSource = dataTable;
            cbPub.DisplayMember = "publisher_name";
            cbPub.ValueMember = "publisher_id";

            //Set field
            setField();
        }
        
        private void setField()
        {
            dgvBook.Columns["b_id"].HeaderText = "ID";
            dgvBook.Columns["b_name"].HeaderText = "Name";
            dgvBook.Columns["b_publication_date"].HeaderText = "Publication date";
            dgvBook.Columns["b_price"].HeaderText = "Price";
            dgvBook.Columns["b_quanity"].HeaderText = "Quanity";
            dgvBook.Columns["category_id"].HeaderText = "Category ID";
            dgvBook.Columns["author_id"].HeaderText = "Author ID";
            dgvBook.Columns["publisher_id"].HeaderText = "Publisher ID";
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Hãy nhập số!");
            }
        }


        private void txtQuanity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Hãy nhập số!");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (checkNull())
            {
                DTO_Book b = new DTO_Book();
                b.ID = int.Parse(txtID.Text);
                b.Name = txtName.Text;
                b.Price = int.Parse(txtPrice.Text);
                b.Publication_date = DateTime.Parse(dpPubDate.Value.ToShortDateString());
                b.Publisher_id = int.Parse(cbPub.SelectedValue.ToString());
                b.Author_id = int.Parse(cbAuthor.SelectedValue.ToString());
                b.Category_id = int.Parse(cbCate.SelectedValue.ToString());
                b.Quantity = int.Parse(txtQuanity.Text);
                if (bus_book.UpdateBook(b) == 1)
                {
                    MessageBox.Show("Thành công");
                    frmBook_Load(sender, e);
                }
                else
                    MessageBox.Show("Không thành công");

            }
            else
            {
                MessageBox.Show("Hãy điển đủ thông tin!");
            }
        }

        private void dgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            try
            {
                dgvBook.Rows[e.RowIndex].Selected = true;
                txtID.Text = dgvBook.Rows[e.RowIndex].Cells[0].Value.ToString();
                id = txtID.Text;
                txtName.Text = dgvBook.Rows[e.RowIndex].Cells[1].Value.ToString();
                dpPubDate.Text = dgvBook.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtPrice.Text = dgvBook.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtQuanity.Text = dgvBook.Rows[e.RowIndex].Cells[4].Value.ToString();
                cbAuthor.Text = dgvBook.Rows[e.RowIndex].Cells[6].Value.ToString();
                cbPub.Text = dgvBook.Rows[e.RowIndex].Cells[7].Value.ToString();
                cbCate.Text = dgvBook.Rows[e.RowIndex].Cells[5].Value.ToString();
                //txtID.Enabled = false;
            }
            catch (ArgumentOutOfRangeException)
            { }

        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Hãy nhập số!");
            }
        }
        private bool checkNull()
        {
            if (txtID.Text == "" || txtName.Text == "" || txtPrice.Text == "" || txtQuanity.Text == ""
                || cbAuthor.Text == "" || cbCate.Text == "" || cbPub.Text == "")
            {
                return false;
            }
            return true;
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            if (checkNull())
            {
                DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin sách "
                    + txtName.Text + "?", "Thông báo", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (DialogResult.Yes == dlr)
                {
                    if (bus_book.DeleteBook(txtID.Text) == 1)
                    {
                        MessageBox.Show("Thành công");
                        frmBook_Load(sender, e);
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
            txtID.Clear();
            txtName.Clear();
            txtPrice.Clear();
            txtQuanity.Clear();
            cbAuthor.Text = "";
            cbCate.Text = "";
            cbPub.Text = "";
            txtID.Focus();
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeach_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                DTO_Book dto_book = new DTO_Book();
                String id = txtID.Text;
                dto_book = bus_book.SearchBook("b_id", txtID.Text);
                if (dto_book != null)
                {
                    txtName.Text = dto_book.Name;
                    txtPrice.Text = dto_book.Price.ToString();
                    txtQuanity.Text = dto_book.Quantity.ToString();
                    dpPubDate.Text = dto_book.Publication_date.ToShortDateString();
                    cbCate.Text = dto_book.Category_id.ToString();
                    cbAuthor.Text = dto_book.Author_id.ToString();
                    cbPub.Text = dto_book.Publisher_id.ToString();
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
