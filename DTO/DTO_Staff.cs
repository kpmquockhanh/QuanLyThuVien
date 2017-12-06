using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Staff
    {
        private int s_ID;
        private String s_password;
        private String s_name;
        private String s_addr;
        private String s_email;
        private String s_phone;

        public int ID { get => s_ID; set => s_ID = value; }
        public string Password { get => s_password; set => s_password = value; }
        public string Name { get => s_name; set => s_name = value; }
        public string Addr { get => s_addr; set => s_addr = value; }
        public string Email { get => s_email; set => s_email = value; }
        public string Phone { get => s_phone; set => s_phone = value; }
    }
}
