using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;


namespace AppTest.Controllers
{
    public partial class MailUC : UserControl
    {

        MySqlConnection connection;

        public MailUC()
        {
            InitializeComponent();
            StaffPic.Image = RequestsButton.admin.profilePicture;
            RetrieveReciepientsMails();
            DisplayMessages();
        }


        // Assuming MessagesTable is a DataGridView control and MessageContainer is a Panel control.
        public void DisplayMessages()
        {
            DataTable dataTable = new DataTable();
            MySqlConnection connection = APP_CONFIGURATION.ESTABLISH_DB_CONNECTION();

            // Use parameterized query to prevent SQL injection
            string selectQuery = "SELECT sender AS Sender, reciever AS Reciever, content AS MessageBody, date AS Date FROM messages WHERE sender = @email OR reciever = @email ORDER BY date DESC;";
            MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection);
            selectCommand.Parameters.AddWithValue("@email", RequestsButton.admin.email);

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(selectCommand);
            dataAdapter.Fill(dataTable);

            connection.Close();
            MessagesTable.DataSource = dataTable;

            // Add the event handler to the SelectionChanged event of the DataGridView
            MessagesTable.SelectionChanged += MessagesTable_SelectionChanged;
        }


        private void MessagesTable_SelectionChanged(object sender, EventArgs e)
        {

            if (MessagesTable.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = MessagesTable.SelectedRows[0];


                string sender1 = selectedRow.Cells["sender"].Value.ToString();
                string content = selectedRow.Cells["MessageBody"].Value.ToString();
                string date = selectedRow.Cells["date"].Value.ToString();
                string reciever = selectedRow.Cells["reciever"].Value.ToString();


                Message_DisplayUC messageDisplayUC = new Message_DisplayUC(sender1, content, date, reciever);


                MessageContainer.Controls.Clear();
                MessageContainer.Controls.Add(messageDisplayUC);
            }
        }



        private void SendMessage()
        {
            this.connection = APP_CONFIGURATION.ESTABLISH_DB_CONNECTION();

            string sender = RequestsButton.admin.email;
            string reciever = RecipientBox.Text;
            string content = MessageBody.Text;

            Message message = new Message(sender, reciever, content);

            string query1 = "insert into messages(sender , reciever,content,date,id) values (@sender ,@reciever,@content,@date,@id) ";


            MySqlCommand command = new MySqlCommand(query1, connection);
            command.Parameters.AddWithValue("@sender", message.MessageSender);
            command.Parameters.AddWithValue("@reciever", message.MessageReciver);
            command.Parameters.AddWithValue("@content", message.MessageContent);
            command.Parameters.AddWithValue("@date", message.MessageDate);
            command.Parameters.AddWithValue("@id", message.MessageID);

            command.ExecuteNonQuery();
            connection.Close();
        }


        public void RetrieveReciepientsMails()
        {
            MySqlConnection connection = APP_CONFIGURATION.ESTABLISH_DB_CONNECTION();
            string query = "SELECT email FROM admin_tables;";

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
            {
                try
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    RecipientBox.DisplayMember = "email";
                    RecipientBox.ValueMember = "email";
                    RecipientBox.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    // Handle any exceptions appropriately
                    MessageBox.Show("An error occurred: " + ex.Message);
                }

                MailsCount.Text = GetMailCountForRecipient().ToString();


            }

        }
        private void ClearFields()
        {

            MessageBody.Clear();


        }
        private void SendMessageButton_Click(object sender, EventArgs e)
        {
            SendMessage();
            DisplayMessages();
            ClearFields();
        }


        public int GetMailCountForRecipient()
        {
            int mailCount = 0;

            MySqlConnection connection = APP_CONFIGURATION.ESTABLISH_DB_CONNECTION();
            string countQuery = "SELECT COUNT(*) FROM messages WHERE reciever = @recipient";
            MySqlCommand countCommand = new MySqlCommand(countQuery, connection);
            countCommand.Parameters.AddWithValue("@recipient", RequestsButton.admin.email);

            try
            {
                mailCount = Convert.ToInt32(countCommand.ExecuteScalar());
            }
            catch (Exception ex)
            {
                // Handle any exceptions appropriately
                MessageBox.Show("An error occurred while getting mail count: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return mailCount;
        }
    }
}
