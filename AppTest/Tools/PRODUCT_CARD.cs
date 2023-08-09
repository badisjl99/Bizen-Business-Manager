using System.Drawing;
using System.Windows.Forms;

namespace AppTest.Tools
{
    public partial class PRODUCT_CARD : UserControl
    {


        public PRODUCT_CARD(string name, string description, string price, Image image, int quantity)
        {
            InitializeComponent();
            NameLabel.Text = name;
            DescriptionLabel.Text = description;
            PriceLabel.Text = price;
            CardPicture.Image = image;
            QuantityLabel.Text = quantity.ToString();


        }



    }











}
