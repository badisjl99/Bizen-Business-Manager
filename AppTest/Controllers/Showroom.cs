using AppTest.Tools;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AppTest.Controllers
{
    public partial class Showroom : UserControl
    {
        MySqlConnection connection;
        public Showroom()
        {
            InitializeComponent();
            addCardsToView();
        }



        public MySqlConnection EstablishConneection()
        {
            string connString = "server=localhost;user=root;password=;database=app_db;";
            connection = new MySqlConnection(connString);
            connection.Open();
            return connection;
        }


        public void addCardsToView()
        {
            // Clear the existing controls from the TablePanel
            TablePanel.Controls.Clear();

            // Retrieve product data from the database
            using (MySqlConnection conn = EstablishConneection())
            {
                string query = "SELECT pname, pdescription, pprice,pquantity, pimage FROM products_table";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string name = reader.GetString("pname");
                        string description = reader.GetString("pdescription");
                        int quantity = reader.GetInt32("pquantity");
                        decimal price = reader.GetDecimal("pprice");
                        byte[] imageData = (byte[])reader["pimage"];

                        // Convert byte array to Image
                        Image image;
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            image = Image.FromStream(ms);
                        }

                        // Format the price as a string
                        string priceString = price.ToString("0.00");

                        // Create a PRODUCT_CARD control and set its properties
                        PRODUCT_CARD card = new PRODUCT_CARD(name, description, priceString, image, quantity);

                        // Set AutoSize property to true
                        card.AutoSize = true;

                        // Add the PRODUCT_CARD control to TablePanel
                        TablePanel.Controls.Add(card);
                    }
                }
            }

            // Adjust the size and position of the controls in the TablePanel
            TablePanel.AutoScroll = false;

            int spacing = 10; // Set the desired spacing between cells
            int yPos = spacing;
            foreach (Control control in TablePanel.Controls)
            {
                control.Location = new Point(spacing, yPos);
                yPos += control.Height + spacing;
                control.Width = TablePanel.ClientSize.Width - 2 * spacing;
            }

            // Enable scrolling if the total height exceeds the visible area
            if (yPos > TablePanel.Height)
            {
                TablePanel.AutoScroll = true;
            }
            else
            {
                TablePanel.Height = yPos;
            }
        }



    }
}
