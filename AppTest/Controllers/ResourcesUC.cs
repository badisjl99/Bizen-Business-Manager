using AppTest.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using AppTest.Tools;

namespace AppTest.Controllers
{
    public partial class ResourcesUC : UserControl
    {

        MySqlConnection DB_CONNECTION;
        public ResourcesUC()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string name = NameBox.Text;
            string category = CategoryBox.Text;
            string description = DescriptionBox.Text;

            Product product = new Product(name, category, description);

            this.DB_CONNECTION = connect();

            string query = "INSERT INTO products_table (pname, pcategory, pdescription) VALUES (@name, @category, @description);";
            MySqlCommand command = new MySqlCommand(query, DB_CONNECTION);
            command.Parameters.AddWithValue("@name", product.productName);
            command.Parameters.AddWithValue("@category", product.productCategory);
            command.Parameters.AddWithValue("@description", product.productDescription);
            command.ExecuteNonQuery();

            DB_CONNECTION.Close();
            
            displayItems(1);


        }



        public void displayItems(int state)
        {

            if (state == 1)
            {

                ProductSuccessUC productSuccessUC = new ProductSuccessUC();
                ItemsContainer.Controls.Add(productSuccessUC);

                // Set the timer to hide the control after 3 seconds
                System.Timers.Timer timer = new System.Timers.Timer(2000);
                timer.Elapsed += (s, args) =>
                {
                    timer.Stop();
                    this.Invoke((MethodInvoker)delegate
                    {
                        ItemsContainer.Controls.Remove(productSuccessUC);
                    });
                };
                timer.Start();


            }

            else {
                Console.WriteLine("Error");

            }




        } 







        private void BrowseButton_Click(object sender, EventArgs e)
        {
        
        }


        private MySqlConnection connect()
        {

            string connectionString = "server=localhost;user=root;password=;database=app_db;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            return connection;
        }


        private void BrowseButton_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;
                    pictureBox.Image = Image.FromFile(imagePath);
                }
            }

        }
    }
}
