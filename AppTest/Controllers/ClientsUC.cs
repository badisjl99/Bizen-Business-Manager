using System;
using System.Windows.Forms;

namespace AppTest.Controllers
{
    public partial class ClientsUC : UserControl
    {
        public ClientsUC()
        {
            InitializeComponent();
        }

        private void NormalClientButton_Click(object sender, EventArgs e)
        {

            NormalClientUC normalClientUC = new NormalClientUC();
            Clients_Container.Controls.Clear();
            Clients_Container.Controls.Add(normalClientUC);

        }
    }
}
