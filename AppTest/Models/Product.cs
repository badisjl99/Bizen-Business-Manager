using System;

namespace AppTest.Models
{
    internal class Product
    {

        public string productName { get; set; }
        public string productDescription { get; set; }
        public string productCategory { get; set; }
        public string id { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }

        public Product(string productname, string productCategory, string description, double price, int quantity, string id)
        {

            this.productName = productname;
            this.productDescription = description;
            this.quantity = quantity;
            this.productCategory = productCategory;
            this.id = id;
            this.price = price;
        }


        public static string generateID()
        {
            Random random = new Random();
            int randomNumber = random.Next(1000, 10000);
            string randomString = randomNumber.ToString();
            return "#P" + randomString;
        }

    }
}

