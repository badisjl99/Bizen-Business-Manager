using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTest.Models
{
    internal class Product
    {
        public string productName { get; set; }
        public string productDescription { get; set; }
        public string productCategory { get; set; }

        public Product(string productname ,string productCategory,string description )
        {

            this.productName = productname;
            this.productDescription = description;
            this.productCategory = productCategory;
        }



    }
}
