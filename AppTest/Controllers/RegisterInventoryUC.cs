using AppTest.Models;
using AppTest.Tools;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace AppTest.Controllers
{
    public partial class RegisterInventoryUC : UserControl
    {
        MySqlConnection DB_CONNECTION;

        public RegisterInventoryUC()
        {
            InitializeComponent();
        }

        private void AddInventoryButton_Click(object sender, EventArgs e)
        {
            string Iname = NameBox.Text;
            string Itype = TypeBox.Text;
            string Ilocation = LocationBox.Text;
            string Icapacity = CapacityBox.Text;

            if (checkBox1.Checked && checkBox2.Checked)
            {
                if (int.TryParse(Icapacity, out int capacity))
                {
                    Inventory inventory = new Inventory(Iname, Itype, Ilocation, capacity);
                    this.DB_CONNECTION = Connect();

                    string sql = "insert into  inventories_table(name,type,location,capacity) values (@name,@type,@location,@capacity)";

                    MySqlCommand command = new MySqlCommand(sql, DB_CONNECTION);
                    command.Parameters.AddWithValue("@name", inventory.InventoryName);
                    command.Parameters.AddWithValue("@type", inventory.InventoryType);
                    command.Parameters.AddWithValue("@location", inventory.InventoryLocation);
                    command.Parameters.AddWithValue("@capacity", inventory.InventoryCapacity);
                    command.ExecuteNonQuery();

                    DB_CONNECTION.Close();



                    DisplayResultStatus();
                }
                else
                {
                    MessageBox.Show("Please Fill Fields ! ");
                }
            }
        }

        private MySqlConnection Connect()
        {

            string connectionString = "server=localhost;user=root;password=;database=app_db;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            return connection;
        }



        private void DisplayResultStatus()
        {

            SuccessInventory successInventory = new SuccessInventory
            {
                Dock = DockStyle.Top
            };
            panel1.Controls.Add(successInventory);
            System.Timers.Timer timer = new System.Timers.Timer(2000);
            timer.Elapsed += (s, args) =>
            {
                timer.Stop();
                this.Invoke((MethodInvoker)delegate
                {
                    panel1.Controls.Remove(successInventory);
                });
            };
            timer.Start();

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            InventoryUC inventoryUc = new InventoryUC() ;
            inventoryUc.Dock = DockStyle.Fill;

            Controls.Add(inventoryUc);

        }
    }






}
