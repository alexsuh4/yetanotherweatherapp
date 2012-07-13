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
    public partial class Form1 : Form, IWaitView
    {
        public Form1()
        {
            InitializeComponent();

            SetTitle();
            waiter = new WinformsWaiter(this);

        }
        WinformsWaiter waiter;
        private void SetTitle()
        {
           this.Text= Utils.GetAssemblyAttribute<AssemblyTitleAttribute>(Assembly.GetExecutingAssembly()).Title;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            waiter.start();
            weatherInfoByLocationView1.Visible = false;
            backgroundWorker1.RunWorkerAsync();
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

        #region IWaitView Members

       

        public Label ProgressLabel()
        {
            return lwait;
        }

       

        public Control ContainingPanel()
        {
            return panelwait;
        }

        
        #endregion

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            WeatherProvider provider = new WeatherProvider();
            provider.Retrieve();
            provider.Parse();
            e.Result = provider;
            e.Result = provider.weatherInfo;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (e.Error != null)
                { MessageBox.Show("Error !" + e.Error); return; }
                if (e.Cancelled || e.Result == null || !(e.Result is WeatherInfo)) return;
                weatherInfoByLocationView1.InfoView = (WeatherInfo)e.Result;
            }
            finally
            {
                waiter.stop();
                weatherInfoByLocationView1.Visible = true;
            }
        }

        
    }
}
