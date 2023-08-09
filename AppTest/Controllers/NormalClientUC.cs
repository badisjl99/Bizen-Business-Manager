using AppTest.Models;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace AppTest.Controllers
{
    public partial class NormalClientUC : UserControl
    {
        MySqlConnection DB_CONNECTION;
        public NormalClientUC()
        {
            InitializeComponent();
            DB_CONNECTION = Connect();
            DisplayTable();
        }

        private void RegisterClientButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name = NameBox.Text;
                string lastname = LastNameBox.Text;
                string email = EmailBox.Text;
                string address = AddressBox.Text;
                decimal phoneNum = decimal.Parse(NumberBox.Text);
                string id = GetClientID();

                Normal_Client client = new Normal_Client(name, lastname, email, address, phoneNum, id);

                this.DB_CONNECTION = Connect();

                string requete = "insert into normal_clients_table(cname,clastname,cemail,caddress,cphonenumber,cid) values (@name,@lastname,@email,@address,@phone,@id)";
                MySqlCommand command = new MySqlCommand(requete, DB_CONNECTION);
                command.Parameters.AddWithValue("@name", client.ClientFirstName);
                command.Parameters.AddWithValue("@lastname", client.ClientLastName);
                command.Parameters.AddWithValue("@email", client.ClientEmail);
                command.Parameters.AddWithValue("@address", client.ClientAddress);
                command.Parameters.AddWithValue("@phone", client.ClientPhone);
                command.Parameters.AddWithValue("@id", client.id);
                command.ExecuteNonQuery();

                DB_CONNECTION.Close();

                ClearFields();
                DisplayTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static string GetClientID()
        {
            Random rand = new Random();
            int x = rand.Next(20000, 100000);
            return "CL" + x.ToString();
        }


        private void ClearFields()
        {
            NameBox.Clear();
            LastNameBox.Clear();
            EmailBox.Clear();
            AddressBox.Clear();
            NumberBox.Clear();
        }



        public void DisplayTable()
        {
            DataTable dataTable = new DataTable();

            this.DB_CONNECTION = Connect();
            string selectQuery = "SELECT * FROM normal_clients_table;";
            MySqlCommand selectCommand = new MySqlCommand(selectQuery, DB_CONNECTION);
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(selectCommand);
            dataAdapter.Fill(dataTable);

            DB_CONNECTION.Close();

            // Display product names and categories in the DataGridView
            dataGridView.DataSource = dataTable;
        }




        private MySqlConnection Connect()
        {

            string connectionString = "server=localhost;user=root;password=;database=app_db;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            return connection;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            Controls.Add(new ClientsUC());

        }
    }
}
