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
                {
                    WeatherBindingSource ds = new WeatherBindingSource(value.LocationData[0]);
                    bindingSource1.DataSource = ds; 
                }
                currentInfo = value;
                timer1.Start();
            }
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            cloud.Location = new Point(cloud.Location.X + 3, cloud.Location.Y);
            if (cloud.Location.X > this.TopLevelControl.Width)
                cloud.Location = new Point(0, Utils.Rand.Next(this.TopLevelControl.Height) );
        }

    }
}
