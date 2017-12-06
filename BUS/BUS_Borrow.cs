using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;
namespace BUS
{
    public class BUS_Borrow
    {
        List<Int32> listID = new List<Int32>();
        DAO_Borrow borrowDAO = new DAO_Borrow();
        DataTable dataTable = new DataTable();
        DTO_Borrow dto_borrow = new DTO_Borrow();
        public int InsertBorrow(DTO_Borrow borrow)
        {
            if (checkID(borrow.ID))
            {
                return -5;
            }
            int res = borrowDAO.Insert(borrow);
            if (res == 1)
            {
                listID.Add(borrow.ID);
            }
            return res;

        }


        public DataTable LoadDataGridViewBorrow()
        {
            dataTable = borrowDAO.GetAllDataTable();
            foreach (DataRow row in dataTable.Rows)
            {
                int id = Int32.Parse(row["br_id"].ToString());
            }
            return dataTable;
        }
        public DTO_Borrow SearchBorrow(String condition, String value)
        {
            dataTable = borrowDAO.GetDataTableBy(condition, value);
            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    dto_borrow.Quanity = int.Parse(row["quanity"].ToString());
                    dto_borrow.Deposit = int.Parse(row["br_deposit"].ToString());
                    dto_borrow.ReturnDate = DateTime.Parse(row["return_date"].ToString());
                    dto_borrow.TakeDate = DateTime.Parse(row["take_date"].ToString());
                    dto_borrow.BookID = int.Parse(row["br_id"].ToString());
                    dto_borrow.StaffID = int.Parse(row["s_id"].ToString());
                    dto_borrow.ReaderID = int.Parse(row["r_id"].ToString());
                    dto_borrow.ID = int.Parse(row["br_id"].ToString());
                    return dto_borrow;

                }
            }
            return null;
        }

        public int UpdateBorrow(DTO_Borrow borrow)
        {
            try
            {
                return borrowDAO.Update(borrow);
            }
            catch (Exception)
            {
                return -1;
            }

        }

        public int DeleteBorrow(String book_id)
        {
            try
            {
                int res = borrowDAO.Delete(book_id);
                if (res == 1) listID.Remove(Int32.Parse(book_id));
                return res;
            }
            catch (Exception)
            {
                return -1;
            }

        }

        /*public int DeleteBookByPublisher(String publisher_id)
        {
            try
            {
                return bookDAO.DeleteByPublisher(publisher_id);
            }
            catch (Exception e)
            {
                return -1;
            }

        }

        public int DeleteBookByAuthor(String author_id)
        {
            try
            {
                return bookDAO.DeleteByAuthor(author_id);
            }
            catch (Exception e)
            {
                return -1;
            }
        }
        public int DeleteBookByCategory(String category_id)
        {
            try
            {
                return bookDAO.DeleteByCategory(category_id);
            }
            catch (Exception e)
            {
                return -1;
            }
        }
        public String checkString(String name)
        {
            String[] tmp = name.Split('\'');
            String text = null;
            for (int i = 0; i < tmp.Length; i++)
            {
                if (i == tmp.Length - 1)
                {
                    text += tmp[i];
                }
                else
                {
                    text += tmp[i];
                    text += "''";
                }
            }
            return text;
        }*/
        public bool checkID(int id)
        {
            if (listID.Contains(id))
            {
                return false;
            }
            return true;
        }
    }
}
