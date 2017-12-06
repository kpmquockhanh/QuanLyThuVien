using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
namespace DAO
{
    public class DAO_Borrow:Connection
    {
        public int Insert(DTO_Borrow borrow)
        {

            string sql = "INSERT INTO Borrow(br_id, take_date, return_date, quanity, br_deposit, b_id, s_id, r_id)"
            + " VALUES('"+borrow.ID+"','"+borrow.TakeDate+"','"+borrow.ReturnDate+"','"+borrow.Quanity+"','"+borrow.Deposit+"','"+borrow.BookID+"','"+borrow.StaffID+"','"+borrow.ReaderID+"')";
            return this.ExecuteNonQuery(sql);
        }

        public int Update(DTO_Borrow borrow)
        {
            string sql = "UPDATE Borrow SET br_id='"+borrow.ID+ "',take_date='" + borrow.TakeDate + "',return_date='" + borrow.ReturnDate + "',quanity='" + borrow.Quanity + "',br_deposit='" + borrow.Deposit + "',b_id='" + borrow.BookID + "',s_id='" + borrow.StaffID + "',r_id='" + borrow.ReaderID + "'WHERE br_id = '" + borrow.ID;
            return this.ExecuteNonQuery(sql);
        }

        public int Delete(string br_id)
        {
            String sql = "DELETE Borrow WHERE br_id = '" + br_id + "';";
            return this.ExecuteNonQuery(sql);
        }

        public DataTable GetAllDataTable()
        {
            return this.getTable("Select * from Borrow");
        }

        public DataTable GetDataTableBy(String condition, String value)
        {
            return this.getTable("select * from Borrow where " + condition + " = '" + value + "'");
        }
    }
}
