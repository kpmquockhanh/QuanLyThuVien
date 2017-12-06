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
    public class BUS_Staff
    {
        DAO_Staff staffDAO = new DAO_Staff();

        public int InsertStaff(DTO_Staff staff)
        {
            return staffDAO.Insert(staff);
        }


        public DataTable LoadDataGridViewStaff()
        {
            return staffDAO.GetAllDataTable();
        }
        public DataTable SearchStaff(String condition, String value)
        {
            return staffDAO.GetDataTableBy(condition, value);

        }

        public int UpdateStaff(DTO_Staff staff)
        {
            return staffDAO.Update(staff);


        }

        public int DeleteStaff(string staff)
        {
            return staffDAO.Delete(staff);
        }

    }
}
