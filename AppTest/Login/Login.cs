using AppTest.Login;
using AppTest.Models;
using AppTest.SignUp;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AppTest.AppLogin
{
    public partial class LoginForm : Form
    {
        MySqlConnection DB_CONNECTION;

        public LoginForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string id = IdBox.Text;
            string password = PasswordBox.Text;

            if (!ToggleSwitch.Checked)
            {
                Admin admin = Authenticate(id, password);

                if (admin != null)
                {
                    this.Hide();
                    RequestsButton main = new RequestsButton(admin); // Pass the authenticated admin object
                    main.Show();
                }
                else
                {
                    MessageBox.Show("No Such Staff Member Found With Those Credentiels !!");
                }
            }
            else if (ToggleSwitch.Checked)
            {
                Admin adminM = AuthenticateMaster(id, password);


                if (adminM != null)
                {
                    this.Hide();
                    // RequestsButton main = new RequestsButton(admin); 
                    // main.Show();
                    MasterHome masterHome = new MasterHome(adminM);
                    masterHome.Show();

                }
                else
                {
                    MessageBox.Show("No Such Master Member Found With Those Credentiels !!");
                }

            }
            else
            {
                MessageBox.Show("Please Enter Credentiels");

            }


        }

        private Image byteArrayToImage(byte[] byteArray)
        {
            if (byteArray == null || byteArray.Length == 0)
                return null;

            using (MemoryStream memoryStream = new MemoryStream(byteArray))
            {
                return Image.FromStream(memoryStream);
            }
        }

        private Admin Authenticate(string id, string password)
        {
            this.DB_CONNECTION = APP_CONFIGURATION.ESTABLISH_DB_CONNECTION();
            string query = $"SELECT * FROM {APP_CONFIGURATION.ADMIN_TABLE} WHERE {APP_CONFIGURATION.ADMIN_ID_ATTRIBUT} = @id1 AND {APP_CONFIGURATION.ADMIN_PASSWORD_ATTRIBUT} = @pass and type='normal_staff' ";
            MySqlCommand command = new MySqlCommand(query, DB_CONNECTION);

            command.Parameters.AddWithValue("@id1", id);
            command.Parameters.AddWithValue("@pass", password);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    string adminId = reader.GetString("id");
                    string adminName = reader.GetString("name");
                    string adminLastName = reader.GetString("lastname");
                    string adminEmail = reader.GetString("email");

                    byte[] imageBytes = (byte[])reader["picture"];

                    Admin admin = new Admin
                    {
                        id = adminId,
                        name = adminName,
                        lastname = adminLastName,
                        email = adminEmail,
                        profilePicture = byteArrayToImage(imageBytes)
                    };

                    return admin;
                }
            }

            DB_CONNECTION.Close();

            return null;
        }



        private void JoinButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpForm sign = new SignUpForm();
            sign.Show();
        }

        private Admin AuthenticateMaster(string id, string password)
        {
            this.DB_CONNECTION = APP_CONFIGURATION.ESTABLISH_DB_CONNECTION();
            string query = $"SELECT * FROM {APP_CONFIGURATION.ADMIN_TABLE} WHERE {APP_CONFIGURATION.ADMIN_ID_ATTRIBUT} = @id1 AND {APP_CONFIGURATION.ADMIN_PASSWORD_ATTRIBUT} = @pass and type='master_staff'";
            MySqlCommand command = new MySqlCommand(query, DB_CONNECTION);

            command.Parameters.AddWithValue("@id1", id);
            command.Parameters.AddWithValue("@pass", password);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    string adminId = reader.GetString("id");
                    string adminName = reader.GetString("name");
                    string adminLastName = reader.GetString("lastname");
                    string adminEmail = reader.GetString("email");

                    byte[] imageBytes = (byte[])reader["picture"];

                    Admin admin = new Admin
                    {
                        id = adminId,
                        name = adminName,
                        lastname = adminLastName,
                        email = adminEmail,
                        profilePicture = byteArrayToImage(imageBytes)
                    };

                    return admin;
                }
            }

            DB_CONNECTION.Close();

            return null;
        }

        private void SwitchBetweenUsers(object sender, EventArgs e)
        {

            if (!ToggleSwitch.Checked)
            {
                SwitchLabel.Text = "Staff";


            }
            else if (ToggleSwitch.Checked)
            {
                SwitchLabel.Text = "Master";


            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (PasswordBox.UseSystemPasswordChar == true)
            {
                PasswordBox.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordBox.UseSystemPasswordChar = true;
            }
        }
    }
}
