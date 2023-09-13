using AppTest.AppLogin;
using AppTest.Controllers;
using AppTest.Master_Tools;
using AppTest.Models;
using System;
using System.Windows.Forms;

namespace AppTest.Login
{
    public partial class MasterHome : Form
    {
        public static Admin admin;
        private MasterDashboardUC dashboardUC = new MasterDashboardUC();
        public MasterHome(Admin admin1)
        {
            InitializeComponent();
            Container.Controls.Add(dashboardUC);
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
            Container.Controls.Add(dashboardUC);
        }

        private void InventoryButton_Click(object sender, EventArgs e)
        {
            Container.Controls.Clear();
            InventoryUC inventory = new InventoryUC();
            inventory.Dock = DockStyle.Fill;
            Container.Controls.Add(inventory);
        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {

        }

        private void AssignButton_Click(object sender, EventArgs e)
        {
            Container.Controls.Clear();
            Container.Controls.Add(new AssignTasksUC());
        }

        private void NotifyButton_Click(object sender, EventArgs e)
        {
            Container.Controls.Clear();
            NotifyUC notify = new NotifyUC();   
            notify.Dock = DockStyle.Fill;   
            Container.Controls.Add(notify);
        }

        private void EventsButton_Click(object sender, EventArgs e)
        {
            Container.Controls.Clear();
            EventCalender events = new EventCalender();
            events.Dock = DockStyle.Fill;
            Container.Controls.Add(events);
        }
    }
}
