using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AppTest.Controllers
{
    public partial class ClientsMap : UserControl
    {
        public ClientsMap()
        {
            InitializeComponent();
        }

        private void ClientsMap_Load(object sender, EventArgs e)
        {
            LiveCharts.WinForms.GeoMap geoMap = new LiveCharts.WinForms.GeoMap();
            Dictionary<string, double> keyValues = new Dictionary<string, double>
            {
                ["TN"] = 20,
                ["CH"] = 76,
                ["MA"] = 74,
                ["FR"] = 26,
                ["CA"] = 96,
                ["DE"] = 76,
                ["NZ"] = 70,
                ["RU"] = 706,
                ["AR"] = 41,
                ["ZA"] = 706,
                ["SA"] = 56,
                ["PH"] = 13
            };
            geoMap.HeatMap = keyValues;

            geoMap.Source = $"{Application.StartupPath}\\World.xml";
            this.Controls.Add(geoMap);
            geoMap.Dock = DockStyle.Top;
            geoMap.BackColor = Color.SeaShell;
            geoMap.Size = new Size(900, 400);
        }
    }
}
