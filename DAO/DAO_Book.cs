using DTO;
using System;
using System.Data;
namespace DAO
{
    public class DAO_Book : Connection
    {
        public int Insert(DTO_Book book)
        {

            string sql = "INSERT INTO Book(b_id, b_name, b_publication_date, b_price, b_quanity, category_id, author_id, publisher_id)"
            + " VALUES('" + book.ID + "',N'" + book.Name + "','" + book.Publication_date.ToShortDateString() + "', " + book.Price + ", "
            + book.Quantity + ", '" + book.Category_id + "', '" + book.Author_id + "', '" + book.Publisher_id + "');";
            return this.ExecuteNonQuery(sql);


        }

        public int Update(DTO_Book book)
        {
            string sql = "UPDATE Book SET b_name = N'" + book.Name + "', b_publication_date = '" + book.Publication_date + "', b_price = " + book.Price
                 + ", b_quanity = " + book.Quantity + ", category_id = '" + book.Category_id + "', author_id = '" + book.Author_id + "', publisher_id = '"
                 + book.Publisher_id + "' WHERE b_id = '" + book.ID + "';";
            return this.ExecuteNonQuery(sql);
        }

        public int Delete(string b_id)
        {
            String sql = "DELETE Book WHERE b_id = " + b_id + ";";
            return this.ExecuteNonQuery(sql);
        }

        public int DeleteByPublisher(string publisher_id)
        {
            String sql = "DELETE Book WHERE publisher_id = '" + publisher_id + "';";
            return this.ExecuteNonQuery(sql);
        }

        public int DeleteByAuthor(string author_id)
        {
            String sql = "DELETE FROM Book WHERE author_id = '" + author_id + "';";
            return this.ExecuteNonQuery(sql);
        }

        public int DeleteByCategory(string category_id)
        {
            String sql = "DELETE Book WHERE category_id = '" + category_id + "';";
            return this.ExecuteNonQuery(sql);
        }

        public DataTable GetAllDataTable()
        {
            return this.getTable("Select * from Book");
        }

        public DataTable GetDataTableBy(String condition, String value)
        {
            return this.getTable("select * from Book where " + condition + " = '" + value + "'");
        }
    }
}
