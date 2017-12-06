using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Borrow
    {
        private int br_id;
        private DateTime take_date;
        private DateTime return_date;
        private int _quanity;
        private Double _deposit;
        private int b_id;
        private int s_id;
        private int r_id;

        public int ID { get => br_id; set => br_id = value; }
        public DateTime TakeDate { get => take_date; set => take_date = value; }
        public DateTime ReturnDate { get => return_date; set => return_date = value; }
        public int Quanity { get => _quanity; set => _quanity = value; }
        public double Deposit { get => _deposit; set => _deposit = value; }
        public int BookID { get => b_id; set => b_id = value; }
        public int ReaderID { get => r_id; set => r_id = value; }
        public int StaffID { get => s_id; set => s_id = value; }
    }
}
