using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;
using DTO;
namespace BUS
{
    public class BUS_Card
    {
        DAO_Card cardDAO = new DAO_Card();

        public int InsertCard(DTO_Card card)
        {

            return cardDAO.Insert(card);
        }


        public DataTable LoadDataGridViewBorrow()
        {
            return cardDAO.GetAllDataTable();
        }
        public DataTable SearchCard(String condition, String value)
        {
            return cardDAO.GetDataTableBy(condition, value);

        }

        public int UpdateCard(DTO_Card card)
        {
            return cardDAO.Update(card);
        }

        public int DeleteCard(DTO_Card card)
        {
            return cardDAO.Delete(card.ID.ToString());
        }
    }
}
