using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace AppTest.Controllers
{
    public partial class InventoryUC : UserControl
    {
        MySqlConnection DB_CONNECTION;

        public InventoryUC()
        {
            InitializeComponent();
            DisplayTable();
            UpdateCapacityLabel();
        }

        private void InventoryUC_Load(object sender, EventArgs e)
        {
            // DisplayTable();
        }

        private void RegisterInventoryButton(object sender, EventArgs e)
        {
            Container.Controls.Clear();

            RegisterInventoryUC registerInventoryUC = new RegisterInventoryUC();
            Container.Controls.Add(registerInventoryUC);
        }



        public void DisplayTable()
        {
            DataTable dataTable = new DataTable();

            this.DB_CONNECTION = Connect();
            string selectQuery = "SELECT * FROM inventories_table;";
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

        public void UpdateCapacityLabel()
        {

            string connectionString = "server=localhost;user=root;password=;database=app_db;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string query = "SELECT SUM(capacity) AS total_capacity FROM inventories_table;";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                // Execute the query and retrieve the result
                int cap = Convert.ToInt32(command.ExecuteScalar());

                // Update the label with the client count
                OverallCapacityCount.Text = cap.ToString();

            }
        }


    }
}
