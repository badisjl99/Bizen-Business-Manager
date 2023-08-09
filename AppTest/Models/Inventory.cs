namespace AppTest.Models
{
    internal class Inventory
    {


        public string InventoryName { get; set; }
        public string InventoryType { get; set; }
        public string InventoryLocation { get; set; }
        public int InventoryCapacity { get; set; }

        public Inventory(string name, string type, string location, int capacity)
        {

            this.InventoryName = name;
            this.InventoryType = type;
            this.InventoryLocation = location;
            this.InventoryCapacity = capacity;


        }



    }
}
