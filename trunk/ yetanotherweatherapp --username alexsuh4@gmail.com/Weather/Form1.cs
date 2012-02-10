using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace Weather
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            SetTitle();
        }

        private void SetTitle()
        {
           this.Text= Utils.GetAssemblyAttribute<AssemblyTitleAttribute>(Assembly.GetExecutingAssembly()).Title;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WeatherProvider provider = new WeatherProvider();
            provider.Retrieve();
            provider.Parse();

            weatherInfoByLocationView1.InfoView = provider.weatherInfo;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (about ab = new about(WindVelocity))
            {
                ab.ShowDialog();
            }
        }

        public int WindVelocity
        {
            get
            {
                int _default =2;
                try
                {
                    WeatherInfo info = weatherInfoByLocationView1.InfoView as WeatherInfo;
                    if (info == null) return _default;

                    return Convert.ToInt32(new WeatherBindingSource(info.LocationNameToLocationInfoMapping.First().Value.LocationData[0]).WindSpeed.Split('-')[0]);
                }
                catch (Exception) { return _default; }
                
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
