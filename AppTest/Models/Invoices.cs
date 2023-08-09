using System;

namespace AppTest.Models
{
    internal class Invoices
    {

        public string id;
        public string product;
        public string client;
        public DateTime date;
        public int quantity;

        public Invoices(string prod, string client, int quantity, DateTime date, string id)
        {

            this.client = client;
            this.id = id;
            this.product = prod;
            this.date = date;
            this.quantity = quantity;


        }
    }
}
