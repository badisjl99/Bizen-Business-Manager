using AppTest.Tools;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AppTest.Controllers
{
    public partial class TrendsUC : UserControl
    {
        public TrendsUC()
        {
            InitializeComponent();
            AddImageToView();
        }

        private void AddImageToView()
        {
            TablePanel.Controls.Clear();

            // Retrieve product data from the database
            using (MySqlConnection conn = APP_CONFIGURATION.ESTABLISH_DB_CONNECTION())
            {
                string query = "SELECT name, price,image FROM trends_data";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string name = reader.GetString("name");

                        string price = reader.GetString("price");
                        byte[] imageData = (byte[])reader["image"];

                        // Convert byte array to Image
                        Image image;
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            image = Image.FromStream(ms);
                        }

                        // Format the price as a string


                        // Create a PRODUCT_CARD control and set its properties
                        TrendItemUC item = new TrendItemUC(name, price, image);

                        // Set AutoSize property to true
                        item.AutoSize = true;

                        // Add the PRODUCT_CARD control to TablePanel
                        TablePanel.Controls.Add(item);
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
