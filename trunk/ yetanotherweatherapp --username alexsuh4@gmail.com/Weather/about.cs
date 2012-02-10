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
    public partial class about : Form
    {
        public about():this(2)
        {
            
        }
        public about(int windSpeed)
        {
            InitializeComponent();

            this.drawPanel1.speed = windSpeed;
        }
        private void about_Load(object sender, EventArgs e)
        {
            productName.Text = Utils.GetAssemblyAttribute<AssemblyTitleAttribute>(Assembly.GetExecutingAssembly()).Title;
            description.Text = Utils.GetAssemblyAttribute<AssemblyDescriptionAttribute>(Assembly.GetExecutingAssembly()).Description;
            author.Text = Utils.GetAssemblyAttribute<AssemblyCompanyAttribute>(Assembly.GetExecutingAssembly()).Company;
            //version.Text = GetAssemblyAttribute<AssemblyVersionAttribute>(Assembly.GetExecutingAssembly()).Version;

            
           
             
        }
        
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            drawPanel1.Invalidate();
        }
    }

}
