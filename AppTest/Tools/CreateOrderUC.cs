using AppTest.Controllers;
using AppTest.Models;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace AppTest.Tools
{
    public partial class CreateOrderUC : UserControl
    {
        MySqlConnection DB_CONNECTION;
        public CreateOrderUC()
        {
            InitializeComponent();
            RetrieveDataFromDB();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            try
            {
                string client = ClientBox.Text;
                string product = ProductsBox.Text;
                string shipping = ShippingBox.Text;
                string date = DateBox.Text;
                string inventory = InventoryBox.Text;
                int qte = int.Parse(QuantityBox.Text);
                double Tprice = 0.0;
                string Ref = GenerateOrderREF();

                Order order = new Order(Ref, client, product, inventory, shipping, date, qte);

                DB_CONNECTION = Connect();

                string priceQuery = "select pprice from products_table where pname = @prodname ; ";
                using (MySqlCommand command1 = new MySqlCommand(priceQuery, DB_CONNECTION))
                {
                    command1.Parameters.AddWithValue("@prodname", order.Product);
                    object result = command1.ExecuteScalar();

                    // Step 5: Parse the result to a double variable
                    if (result != null && double.TryParse(result.ToString(), out double price))
                    {
                        Tprice = price;
                        // Calculate the total price based on quantity
                        order.TotalPrice = Tprice * qte;
                    }
                    else
                    {
                        MessageBox.Show("No Price Error !!! X");
                    }

                    string query = "INSERT INTO orders_table (REF, Client, Product, Inventory, Shipping_Adress, Date, Quantity, Total_Price) VALUES (@ref, @client, @product, @inventory, @address, @date, @quantity, @tprice);";
                    MySqlCommand command = new MySqlCommand(query, DB_CONNECTION);
                    command.Parameters.AddWithValue("@ref", order.Ref);
                    command.Parameters.AddWithValue("@client", order.Client);
                    command.Parameters.AddWithValue("@product", order.Product);
                    command.Parameters.AddWithValue("@inventory", order.Inventory);
                    command.Parameters.AddWithValue("@address", order.ShippingAddress);
                    command.Parameters.AddWithValue("@date", order.Date);
                    command.Parameters.AddWithValue("@quantity", order.Quantity);
                    command.Parameters.AddWithValue("@tprice", order.TotalPrice);

                    command.ExecuteNonQuery();

                    // Close the database connection
                    DB_CONNECTION.Close();

                    // Send the email to the selected client
                    SendOrderConfirmationEmail(order);

                    MessageBox.Show("Ordered Successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occurred: " + ex.Message);
            }
        }

        private void SendOrderConfirmationEmail(Order order)
        {
            try
            {
                // Here, you will need to configure your SMTP settings (SMTP server, port, username, password, etc.)
                // Replace 'your_smtp_server', 'your_port', 'your_username', and 'your_password' with appropriate values.
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587)
                {
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential("syst.mailer.manager@gmail.com", "ayybwnlbyztcbdnb"),
                    EnableSsl = true // Use SSL if required by your email server
                };

                // Replace 'from_email_address' with your actual email address
                MailMessage mailMessage = new MailMessage("syst.mailer.manager@gmail.com", GetClientEmail(order.Client))
                {
                    Subject = "Order Confirmation",
                    Body = $"Dear {order.Client},\n\nThank you for your order. We have received your order with reference: {order.Ref}.\n\n" +
                           $"Product: {order.Product}\n" +
                           $"Quantity: {order.Quantity}\n" +
                           $"Total Price: {order.TotalPrice}\n\n" +
                           "Thank you for choosing our service. If you have any questions, feel free to contact us.\n\n" +
                           "Best Regards,\nYour Company"
                };

                smtpClient.Send(mailMessage);
            }
            catch (Exception ex)
            {
                // Handle any errors that might occur during email sending
                MessageBox.Show("Error Occurred while sending the email: " + ex.Message);
            }
        }
        private string GetClientEmail(string clientFullName)
        {
            string[] names = clientFullName.Split(' ');
            string firstName = names[0];
            string lastName = names[1];

            string clientEmail = null;

            try
            {
                DB_CONNECTION = Connect();

                string query = "SELECT cemail FROM normal_clients_table WHERE cname = @firstName AND clastname = @lastName;";
                using (MySqlCommand command = new MySqlCommand(query, DB_CONNECTION))
                {
                    command.Parameters.AddWithValue("@firstName", firstName);
                    command.Parameters.AddWithValue("@lastName", lastName);
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        clientEmail = result.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Client not found in the database.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while fetching the client's email: " + ex.Message);
            }
            finally
            {
                // Make sure to close the database connection after using it
                DB_CONNECTION.Close();
            }

            return clientEmail;
        }


        public void RetrieveDataFromDB()
        {

            string query = "SELECT pname FROM products_table;";
            string queryClients = "SELECT CONCAT(cname, ' ', clastname) AS full_name FROM normal_clients_table;";


            using (MySqlConnection connection = APP_CONFIGURATION.ESTABLISH_DB_CONNECTION())
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                {
                    try
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        ProductsBox.DisplayMember = "pname";
                        ProductsBox.ValueMember = "pname";
                        ProductsBox.DataSource = dataTable;

                    }
                    catch (Exception ex)
                    {
                        // Handle any exceptions appropriately
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(queryClients, connection))
                {
                    try
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        ClientBox.DisplayMember = "full_name";
                        ClientBox.ValueMember = "full_name";
                        ClientBox.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        // Handle any exceptions appropriately
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }

                string adressQuery = "select caddress from normal_clients_table ; ";
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(adressQuery, connection))
                {
                    try
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        ShippingBox.DisplayMember = "caddress";
                        ShippingBox.ValueMember = "caddress";
                        ShippingBox.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        // Handle any exceptions appropriately
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
                string inventoryQuery = "select name from inventories_table ; ";
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(inventoryQuery, connection))
                {
                    try
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        InventoryBox.DisplayMember = "name";
                        InventoryBox.ValueMember = "name";
                        InventoryBox.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        // Handle any exceptions appropriately
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }


            }
        }



        private string GenerateOrderREF()
        {
            Random random = new Random();
            int x = random.Next(1000, 9999);

            return "#REF" + x + "RQ";
        }
        private MySqlConnection Connect()
        {

            string connectionString = "server=localhost;user=root;password=;database=app_db;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            return connection;
        }

        private void UndoButton_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            Controls.Add(new OrdersUC());
        }
    }
}
