using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;
namespace BUS
{
    public class BUS_Reader
    {
        DAO_Reader readerDAO = new DAO_Reader();

        public int InsertReader(DTO_Reader reader)
        {
            return readerDAO.Insert(reader);
        }


        public DataTable LoadDataGridViewReader()
        {
            return readerDAO.GetAllDataTable();
        }
        public DataTable SearchReader(String condition, String value)
        {
            return readerDAO.GetDataTableBy(condition, value);

        }

        public int UpdateReader(DTO_Reader reader)
        {
            return readerDAO.Update(reader);


        }

        public int DeleteReader(string reader)
        {
            return readerDAO.Delete(reader);
        }
    }
}
