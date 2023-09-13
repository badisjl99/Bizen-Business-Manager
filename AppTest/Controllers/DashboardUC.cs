using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AppTest.Controllers
{
    public partial class DashboardUC : UserControl
    {

       

        MySqlConnection connection;
        public DashboardUC()
        {
            InitializeComponent();
            UpdateClientCountLabel();
            UpdateProductsCountLabel();
            ShowMAP();
            ProgessBarActions();
            GetToDoList();
        }

        private void ElementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void DashboardUC_Load(object sender, EventArgs e)
        {
            UpdateClientCountLabel();
            UpdateProductsCountLabel();
            ProgessBarActions();
        }

        private void UpdateClientCountLabel()
        {


            connection = APP_CONFIGURATION.ESTABLISH_DB_CONNECTION();


            string query = "SELECT COUNT(*) FROM normal_clients_table";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                // Execute the query and retrieve the result
                int clientCount = Convert.ToInt32(command.ExecuteScalar());

                // Update the label with the client count
                ClientsCount.Text = clientCount.ToString();
            }
        }

        private int UpdateProductsCountLabel()
        {

            connection = APP_CONFIGURATION.ESTABLISH_DB_CONNECTION();

            string query = "SELECT COUNT(*) FROM products_table";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                // Execute the query and retrieve the result
                int productsCount = Convert.ToInt32(command.ExecuteScalar());

                // Update the label with the client count
                ProductCount.Text = productsCount.ToString();

                return productsCount;
            }
        }


        private void ProgessBarActions()
        {

            int value = UpdateProductsCountLabel();

            progressBar.Maximum = 30;
            progressBar.Value = value;

        }
        private int CountTasksWithStatusOne()
        {
            string query = "SELECT COUNT(*) FROM to_do_tables WHERE assigned_to = @user AND status = 1;";
            using (MySqlConnection connection = APP_CONFIGURATION.ESTABLISH_DB_CONNECTION())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@user", RequestsButton.admin.email);

                try
                {
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return 0;
                }
            }
        }

        private void GetToDoList()
        {
            string query = "SELECT task, status FROM to_do_tables WHERE assigned_to = @user ORDER BY status DESC LIMIT 4;";
            using (MySqlConnection connection = APP_CONFIGURATION.ESTABLISH_DB_CONNECTION())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@user", RequestsButton.admin.email);

                try
                {
                    int row = 0;
                    int totalTasks = 4; // Total number of tasks
                    int statusOneCount = 0; // Initialize the count of tasks with status one

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string task = reader["task"].ToString();
                            bool status = Convert.ToBoolean(reader["status"]);

                            // Determine the label and checkbox to assign the task and status based on the current row
                            Label label;
                            CheckBox checkBox;
                            switch (row)
                            {
                                case 0:
                                    label = TDL1;
                                    checkBox = checkBox1;
                                    break;
                                case 1:
                                    label = TDL2;
                                    checkBox = checkBox2;
                                    break;
                                case 2:
                                    label = TDL3;
                                    checkBox = checkBox3;
                                    break;
                                case 3:
                                    label = TDL4;
                                    checkBox = checkBox4;
                                    break;
                                default:
                                    // Handle the case where there are more than 4 rows if needed
                                    return;
                            }

                            label.Text = task;
                            checkBox.Checked = status;

                            // Use strikethrough font for completed tasks
                            label.Font = status ? new Font(label.Font, FontStyle.Strikeout) : new Font(label.Font, FontStyle.Regular);

                            // Set the back color of the label based on the status
                            label.BackColor = status ? Color.LightPink : Color.LightSteelBlue;

                            // Increment the statusOneCount if the status is 1
                            if (status)
                            {
                                statusOneCount++;
                            }

                            row++;
                        }
                    }

                    // Calculate the percentage of completion
                    int percentage = (statusOneCount * 100) / totalTasks;

                    // Set the value of the circular progress bar
                    circularProgressBar.Value = percentage;

                    Font progressBarFont = new Font(circularProgressBar.Font.FontFamily, 15, FontStyle.Bold);
                    circularProgressBar.Font = progressBarFont;

                    circularProgressBar.Text = percentage.ToString() + "%";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }






        public void UpdateCapacityLabel()
        {

            string connectionString = "server=localhost;user=root;password=;database=app_db;";
            connection = new MySqlConnection(connectionString);
            connection.Open();

            string query = "SELECT SUM(capacity) AS total_capacity FROM inventories_table;";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                // Execute the query and retrieve the result
                int cap = Convert.ToInt32(command.ExecuteScalar());

            }
        }





        private void ShowMAP()
        {
            ClientsMap clientsMap = new ClientsMap();
            MapPanel.Controls.Add(clientsMap);


        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            GetToDoList();
        }

    }
}
