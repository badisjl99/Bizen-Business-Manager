using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using MySql.Data.MySqlClient;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AppTest.Master_Tools
{
    public partial class MasterDashboardUC : UserControl
    {

        MySqlConnection connection;

        public MasterDashboardUC()
        {
            InitializeComponent();
            UpdateLabels();
            UpdateToDoGauge();
            InitializePieChart();
        }


        private void InitializePieChart()
        {
            connection = APP_CONFIGURATION.ESTABLISH_DB_CONNECTION();

            // Query to get the count of each product category
            string query = "SELECT pcategory, COUNT(*) as categoryCount FROM products_table GROUP BY pcategory";

            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();

            SeriesCollection pieSeries = new SeriesCollection();

            while (reader.Read())
            {
                string category = reader["pcategory"].ToString();
                int categoryCount = Convert.ToInt32(reader["categoryCount"]);

                // Create a pie chart segment for each category
                pieSeries.Add(new PieSeries
                {
                    Title = category,
                    Values = new ChartValues<int> { categoryCount }
                });
            }

            // Bind the pieSeries to the CategoryPieChart
            CategoryPieChart.Series = pieSeries;

            connection.Close();
        
        }


        private void UpdateToDoGauge()
        {
           
                    ToDoGauge.To = 50;
                    ToDoGauge.Value = 5;
         
            
        }
        private void UpdateLabels()
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

            query = "SELECT COUNT(*) FROM products_table";

            using (MySqlCommand command2 = new MySqlCommand(query, connection))
            {
                // Execute the query and retrieve the result
                int productsCount = Convert.ToInt32(command2.ExecuteScalar());

                // Update the label with the client count
                ProductCount.Text = productsCount.ToString();
            }

            query = "SELECT COUNT(*) FROM admin_tables where type ='normal_staff'";

            using (MySqlCommand command3 = new MySqlCommand(query, connection))
            {
                // Execute the query and retrieve the result
                int staffcount = Convert.ToInt32(command3.ExecuteScalar());

                // Update the label with the client count
                TotalStaffLabel.Text = staffcount.ToString();
            }

            query = "SELECT COUNT(*) FROM normal_clients_table";

            using (MySqlCommand command4 = new MySqlCommand(query, connection))
            {
                // Execute the query and retrieve the result
                int clientCount = Convert.ToInt32(command4.ExecuteScalar());

                // Update the label with the client count
                ClientsCount.Text = clientCount.ToString();
            }
        }
    }
}
