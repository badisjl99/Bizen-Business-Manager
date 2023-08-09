using AppTest.Models;
using AppTest.Tools;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AppTest.Controllers
{
    public partial class ResourcesUC : UserControl
    {

        MySqlConnection DB_CONNECTION;
        public ResourcesUC()
        {
            InitializeComponent();
            SetGridStyle();
            DisplayTable();
        }

        private void SetGridStyle()
        {
            // Change cell font style
            dataGridView.DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dataGridView.AllowUserToResizeColumns = false;
            // Change cell background color
            dataGridView.DefaultCellStyle.BackColor = Color.LightYellow;

            // Change cell text color
            dataGridView.DefaultCellStyle.ForeColor = Color.Black;// Change row height
            dataGridView.RowTemplate.Height = 30;

            // Change row header text color
            dataGridView.RowHeadersDefaultCellStyle.ForeColor = Color.Red;

            // Change selected row color
            dataGridView.RowsDefaultCellStyle.SelectionBackColor = Color.LightGray;

        }

        private void Guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = NameBox.Text;
                string category = CategoryBox.Text;
                string description = DescriptionBox.Text;
                double price = Double.Parse(PriceBox.Text);
                string id = Product.generateID();
                int quant = int.Parse(QuantityBox.Text);

                Product product = new Product(name, category, description, price, quant, id);

                this.DB_CONNECTION = Connect();

                // Access the image from the pictureBox control
                Image image = pictureBox.Image;

                // Check if an image is present
                if (image != null)
                {
                    // Convert the image to a byte array
                    byte[] imageBytes;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        image.Save(ms, image.RawFormat);
                        imageBytes = ms.ToArray();
                    }

                    string query = "INSERT INTO products_table (pname, pcategory, pdescription, pprice,pquantity, id, pimage) VALUES (@name, @category, @description, @price,@quantity, @id, @image);";
                    MySqlCommand command = new MySqlCommand(query, DB_CONNECTION);
                    command.Parameters.AddWithValue("@name", product.productName);
                    command.Parameters.AddWithValue("@category", product.productCategory);
                    command.Parameters.AddWithValue("@description", product.productDescription);
                    command.Parameters.AddWithValue("@price", product.price);
                    command.Parameters.AddWithValue("@quantity", product.quantity);
                    command.Parameters.AddWithValue("@id", product.id);
                    command.Parameters.AddWithValue("@image", imageBytes);
                    command.ExecuteNonQuery();
                }

                DB_CONNECTION.Close();

                DisplayItems(1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }





        public void DisplayItems(int state)
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

                DisplayTable();
            }
            else if (state == 2)
            {
                DeletingSuccessUC deletingSuccessUC = new DeletingSuccessUC();
                ItemsContainer.Controls.Add(deletingSuccessUC);
            }
            else
            {
                Console.WriteLine("Error");

                DisplayTable();




            }
        }




        public void DisplayTable()
        {
            DataTable dataTable = new DataTable();

            this.DB_CONNECTION = Connect();
            string selectQuery = "SELECT * FROM products_table;";
            MySqlCommand selectCommand = new MySqlCommand(selectQuery, DB_CONNECTION);
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(selectCommand);
            dataAdapter.Fill(dataTable);

            DB_CONNECTION.Close();
            dataGridView.DataSource = dataTable;
        }


        private void BrowseButton_Click(object sender, EventArgs e)
        {

        }


        private MySqlConnection Connect()
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

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView.SelectedRows.Count > 0) // Check if a row is selected
                {
                    int selectedIndex = dataGridView.SelectedRows[0].Index;
                    string id = dataGridView.Rows[selectedIndex].Cells["ID"].Value.ToString(); // Assuming the ID column name is "ID"

                    this.DB_CONNECTION = Connect();

                    string query = "DELETE FROM products_table WHERE id = @id;";
                    MySqlCommand command = new MySqlCommand(query, DB_CONNECTION);
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();

                    DB_CONNECTION.Close();

                    DisplayItems(2);


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ClearField();
            }
        }



        private void ClearField()
        {
            NameBox.Clear();
            PriceBox.Clear();
            DescriptionBox.Clear();
            pictureBox.Image = null;
            QuantityBox.Clear();
        }




        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                string searchName = SearchBox.Text;

                this.DB_CONNECTION = Connect();

                string query = "SELECT * FROM products_table WHERE pname LIKE @search;";
                MySqlCommand command = new MySqlCommand(query, DB_CONNECTION);
                command.Parameters.AddWithValue("@search", "%" + searchName + "%");

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Bind the DataTable to the DataGridView
                dataGridView.DataSource = dataTable;

                DB_CONNECTION.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*  try
              {
                  // Check if a row is double-clicked
                  if (e.RowIndex >= 0)
                  {
                      // Get the selected row
                      DataGridViewRow selectedRow = dataGridView.Rows[e.RowIndex];

                      // Retrieve the selected item's data
                      string name = selectedRow.Cells["pname"].Value.ToString();
                      string category = selectedRow.Cells["pcategory"].Value.ToString();
                      string description = selectedRow.Cells["pdescription"].Value.ToString();
                      double price = Convert.ToDouble(selectedRow.Cells["pprice"].Value);

                      ProductCardUC productCardUC = new ProductCardUC();
                      ItemsContainer.Controls.Add(productCardUC);
                  }
              }
              catch (Exception ex)
              {
                  MessageBox.Show(ex.Message);
              }*/
        }
    }
}
