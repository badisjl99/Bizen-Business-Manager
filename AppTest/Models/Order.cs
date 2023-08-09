namespace AppTest.Models
{
    internal class Order
    {
        public string Ref { get; set; }
        public string Client { get; set; }
        public string Product { get; set; }
        public string Inventory { get; set; }
        public string ShippingAddress { get; set; }
        public string Date { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }
        public double Price { get; set; }


        public Order(string Ref, string client, string prod, string inventory, string address, string date, int qte)
        {

            this.Ref = Ref;
            this.Client = client;
            this.Date = date;
            this.Product = prod;
            this.Inventory = inventory;
            this.ShippingAddress = address;
            this.Quantity = qte;
            this.TotalPrice = Price * qte;

        }

    }
}
