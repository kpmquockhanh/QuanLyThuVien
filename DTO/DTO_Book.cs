using System;

namespace DTO
{
    public class DTO_Book
    {
        private int b_ID;
        private DateTime b_publication_date;
        private String b_Name;
        private Double b_price;
        private int b_quantity;
        private int category_id;
        private int author_id;
        private int publisher_id;

        public DateTime Publication_date { get => b_publication_date; set => b_publication_date = value; }
        public double Price { get => b_price; set => b_price = value; }
        public int Quantity { get => b_quantity; set => b_quantity = value; }
        public int Category_id { get => category_id; set => category_id = value; }
        public int Author_id { get => author_id; set => author_id = value; }
        public int Publisher_id { get => publisher_id; set => publisher_id = value; }
        public string Name { get => b_Name; set => b_Name = value; }
        public int ID { get => b_ID; set => b_ID = value; }
    }
}
