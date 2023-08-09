using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using Task = AppTest.Models.Task;

namespace AppTest.Master_Tools
{
    public partial class AssignTasksUC : UserControl
    {
        private MySqlConnection connection;

        public AssignTasksUC()
        {
            InitializeComponent();
            RetrieveStaffNames();
            DisplayTable();
        }

        public void RetrieveStaffNames()
        {
            MySqlConnection connection = APP_CONFIGURATION.ESTABLISH_DB_CONNECTION();
            string query = "SELECT CONCAT(name, ' ', lastname) AS full_name FROM admin_tables WHERE type = 'normal_staff';";

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
            {
                try
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    StaffBox.DisplayMember = "full_name";
                    StaffBox.ValueMember = "full_name";
                    StaffBox.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    // Handle any exceptions appropriately
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
        private void AssignButton_Click(object sender, EventArgs e)
        {
            try
            {
                string task = TaskBox.Text;
                string assignedto = StaffBox.Text;

                // Split the concatenated name into first name and last name
                string[] names = assignedto.Split(' ');
                string firstName = names[0];
                string lastName = names[1];

                // Query the database to find the email for the given first name and last name
                string email = GetStaffEmailFromDatabase(firstName, lastName);

                Task task1 = new Task(task, email); // Use the email instead of full name

                MySqlConnection connection = APP_CONFIGURATION.ESTABLISH_DB_CONNECTION();
                string query = "insert into to_do_tables(id,task,assigned_to,status) values(@id,@task,@assigned_to,@status);";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", task1.Id);
                command.Parameters.AddWithValue("@task", task1.task);
                command.Parameters.AddWithValue("@assigned_to", task1.assigned_to);
                command.Parameters.AddWithValue("@status", task1.status);
                command.ExecuteNonQuery();

                connection.Close();
                DisplayTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string GetStaffEmailFromDatabase(string firstName, string lastName)
        {
            string email = "";

            try
            {
                MySqlConnection connection = APP_CONFIGURATION.ESTABLISH_DB_CONNECTION();
                string query = "SELECT email FROM admin_tables WHERE name = @firstName AND lastname = @lastName;";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@firstName", firstName);
                command.Parameters.AddWithValue("@lastName", lastName);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        email = reader["email"].ToString();
                    }
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return email;
        }

        public void DisplayTable()
        {
            DataTable dataTable = new DataTable();

            this.connection = APP_CONFIGURATION.ESTABLISH_DB_CONNECTION();
            string selectQuery = "SELECT task as Task , assigned_to as Memeber,status as Status,id as ID FROM to_do_tables;";
            MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection);
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(selectCommand);
            dataAdapter.Fill(dataTable);

            connection.Close();

            // Display product names and categories in the DataGridView
            dataGridView.DataSource = dataTable;
        }

        private void ApproveTaskButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                string taskId = dataGridView.SelectedRows[0].Cells["ID"].Value.ToString();
                UpdateTaskStatus(taskId, 1); // Update status to 1
                DisplayTable(); // Refresh the DataGridView
            }
            else
            {
                MessageBox.Show("Please select a row to approve.");
            }
        }

        private void UpdateTaskStatus(string taskId, int newStatus)
        {
            try
            {
                MySqlConnection connection = APP_CONFIGURATION.ESTABLISH_DB_CONNECTION();
                string query = "UPDATE to_do_tables SET status = @status WHERE id = @taskId;";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@status", newStatus);
                command.Parameters.AddWithValue("@taskId", taskId);
                command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DeleteTask(string taskId)
        {
            try
            {
                MySqlConnection connection = APP_CONFIGURATION.ESTABLISH_DB_CONNECTION();
                string query = "DELETE FROM to_do_tables WHERE id = @taskId;";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@taskId", taskId);
                command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                string taskId = dataGridView.SelectedRows[0].Cells["ID"].Value.ToString();
                DeleteTask(taskId); // Delete the selected task
                DisplayTable(); // Refresh the DataGridView
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }
    }
}