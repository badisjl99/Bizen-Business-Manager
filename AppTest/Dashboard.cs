using AppTest.AppLogin;
using AppTest.Controllers;
using AppTest.Models;
using System;
using System.Windows.Forms;

namespace AppTest
{
    public partial class RequestsButton : Form
    {
        public static Admin admin;


        public RequestsButton(Admin admin1)
        {
            InitializeComponent();
            admin = admin1;
            Container.Controls.Add(new DashboardUC());
            SetAdminData();


        }



        private void SetAdminData()
        {
            StaffName.Text = admin.name;
            StaffID.Text = admin.id;
            StaffPicture.Image = admin.profilePicture;
        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {

            Container.Controls.Clear();
            Container.Controls.Add(new DashboardUC());
        }

        private void ResourcesButton_Click(object sender, EventArgs e)
        {
            Container.Controls.Clear();
            Container.Controls.Add(new ResourcesUC());
        }

        private void ClientButton_Click(object sender, EventArgs e)
        {
            Container.Controls.Clear();
            Container.Controls.Add(new ClientsUC());
        }

        private void InventoryButton_Click(object sender, EventArgs e)
        {
            Container.Controls.Clear();
            Container.Controls.Add(new InventoryUC());
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {

        }

        private void MeetingButton_Click(object sender, EventArgs e)
        {
            Container.Controls.Clear();
            Container.Controls.Add(new Showroom());

        }
        private void InvoicesButton_Click(object sender, EventArgs e)
        {
            Container.Controls.Clear();
            Container.Controls.Add(new RequestsUC());
        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {
            Container.Controls.Clear();
            Container.Controls.Add(new OrdersUC());
        }

        private void MailsButton_Click(object sender, EventArgs e)
        {
            Container.Controls.Clear();
            Container.Controls.Add(new MailUC());
        }

        private void TrendsButton_Click(object sender, EventArgs e)
        {
            Container.Controls.Clear();
            Container.Controls.Add(new TrendsUC());
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();

        }

        private void ProductsToggle_Click(object sender, EventArgs e)
        {
            if (ProductsTogglePanel.Height == 45)
            {
                ProductsTogglePanel.Height = 129;
            }
            else
            {
                ProductsTogglePanel.Height = 45;


            }
        }

        private void CRMButton_Click(object sender, EventArgs e)
        {
            if (panel3.Height == 45)
            {
                panel3.Height = 117;
            }
            else
            {
                panel3.Height = 45;


            }
        }


    }
}
