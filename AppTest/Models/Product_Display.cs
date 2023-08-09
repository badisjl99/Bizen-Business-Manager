using System.Drawing;

namespace AppTest.Models
{
    internal class Product_Display
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public Image Image { get; set; }



        public Product_Display(string name, string description, string price, Image image)
        {

            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.Image = image;

        }



    }
}
