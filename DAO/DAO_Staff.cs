using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
namespace DAO
{
    public class DAO_Staff:Connection
    {
        public int Insert(DTO_Staff staff)
        {

            string sql = "INSERT INTO Staff (s_id,s_password,s_name,s_address,s_email,s_phone_number) VALUES('"+staff.ID+"','"+staff.Password+"',N'"+staff.Name+"',N'"+staff.Addr+"','"+staff.Email+"','"+staff.Phone+"')";
            return this.ExecuteNonQuery(sql);
        }

        public int Update(DTO_Staff staff)
        {
            string sql = "UPDATE Staff SET s_id='"+staff.ID+"',s_password='"+staff.Password+"',s_name=N'"+staff.Name+"',s_address=N'"+staff.Addr+"',s_email='"+staff.Email+"',s_phone_number='"+staff.Phone+ "'WHERE s_id = " + staff.ID;
            return this.ExecuteNonQuery(sql);
        }

        public int Delete(string s_id)
        {
            String sql = "DELETE Staff WHERE s_id = " + s_id + ";";
            return this.ExecuteNonQuery(sql);
        }

        public DataTable GetAllDataTable()
        {
            return this.getTable("Select * from Staff");
        }

        public DataTable GetDataTableBy(String condition, String value)
        {
            return this.getTable("select * from Staff where " + condition + " = '" + value + "'");
        }
    }
}
