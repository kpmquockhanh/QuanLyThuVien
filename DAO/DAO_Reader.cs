using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
namespace DAO
{
    public class DAO_Reader:Connection
    {
        public int Insert(DTO_Reader reader)
        {

            string sql = "INSERT INTO Reader(r_id, r_name, r_address, r_email, r_phone_number)"
            + " VALUES('" + reader.ID + "',N'" + reader.Name + "',N'" + reader.Addr + "','" + reader.Email + "','" + reader.Phone + "')";
            return this.ExecuteNonQuery(sql);
        }

        public int Update(DTO_Reader reader)
        {
            string sql = "UPDATE Reader SET r_id='" + reader.ID + "',r_name=N'" + reader.Name + "',r_address=N'" + reader.Addr + "',r_email='" + reader.Email + "',r_phone_number='" +reader.Phone + "'WHERE r_id = " + reader.ID;
            return this.ExecuteNonQuery(sql);
        }

        public int Delete(string r_id)
        {
            String sql = "DELETE Reader WHERE r_id = '" + r_id + "';";
            return this.ExecuteNonQuery(sql);
        }

        public DataTable GetAllDataTable()
        {
            return this.getTable("Select * from Reader");
        }

        public DataTable GetDataTableBy(String condition, String value)
        {
            return this.getTable("select * from Reader where " + condition + " = '" + value + "'");
        }
    }
}
