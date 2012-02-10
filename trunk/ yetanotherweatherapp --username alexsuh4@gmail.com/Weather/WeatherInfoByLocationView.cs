using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Weather
{
    public partial class WeatherInfoByLocationView : UserControl
    {
        public WeatherInfoByLocationView()
        {
            InitializeComponent();
        }
        private WeatherInfo infoView;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public WeatherInfo InfoView
        {
            get
            {
                return infoView;
            }
            set
            {
                infoView = value;
                comboBox1.DataSource = new WeatherLocationsBindingSource(value).Locations;
                List<string> locations = comboBox1.DataSource as List<string>;
                if (locations != null && locations.IndexOf(Settings1.Default.DefaultCity) > 0)
                {
                    comboBox1.SelectedItem = Settings1.Default.DefaultCity;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (
                
                comboBox1.SelectedItem!=null &&
                InfoView.LocationNameToLocationInfoMapping.ContainsKey(Convert.ToString(comboBox1.SelectedItem)))
            {
                weatherInfoView1.CurrentInfo = InfoView.LocationNameToLocationInfoMapping[Convert.ToString(comboBox1.SelectedItem)];
            }
        }
       

    }
}
