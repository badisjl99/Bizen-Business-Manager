using System.Drawing;
using System.Windows.Forms;

namespace AppTest.Tools
{
    public partial class TrendItemUC : UserControl
    {
        public TrendItemUC(string name, string price, Image image)
        {
            InitializeComponent();
            NameLabel.Text = name;
            PriceLabel.Text = price;
            CardPicture.Image = image;
        }
    }
}
