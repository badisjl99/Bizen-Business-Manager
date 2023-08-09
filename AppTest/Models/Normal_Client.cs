using System;

namespace AppTest.Models
{
    internal class Normal_Client : Client
    {

        public string id { get; set; }

        public Normal_Client(string clientFirstName, string clientLastName, string clientEmail, string clientAddress, decimal clientPhone, string id)
            : base(clientFirstName, clientLastName, clientEmail, clientAddress, clientPhone)
        {
            this.id = getClientID();

        }


        public static string getClientID()
        {
            Random rand = new Random();

            decimal x = rand.Next(20000, 100000);

            return "CL" + x;
        }

    }
}
