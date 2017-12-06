using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
namespace DAO
{
    public class DAO_Publisher:Connection
    {
        public int Insert(DTO_Publisher publisher)
        {
            string sql = "INSERT INTO Publisher(publisher_name, publisher_address)"
                + " VALUES('" + publisher.Publisher_name + "', '" + publisher.Publisher_address + "');";
            return this.ExecuteNonQuery(sql);
        }

        public int Update(DTO_Publisher publisher)
        {
            string sql = "UPDATE Publisher SET publisher_name = '" + publisher.Publisher_name + "', publisher_address = '"
                + publisher.Publisher_address + "' WHERE publisher_id = '" + publisher.Publisher_id + "';";
            return this.ExecuteNonQuery(sql);
        }

        public int Delete(string publisher_id)
        {
            String sql = "DELETE Publisher WHERE b_id = " + publisher_id + ";";
            return this.ExecuteNonQuery(sql);
        }

        public DataTable GetAllDataTable()
        {
            return this.getTable("Select * from Publisher");
        }

        public DataTable GetDataTableBy(String condition, String value)
        {
            return this.getTable("select * from Publisher where " + condition + " = '" + value + "'");
        }
    }
}
