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
    public partial class WeatherInfoView : UserControl
    {
        public WeatherInfoView()
        {
            InitializeComponent();
        }
        private LocationInfo currentInfo;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public LocationInfo CurrentInfo
        {
            get { return currentInfo; }
            set {
                if (value == null) return;
                if (value.LocationData != null && value.LocationData.Count > 0)
                    bindingSource1.DataSource = new WeatherBindingSource(value.LocationData[0]);
                
                currentInfo = value; }
        }

    }
}
