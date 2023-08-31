using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace AppTest.Master_Tools
{
    public partial class MasterDashboardUC : UserControl
    {

        MySqlConnection connection;
        public MasterDashboardUC()
        {
            InitializeComponent();
            UpdateClientCountLabel();
            UpdateProductsCountLabel();
            UpdateStaffCountLabel();
            UpdateRevenuesLabel();
            UpdateToDoGauge();
        }

        private void UpdateToDoGauge()
        {
            ToDoGauge.To = 50;
            ToDoGauge.Value = 100;
        }

        private void UpdateRevenuesLabel()
        {

            connection = APP_CONFIGURATION.ESTABLISH_DB_CONNECTION();

            string query = "SELECT SUM(total_price) FROM orders_table where status=1;";
            MySqlCommand command = new MySqlCommand(query, connection);

            object result = command.ExecuteScalar();

            // Check if the result is DBNull or null
            if (result != null && result != DBNull.Value)
            {
                double totalSales = Convert.ToDouble(result);
                RevenuesLabel.Text = $"{totalSales.ToString()} $";
            }
            else
            {
                // If there are no orders or quantity is NULL, display 0
                RevenuesLabel.Text = "0";
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

        private void UpdateStaffCountLabel()
        {


            connection = APP_CONFIGURATION.ESTABLISH_DB_CONNECTION();
            string query = "SELECT COUNT(*) FROM admin_tables where type ='normal_staff'";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                // Execute the query and retrieve the result
                int staffcount = Convert.ToInt32(command.ExecuteScalar());

                // Update the label with the client count
                TotalStaffLabel.Text = staffcount.ToString();
            }
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

        
    }
}
