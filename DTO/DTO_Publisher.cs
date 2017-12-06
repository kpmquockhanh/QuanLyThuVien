using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Publisher
    {
        private int publisher_id;
        private String publisher_name;
        private String publisher_address;
        public int Publisher_id { get => publisher_id; set => publisher_id = value; }
        public string Publisher_name { get => publisher_name; set => publisher_name = value; }
        public string Publisher_address { get => publisher_address; set => publisher_address = value; }
    }
}
