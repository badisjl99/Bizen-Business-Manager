using AppTest.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTest
{
    public partial class RequestsButton : Form
    {
        private ResourcesUC resourcesUC;
        private DashboardUC dashboardUC;
        private ClientsUC clientsUC;
        private InventoryUC inventoryUC;
        private RequestsUC requestsUC;

        public RequestsButton()
        {
            InitializeComponent();
            resourcesUC = new ResourcesUC();
            dashboardUC = new DashboardUC();
            clientsUC = new ClientsUC();
            inventoryUC = new InventoryUC();
            requestsUC = new RequestsUC();
            Container.Controls.Add(dashboardUC);
        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
  
            Container.Controls.Clear();
            Container.Controls.Add(dashboardUC);
        }

        private void ResourcesButton_Click(object sender, EventArgs e)
        {
            Container.Controls.Clear();
            Container.Controls.Add(resourcesUC);
        }

        private void ClientButton_Click(object sender, EventArgs e)
        {
            Container.Controls.Clear();
            Container.Controls.Add(clientsUC);
        }

        private void InventoryButton_Click(object sender, EventArgs e)
        {
            Container.Controls.Clear();
            Container.Controls.Add(inventoryUC);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Container.Controls.Clear();
            Container.Controls.Add(requestsUC);
        }
    }
}
