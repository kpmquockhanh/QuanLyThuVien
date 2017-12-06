using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Card
    {
        private int c_id;
        private int r_id;
        private DateTime expired_date;

        public int ID { get => c_id; set => c_id = value; }
        public int ReaderID { get => r_id; set => r_id = value; }
        public DateTime Expired_date { get => expired_date; set => expired_date = value; }
    }
}
