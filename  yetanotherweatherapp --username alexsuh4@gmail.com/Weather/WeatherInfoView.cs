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
            //cloudLocation = new Point(Utils.Rand.Next(this.Width), Utils.Rand.Next(this.Height));
            
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
                    this.compassGauge1.Invalidate();
                }
                currentInfo = value;
                timer1.Start();
            }
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            //cloudLocation = new Point(cloudLocation.X + 3, cloudLocation.Y);
            //if (cloudLocation.X > this.TopLevelControl.Width)
            //    cloudLocation = new Point(0, Utils.Rand.Next(this.TopLevelControl.Height) );
            this.Invalidate();
            
        }

        //Point cloudLocation;
        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    base.OnPaint(e);
        //    e.Graphics.DrawImage(Resource1.cloud_icon_5, cloudLocation);
            
        //}
    }
}
