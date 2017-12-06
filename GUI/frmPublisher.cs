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
    public partial class frmPublisher : Form
    {
        //       BUS_Publisher bus_publisher = new BUS_Publisher();
        //        BUS_Book bus_book = new BUS_Book();
        //        DataTable dataTable;
        //        String id;
        //       public frmPublisher()
        //       {
        //           InitializeComponent();
        //       }

        //       private void frmPublisher_Load(object sender, EventArgs e)
        //        {
        //            dataTable = new DataTable();
        //            dataTable = bus_publisher.LoadDataGridViewPublisher();
        //            dgvPublisher.DataSource = dataTable;
        //        }

        //        private void btnAdd_Click(object sender, EventArgs e)
        //        {
        //            if (checkNull())
        //            {
        //                DTO_Publisher b = new DTO_Publisher();
        //                b.Publisher_id = int.Parse(txtPublisherID.Text);
        //                b.Publisher_name = txtPublisherName.Text;
        //                b.Publisher_address = txtAddress.Text;
        //                if (bus_publisher.InsertPublisher(b) == 1)
        //                {
        //                    MessageBox.Show("Thành công");
        //                    frmPublisher_Load(sender, e);
        //                }
        //                else
        //                    MessageBox.Show("Không thành công");
        //            }
        //            else
        //            {
        //                MessageBox.Show("Hãy nhập đủ thông tin");
        //            }
        //        }
        //        private bool checkNull()
        //        {
        //            if (txtPublisherID.Text == "" || txtPublisherName.Text == "" || txtAddress.Text == "")
        //            {
        //                return false;
        //            }
        //            return true;
        //        }

        //        private void txtPublisherID_TextChanged(object sender, EventArgs e)
        //        {

        //        }

        //        private void txtPublisherID_KeyPress(object sender, KeyPressEventArgs e)
        //        {
        //            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
        //            {
        //                e.Handled = true;
        //                MessageBox.Show("Hãy nhập số!");
        //            }
        //        }

        //        private void btnEdit_Click(object sender, EventArgs e)
        //        {
        //            if (checkNull())
        //            {
        //                DTO_Publisher b = new DTO_Publisher();
        //                b.Publisher_id = int.Parse(id);
        //                b.Publisher_name = txtPublisherName.Text;
        //                b.Publisher_address =txtAddress.Text;

        //                if (bus_publisher.UpdatePublisher(b) == 1)
        //                {
        //                    MessageBox.Show("Thành công");
        //                    frmPublisher_Load(sender, e);
        //                }
        //                else
        //                    MessageBox.Show("Không thành công");

        //            }
        //            else
        //            {
        //                MessageBox.Show("Hãy điển đủ thông tin!");
        //            }
        //        }

        //        private void dgvPublisher_CellClick(object sender, DataGridViewCellEventArgs e)
        //        {
        //            int i = e.RowIndex;
        //            try
        //            {
        //                dgvPublisher.Rows[e.RowIndex].Selected = true;
        //                txtPublisherID.Text = dgvPublisher.Rows[e.RowIndex].Cells[0].Value.ToString();
        //                id = txtPublisherID.Text;
        //                txtPublisherName.Text = dgvPublisher.Rows[e.RowIndex].Cells[1].Value.ToString();
        //                txtAddress.Text = dgvPublisher.Rows[e.RowIndex].Cells[2].Value.ToString();
        //            }
        //            catch (ArgumentOutOfRangeException)
        //            { }
        //        }

        //        private void btnSeach_Click(object sender, EventArgs e)
        //        {
        //            if (txtPublisherID.Text != "")
        //            {
        //                DTO_Publisher dto_publisher = new DTO_Publisher();
        //                String id = txtPublisherID.Text;
        //                dto_publisher = bus_publisher.SearchPublisher("publisher_id", txtPublisherID.Text);
        //                if (dto_publisher != null)
        //                {
        //                    txtPublisherName.Text = dto_publisher.Publisher_name;
        //                    txtAddress.Text = dto_publisher.Publisher_address;
        //                }
        //                else
        //                {
        //                    MessageBox.Show("Không tìm thấy!");
        //                    txtPublisherID.Text = "";
        //                }
        //            }
        //            else
        //            {
        //                MessageBox.Show("Hãy nhập mã sách cần tìm!");
        //            }
        //        }

        //        private void btnDelete_Click(object sender, EventArgs e)
        //        {
        //            if (checkNull())
        //            {
        //                DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin nhà xuất bản "
        // +txtPublisherName.Text + " và thông tin các sách của tác giả " + txtPublisherName.Text + "?", "Thông báo", MessageBoxButtons.YesNo,
        //MessageBoxIcon.Question);
        //                if (DialogResult.Yes == dlr)
        //                {
        //                    if (bus_book.DeleteBookByPublisher(txtPublisherID.Text) == 1 
        //                        && bus_publisher.DeletePublisher(txtPublisherID.Text) == 1 )
        //                    {
        //                        MessageBox.Show("Thành công");
        //                        frmPublisher_Load(sender, e);
        //                        txtPublisherID.Text = "";
        //                        txtAddress.Text = "";
        //                        txtPublisherName.Text = "";
        //                    }
        //                    else
        //                        MessageBox.Show("Không thành công");
        //                }
        //                if (DialogResult.No == dlr)
        //                {
        //                    this.Close();
        //                }
        //            }
        //            else
        //            {
        //                MessageBox.Show("Hãy tìm thông tin sách cần xóa hoặc chọn item sách trong bảng sách!");
        //            }
        //        }

        //        private void btnExit_Click(object sender, EventArgs e)
        //        {
        //            this.Close();
        //        }
        //   }
    }
}
