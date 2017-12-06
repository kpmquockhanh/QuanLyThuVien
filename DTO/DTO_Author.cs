using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Author
    {
        private int author_id;
        private String author_name;

        public int Author_id { get => author_id; set => author_id = value; }
        public string Author_name { get => author_name; set => author_name = value; }

    }
}
