using AppTest.Tools;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace AppTest.Controllers
{
    public partial class OrdersUC : UserControl
    {
        public CreateOrderUC create = new CreateOrderUC();
        MySqlConnection DB_CONNECTION;
        public OrdersUC()
        {
            InitializeComponent();
            DisplayTable();
            SetLabels();
            OrdersTable.CellFormatting += OrdersTable_CellFormatting;
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            Container.Controls.Clear();

            create.AutoSize = true;

            create.Anchor = AnchorStyles.None;
            create.Dock = DockStyle.Fill;
            Container.Controls.Add(create);
        }

        private MySqlConnection Connect()
        {

            string connectionString = "server=localhost;user=root;password=;database=app_db;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            return connection;
        }

        private void UpdateLabelWithQuery(string query, Label label, bool isCurrency = false)
        {
            try
            {
                using (this.DB_CONNECTION = Connect())
                {
                    MySqlCommand command = new MySqlCommand(query, DB_CONNECTION);
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        if (isCurrency)
                        {
                            double value = Convert.ToDouble(result);
                            label.Text = $"{value.ToString("C")}"; // Display as currency
                        }
                        else
                        {
                            int intValue = Convert.ToInt32(result);
                            label.Text = intValue.ToString();
                        }
                    }
                    else
                    {
                        label.Text = isCurrency ? "$0" : "0";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SetLabels()
        {
            UpdateLabelWithQuery("SELECT COUNT(*) FROM orders_table;", TotalOrdersLabel);
            UpdateLabelWithQuery("SELECT SUM(quantity) FROM orders_table;", TotalSalesLabel);
            UpdateLabelWithQuery("SELECT SUM(total_price) FROM orders_table WHERE status = 1;", RevenuesLabel, true);
            UpdateLabelWithQuery("SELECT COUNT(*) FROM orders_table WHERE status = 1;", ApprovedLabel);
            UpdateLabelWithQuery("SELECT COUNT(*) FROM orders_table WHERE status = 0;", DeclinedLabel);
        }


        public void DisplayTable()
        {
            DataTable dataTable = new DataTable();

            this.DB_CONNECTION = Connect();
            string selectQuery = "SELECT * FROM orders_table;";
            MySqlCommand selectCommand = new MySqlCommand(selectQuery, DB_CONNECTION);
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(selectCommand);
            dataAdapter.Fill(dataTable);

            DB_CONNECTION.Close();

            // Display product names and categories in the DataGridView
            OrdersTable.DataSource = dataTable;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                string searchName = Search_Bar.Text;

                this.DB_CONNECTION = Connect();

                string query = "SELECT * FROM orders_table WHERE client LIKE @clients;";
                MySqlCommand command = new MySqlCommand(query, DB_CONNECTION);
                command.Parameters.AddWithValue("@clients", "%" + searchName + "%");

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Bind the DataTable to the DataGridView
                OrdersTable.DataSource = dataTable;

                DB_CONNECTION.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ApproveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (OrdersTable.SelectedRows.Count > 0)
                {
                    int selectedIndex = OrdersTable.SelectedRows[0].Index;
                    string id = OrdersTable.Rows[selectedIndex].Cells["REF"].Value.ToString();
                    this.DB_CONNECTION = Connect();

                    // First, we retrieve the current status of the selected order
                    string query = "SELECT status FROM orders_table WHERE REF = @id;";
                    MySqlCommand command = new MySqlCommand(query, DB_CONNECTION);
                    command.Parameters.AddWithValue("@id", id);


                    bool currentStatus = Convert.ToBoolean(command.ExecuteScalar());


                    bool newStatus = !currentStatus;

                    // Update the 'status' column with the new value
                    query = "UPDATE orders_table SET status = @newStatus WHERE REF = @id;";
                    command = new MySqlCommand(query, DB_CONNECTION);
                    command.Parameters.AddWithValue("@newStatus", newStatus);
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();

                    DB_CONNECTION.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OrdersTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == OrdersTable.Columns["status"].Index)
            {
                DataGridViewCell cell = OrdersTable.Rows[e.RowIndex].Cells[e.ColumnIndex];
                bool statusValue = Convert.ToBoolean(e.Value);

                if (statusValue)
                {
                    cell.Style.BackColor = Color.Green;
                    cell.Style.ForeColor = Color.White;
                }
                else
                {
                    cell.Style.BackColor = Color.Red;
                    cell.Style.ForeColor = Color.White;
                }
            }
        }

        private void DeclineButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (OrdersTable.SelectedRows.Count > 0)
                {
                    int selectedIndex = OrdersTable.SelectedRows[0].Index;
                    string id = OrdersTable.Rows[selectedIndex].Cells["REF"].Value.ToString();
                    this.DB_CONNECTION = Connect();

                    // First, we retrieve the current status of the selected order
                    string query = "SELECT status FROM orders_table WHERE REF = @id;";
                    MySqlCommand command = new MySqlCommand(query, DB_CONNECTION);
                    command.Parameters.AddWithValue("@id", id);


                    bool currentStatus = Convert.ToBoolean(command.ExecuteScalar());


                    bool newStatus = !currentStatus;

                    // Update the 'status' column with the new value
                    query = "UPDATE orders_table SET status = @newStatus WHERE REF = @id;";
                    command = new MySqlCommand(query, DB_CONNECTION);
                    command.Parameters.AddWithValue("@newStatus", newStatus);
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();

                    DB_CONNECTION.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
