namespace AppTest.Models
{
    public class Master : User
    {

        public string name { get; set; }
        public string lastname { get; set; }
        public string id { get; set; }
        public string email { get; set; }
        public string password { get; set; }



        public Master(string name, string lastanem, string email, string id, string pass)
        {
            this.name = name;
            this.lastname = lastanem;
            this.email = email;
            this.id = id;
            this.password = pass;
        }


        public Master()
        {

        }




    }



}
