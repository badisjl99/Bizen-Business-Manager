namespace AppTest.Models
{
    internal abstract class Client
    {
        protected Client()
        {
        }

        public string ClientLastName { get; set; }
        public string ClientFirstName { get; set; }
        public string ClientEmail { get; set; }
        public string ClientAddress { get; set; }
        public decimal ClientPhone { get; set; }



        protected Client(string clientFirstName, string clientLastName, string clientEmail, string clientAddress, decimal clientPhone)
        {
            ClientLastName = clientLastName;
            ClientFirstName = clientFirstName;
            ClientEmail = clientEmail;
            ClientAddress = clientAddress;
            ClientPhone = clientPhone;
        }



    }
}
