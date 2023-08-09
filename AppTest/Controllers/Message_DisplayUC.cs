using System.Windows.Forms;

namespace AppTest.Controllers
{
    public partial class Message_DisplayUC : UserControl
    {
        public Message_DisplayUC(string sender, string content, string date, string reciever)
        {
            InitializeComponent();


            SenderLabel.Text = sender;
            ContentLabel.Text = content;
            DateLabel.Text = date;
            RecieverLabel.Text = reciever;

        }
    }
}
