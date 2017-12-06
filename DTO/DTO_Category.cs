using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Category
    {
        private int category_id;
        private String category_name;

        public int Category_id { get => category_id; set => category_id = value; }
        public string Category_name { get => category_name; set => category_name = value; }

    }
}
