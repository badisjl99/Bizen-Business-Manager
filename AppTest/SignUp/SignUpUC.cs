using AppTest.AppLogin;
using AppTest.Models;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace AppTest.SignUp
{
    public partial class SignUpUC : UserControl
    {

        public Admin admin;

        public SignUpUC()
        {
            InitializeComponent();
        }


        private Admin getAdmin()
        {
            string email = EmailBox.Text;
            string name = NameBox.Text;
            string lastname = LastNameBox.Text;
            string birthdate = DateBox.Text;
            Image image = pictureBox.Image; // Corrected control name
       

            this.admin = new Admin
            {
                name = name,
                lastname = lastname,
                email = email,
                id = generateAdminID(),
                birthDate = birthdate,
                password = GeneratePassword(10),
                profilePicture = image
            };

            return this.admin;
        }


        private void VerifyButton_Click(object sender, EventArgs e)
        {
            admin = getAdmin();
            InsertAdminData(admin);
            SignUpForm.SendVerifyMail(admin);


             LoginForm login = new LoginForm();
            login.Show();

        }

        private string generateAdminID()
        {
            Random rand = new Random();
            int x = rand.Next(10001, 100000);

            return "#AD" + x;

        }
        private string GeneratePassword(int length)
        {
            Random rand = new Random();
            const string validChars = "abcdefgh.?ijklmno0123456789pqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789@#&$!";
            StringBuilder password = new StringBuilder(length);

            for (int i = 0; i < length; i++)
            {
                int index = rand.Next(validChars.Length);
                password.Append(validChars[index]);
            }

            return password.ToString();
        }

        private void InsertAdminData(Admin admin)
        {


            using (MySqlConnection connection = APP_CONFIGURATION.ESTABLISH_DB_CONNECTION())
            {
                try
                {

                    byte[] imageBytes = null;

                    if (admin.profilePicture != null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            admin.profilePicture.Save(ms, admin.profilePicture.RawFormat);
                            imageBytes = ms.ToArray();
                        }
                    }

                    string query = "INSERT INTO admin_tables (name, lastname, email, password, birthdate,picture,type, id) " +
               "VALUES (@name, @lastname, @email, @password, @birthdate,@picture, @type, @id)";


                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@name", admin.name);
                    command.Parameters.AddWithValue("@lastname", admin.lastname);
                    command.Parameters.AddWithValue("@email", admin.email);
                    command.Parameters.AddWithValue("@id", admin.id);
                    command.Parameters.AddWithValue("@birthdate", admin.birthDate);
                    command.Parameters.AddWithValue("@password", admin.password);
                    command.Parameters.AddWithValue("@type", "normal_staff");
                    command.Parameters.AddWithValue("@picture", imageBytes);
                    command.ExecuteNonQuery();

                    command.ExecuteNonQuery();

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                   
                }
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;
                    pictureBox.Image = Image.FromFile(imagePath);
                }
            }
        }
    }
}
