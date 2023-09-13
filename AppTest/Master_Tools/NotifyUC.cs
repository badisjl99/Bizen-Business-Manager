using AppTest.Login;
using AppTest.Models;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;


namespace AppTest.Master_Tools
{
    public partial class NotifyUC : UserControl
    {
        MySqlConnection DB_CONNECTION;


        public NotifyUC()
        {
            InitializeComponent();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                string name = NameBox.Text;
                string type = TypeBox.Text;
                DateTime date = DateBox.Value;
                string description = NoteRichBox.Text;

                Event event1 = new Event(name, type, description, date);
                string id = event1.Event_ID;


                DB_CONNECTION = APP_CONFIGURATION.ESTABLISH_DB_CONNECTION();

                string sql = "insert events_table(event_name,event_type,event_desc,event_date,event_id) values(@name,@type,@desc,@date,@id)";
                MySqlCommand command = new MySqlCommand(sql, DB_CONNECTION) ;
                command.Parameters.AddWithValue("@name", event1.Event_Name) ;
                command.Parameters.AddWithValue("@type", event1.Event_Type) ;
                command.Parameters.AddWithValue("@desc", event1.Event_Description) ;
                command.Parameters.AddWithValue("@date", event1.Event_Date) ;
                command.Parameters.AddWithValue("@id", event1.Event_ID) ;
                command.ExecuteNonQuery() ;
                DB_CONNECTION.Close() ;
                ClearFields() ;

                System.Windows.MessageBox.Show("Event Added Successfully ! ");

            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }


        }
        private void ClearFields()
        {
            NameBox.Clear();
            NoteRichBox.Clear();
            
        }
    }
}
