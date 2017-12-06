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
    public class BUS_Publisher
    {
        DAO_Publisher publisherDAO = new DAO_Publisher();
        DataTable dataTable = new DataTable();
        DTO_Publisher dto_publisher = new DTO_Publisher();
        public int InsertPublisher(DTO_Publisher publisher)
        {
            if (publisher.Publisher_name.Contains("'"))
            {
                publisher.Publisher_name = checkString(publisher.Publisher_name);
            }
            return publisherDAO.Insert(publisher);
        }


        public DataTable LoadDataGridViewPublisher()
        {
            return dataTable = publisherDAO.GetAllDataTable();
        }
        public DTO_Publisher SearchPublisher(String condition, String value)
        {
            dataTable = publisherDAO.GetDataTableBy(condition, value);
            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    dto_publisher.Publisher_name = row["publisher_name"].ToString();
                    dto_publisher.Publisher_id = int.Parse(row["publisher_id"].ToString());
                    dto_publisher.Publisher_address = row["publisher_address"].ToString();
                    return dto_publisher;
                }
            }
            return null;
        }

        public int UpdatePublisher(DTO_Publisher publisher)
        {
            try
            {
                if (publisher.Publisher_name.Contains("'"))
                {
                    publisher.Publisher_name = checkString(publisher.Publisher_name);
                }
                return publisherDAO.Update(publisher);
            }
            catch (Exception)
            {
                return -1;
            }

        }

        public int DeletePublisher(DTO_Publisher publisher)
        {
            try
            {
                if (publisher.Publisher_name.Contains("'"))
                {
                    publisher.Publisher_name = checkString(publisher.Publisher_name);
                }
                return publisherDAO.Delete(publisher.Publisher_name);
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
    }
}
