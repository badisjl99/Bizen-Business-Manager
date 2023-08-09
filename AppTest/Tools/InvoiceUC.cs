using System;
using System.Windows.Forms;

namespace AppTest.Tools
{
    public partial class InvoiceUC : UserControl
    {
        public InvoiceUC(string id, string fullname, string product, int quantity, DateTime dateTime)
        {
            InitializeComponent();



            InvoiceID.Text = id;
            ClientName.Text = fullname;
            Product.Text = product;
            Quantity.Text = "" + quantity;
            DateInvoice.Text = dateTime.ToString();


        }


        public InvoiceUC()
        {

            InitializeComponent();

        }
    }
}
