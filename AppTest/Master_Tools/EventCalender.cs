
using AppTest.Tools;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTest.Master_Tools
{
    public partial class EventCalender : UserControl
    {
        MySqlConnection connection;
        public EventCalender()
        {
            InitializeComponent();
            InitializeEvents();
            InitilizeEventsTable();

        }

        private void InitilizeEventsTable()
        {
            // Create a DataTable to hold the data
            DataTable dataTable = new DataTable();

            // Define the columns for the DataTable
            dataTable.Columns.Add("event_name", typeof(string));
            dataTable.Columns.Add("event_date", typeof(DateTime));
            dataTable.Columns.Add("event_desc", typeof(string));
            dataTable.Columns.Add("event_type", typeof(string));

            // Establish a database connection
            using (connection = APP_CONFIGURATION.ESTABLISH_DB_CONNECTION())
            {
               
                string query = "SELECT event_name, event_date, event_desc, event_type FROM events_table";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Read data from the database and add it to the DataTable
                        while (reader.Read())
                        {
                            string eventName = reader["event_name"].ToString();
                            DateTime eventDate = Convert.ToDateTime(reader["event_date"]);
                            string eventDesc = reader["event_desc"].ToString();
                            string eventType = reader["event_type"].ToString();

                            // Add a new row to the DataTable
                            dataTable.Rows.Add(eventName, eventDate, eventDesc, eventType);
                        }
                    }
                }
            }

            // Bind the DataTable to the DataGridView
            dataGridView1.DataSource = dataTable;
        }
        private void InitializeEvents()
        {
            connection = APP_CONFIGURATION.ESTABLISH_DB_CONNECTION();

            string query = "SELECT event_name, event_date, event_desc,event_type FROM events_table";
            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string eventName = reader["event_name"].ToString();
                        string eventType = reader["event_type"].ToString();
                        string eventDesc = reader["event_desc"].ToString();
                        DateTime eventDate = Convert.ToDateTime(reader["event_date"]);
                        Color color;

                        if (eventType.Equals("Important"))
                        {
                            color = Color.Pink;
                        }else if (eventType.Equals("Meeting"))
                        {
                            color = Color.LightGreen;
                        }
                        else
                        {
                            color = Color.CadetBlue;
                        }


                        EventUC eventUC = new EventUC(eventName,color);

                        int columnIndex = (int)eventDate.DayOfWeek; 
                        int rowIndex = (eventDate.Hour - 8) / 2; 

                        if (columnIndex >= 0 && columnIndex < tableLayoutPanel1.ColumnCount &&
                            rowIndex >= 0 && rowIndex < tableLayoutPanel1.RowCount)
                        {
                            tableLayoutPanel1.Controls.Add(eventUC, columnIndex, rowIndex);
                        }
                    }
                }
            }

            // Subscribe to the DateChanged event of the MonthCalendar control
            monthCalendar1.DateChanged += monthCalendar1_DateChanged_1;
        }


        private void monthCalendar1_DateChanged_1(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = monthCalendar1.SelectionStart;
        }
    }


}
