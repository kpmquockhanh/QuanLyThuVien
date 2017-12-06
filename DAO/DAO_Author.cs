using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
namespace DAO
{
    public class DAO_Author:Connection
    {
        public int Insert(DTO_Author author)
        {
            string sql = "INSERT INTO Author(author_id, author_name) VALUES('" + author.Author_id + "','" + author.Author_name + "');";
            return this.ExecuteNonQuery(sql);
        }

        public int Update(DTO_Author author)
        {
            string sql = "UPDATE Author SET author_name = '" + author.Author_name + "' WHERE author_id = '" + author.Author_id + "';";
            return this.ExecuteNonQuery(sql);
        }

        public int Delete(string author_id)
        {
            String sql = "DELETE Author WHERE author_id = '" + author_id + "';";
            return this.ExecuteNonQuery(sql);
        }

        public DataTable GetAllDataTable()
        {
            return this.getTable("Select * from Author");
        }

        public DataTable GetDataTableBy(String condition, String value)
        {
            return this.getTable("select * from Author where " + condition + " = '" + value + "'");
        }
    }
}
