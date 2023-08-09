using System.Drawing;

namespace AppTest.Models
{
    public class Admin
    {
        public string name { get; set; }
        public string lastname { get; set; }
        public string id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string birthDate { get; set; }
        public Image profilePicture { get; set; }

        public Admin(string name, string lastanem, string email, string id, string pass, string dat)
        {

            this.name = name;
            this.lastname = lastanem;
            this.email = email;
            this.id = id;
            this.password = pass;
            this.birthDate = dat;
        }

        public Admin()
        {
        }

    }


}
