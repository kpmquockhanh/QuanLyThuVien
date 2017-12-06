using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
namespace DAO
{
    public class DAO_Category:Connection
    {
        public int Insert(DTO_Category category)
        {
            string sql = "INSERT INTO Category(category_name) VALUES('" + category.Category_name + "');";
            return this.ExecuteNonQuery(sql);
        }

        public int Update(DTO_Category category)
        {
            string sql = "UPDATE Category SET category_name = '" + category.Category_name + "' WHERE category_id = '" + category.Category_id + "';";
            return this.ExecuteNonQuery(sql);
        }

        public int Delete(string category_id)
        {
            String sql = "DELETE Category WHERE b_id = " + category_id + ";";
            return this.ExecuteNonQuery(sql);
        }

        public DataTable GetAllDataTable()
        {
            return this.getTable("Select * from Category");
        }

        public DataTable GetDataTableBy(String condition, String value)
        {
            return this.getTable("select * from Category where " + condition + " = '" + value + "'");
        }
    }
}
