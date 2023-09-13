using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTest.Tools
{
    public partial class EventUC : UserControl
    {
        public EventUC(string label,Color color)
        {
            InitializeComponent();
            this.EventLabel.Text = label;
            this.BackColor = color;
        }
    }
}
