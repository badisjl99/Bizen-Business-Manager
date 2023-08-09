using AppTest.AppLogin;
using AppTest.Master_Tools;
using AppTest.Models;
using System;
using System.Windows.Forms;

namespace AppTest.Login
{
    public partial class MasterHome : Form
    {
        public static Admin admin;

        public MasterHome(Admin admin1)
        {
            InitializeComponent();
            admin = admin1;

            SetAdminData();
        }

        private void SetAdminData()
        {
            StaffName.Text = admin.name;
            StaffID.Text = admin.id;
            StaffPicture.Image = admin.profilePicture;
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();

        }

        private void MasterDashboardButton_Click(object sender, EventArgs e)
        {
            Container.Controls.Clear();
            Container.Controls.Add(new MasterDashboardUC());
        }

        private void InventoryButton_Click(object sender, EventArgs e)
        {

        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {

        }

        private void MailsButton_Click(object sender, EventArgs e)
        {

        }

        private void AssignButton_Click(object sender, EventArgs e)
        {
            Container.Controls.Clear();
            Container.Controls.Add(new AssignTasksUC());
        }
    }
}
