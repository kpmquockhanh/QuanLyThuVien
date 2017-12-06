using System;
using DAO;
using DTO;
using System.Data;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace BUS
{
    public class BUS_Book
    {
        List<Int32> listID = new List<Int32>();
        DAO_Book bookDAO = new DAO_Book();
        DAO_Book dataBook = new DAO_Book();
        DataTable dataTable = new DataTable();
        DTO_Book dto_book = new DTO_Book();
        public int InsertBook(DTO_Book book)
        {
            if (book.Name.Contains("'"))
            {
                book.Name = checkString(book.Name);
            }
            if (checkID(book.ID))
            {
                return -5;
            }
            int res = bookDAO.Insert(book);
            if (res == 1)
            {
                listID.Add(book.ID);
            }
            return res;

        }


        public DataTable LoadDataGridViewBook()
        {
            dataTable = dataBook.GetAllDataTable();
            foreach (DataRow row in dataTable.Rows)
            {
                int id = Int32.Parse(row["b_id"].ToString());
            }
            return dataTable;
        }
        public DTO_Book SearchBook(String condition, String value)
        {
            dataTable = dataBook.GetDataTableBy(condition, value);
            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    dto_book.Name = row["b_name"].ToString();
                    dto_book.Price = int.Parse(row["b_price"].ToString());
                    dto_book.Publication_date = DateTime.Parse(row["b_publication_date"].ToString());
                    dto_book.Quantity = int.Parse(row["b_quanity"].ToString());
                    dto_book.Category_id = int.Parse(row["category_id"].ToString());
                    dto_book.Author_id = int.Parse(row["author_id"].ToString());
                    dto_book.Publisher_id = int.Parse(row["publisher_id"].ToString());
                    return dto_book;

                }
            }
            return null;
        }

        public int UpdateBook(DTO_Book book)
        {
            try
            {
                if (book.Name.Contains("'"))
                {
                    book.Name = checkString(book.Name);
                }
                return bookDAO.Update(book);
            }
            catch (Exception)
            {
                return -1;
            }

        }

        public int DeleteBook(String book_id)
        {
            try
            {
                int res = bookDAO.Delete(book_id);
                if (res == 1) listID.Remove(Int32.Parse(book_id));
                return res;
            }
            catch (Exception)
            {
                return -1;
            }

        }

        public int DeleteBookByPublisher(String publisher_id)
        {
            try
            {
                return bookDAO.DeleteByPublisher(publisher_id);
            }
            catch (Exception)
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
            catch (Exception)
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
            catch (Exception)
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
        }
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
