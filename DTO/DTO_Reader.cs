using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Reader
    {
        private int r_id;
        private String r_name;
        private String r_addr;
        private String r_email;
        private String r_phone;

        public int ID { get => r_id; set => r_id = value; }
        public string Name { get => r_name; set => r_name = value; }
        public string Addr { get => r_addr; set => r_addr = value; }
        public string Email { get => r_email; set => r_email = value; }
        public string Phone { get => r_phone; set => r_phone = value; }
    }
}
