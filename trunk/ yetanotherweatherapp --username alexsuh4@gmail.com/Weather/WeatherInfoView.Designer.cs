namespace Weather
{
    partial class WeatherInfoView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeatherInfoView));
            PolyMonControls.RadialGauge.NeedleType needleType3 = new PolyMonControls.RadialGauge.NeedleType();
            PolyMonControls.RadialGauge.NeedleType needleType4 = new PolyMonControls.RadialGauge.NeedleType();
            this.maxHumidity = new System.Windows.Forms.Label();
            this.minHumidity = new System.Windows.Forms.Label();
            this.windDirection = new System.Windows.Forms.Label();
            this.windSpeed = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.maxtemp = new System.Windows.Forms.Label();
            this.mintemp = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radialGauge1 = new PolyMonControls.RadialGauge();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.radialGauge2 = new PolyMonControls.RadialGauge();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cloud = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud)).BeginInit();
            this.SuspendLayout();
            // 
            // maxHumidity
            // 
            this.maxHumidity.AutoSize = true;
            this.maxHumidity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "MaximumRelativeHumidity", true));
            this.maxHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.maxHumidity.Location = new System.Drawing.Point(213, 64);
            this.maxHumidity.Name = "maxHumidity";
            this.maxHumidity.Size = new System.Drawing.Size(124, 25);
            this.maxHumidity.TabIndex = 8;
            this.maxHumidity.Text = "maxHumidity";
            // 
            // minHumidity
            // 
            this.minHumidity.AutoSize = true;
            this.minHumidity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "MinimumRelativeHumidity", true));
            this.minHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.minHumidity.Location = new System.Drawing.Point(67, 64);
            this.minHumidity.Name = "minHumidity";
            this.minHumidity.Size = new System.Drawing.Size(118, 25);
            this.minHumidity.TabIndex = 9;
            this.minHumidity.Text = "minHumidity";
            // 
            // windDirection
            // 
            this.windDirection.AutoSize = true;
            this.windDirection.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "WindDirection", true));
            this.windDirection.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.windDirection.Location = new System.Drawing.Point(3, 156);
            this.windDirection.Name = "windDirection";
            this.windDirection.Size = new System.Drawing.Size(128, 25);
            this.windDirection.TabIndex = 10;
            this.windDirection.Text = "windDirection";
            // 
            // windSpeed
            // 
            this.windSpeed.AutoSize = true;
            this.windSpeed.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "WindSpeed", true));
            this.windSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.windSpeed.Location = new System.Drawing.Point(3, 156);
            this.windSpeed.Name = "windSpeed";
            this.windSpeed.Size = new System.Drawing.Size(106, 25);
            this.windSpeed.TabIndex = 11;
            this.windSpeed.Text = "windspeed";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.maxtemp, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.mintemp, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.minHumidity, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.maxHumidity, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox2, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(426, 130);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // maxtemp
            // 
            this.maxtemp.AutoSize = true;
            this.maxtemp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "MaximumTemperature", true));
            this.maxtemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.maxtemp.Location = new System.Drawing.Point(67, 0);
            this.maxtemp.Name = "maxtemp";
            this.maxtemp.Size = new System.Drawing.Size(140, 31);
            this.maxtemp.TabIndex = 2;
            this.maxtemp.Text = "maxTemp";
            // 
            // mintemp
            // 
            this.mintemp.AutoSize = true;
            this.mintemp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "MinimumTemperature", true));
            this.mintemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.mintemp.Location = new System.Drawing.Point(213, 0);
            this.mintemp.Name = "mintemp";
            this.mintemp.Size = new System.Drawing.Size(133, 31);
            this.mintemp.TabIndex = 3;
            this.mintemp.Text = "minTemp";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Tempature");
            // 
            // radialGauge1
            // 
            this.radialGauge1.BackgroundImage = System.Drawing.Color.Empty;
            this.radialGauge1.BackgroundImageLayout = System.Drawing.Color.Empty;
            this.radialGauge1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource1, "WindSpeedAvg", true));
            this.radialGauge1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radialGauge1.Location = new System.Drawing.Point(3, 3);
            this.radialGauge1.Name = "radialGauge1";
            needleType3.Color = System.Drawing.Color.Blue;
            needleType3.PercentageLength = 100F;
            needleType3.Thickness = 10F;
            this.radialGauge1.Needle = needleType3;
            this.radialGauge1.RangeEnd = 360;
            this.radialGauge1.Size = new System.Drawing.Size(198, 150);
            this.radialGauge1.TabIndex = 11;
            this.toolTip1.SetToolTip(this.radialGauge1, "Wind Speed");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cloud);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 356);
            this.panel1.TabIndex = 16;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 67);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Humidity");
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.windSpeed, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.radialGauge1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(204, 220);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.radialGauge2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.windDirection, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(213, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(208, 220);
            this.tableLayoutPanel3.TabIndex = 15;
            // 
            // radialGauge2
            // 
            this.radialGauge2.BackgroundImage = System.Drawing.Color.Empty;
            this.radialGauge2.BackgroundImageLayout = System.Drawing.Color.Empty;
            this.radialGauge2.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource1, "WindDirection", true));
            this.radialGauge2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radialGauge2.Location = new System.Drawing.Point(3, 3);
            this.radialGauge2.Name = "radialGauge2";
            needleType4.Color = System.Drawing.Color.Blue;
            needleType4.PercentageLength = 100F;
            needleType4.Thickness = 10F;
            this.radialGauge2.Needle = needleType4;
            this.radialGauge2.RangeEnd = 360;
            this.radialGauge2.Size = new System.Drawing.Size(202, 150);
            this.radialGauge2.TabIndex = 11;
            this.toolTip1.SetToolTip(this.radialGauge2, "Wind Direction");
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 130);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(426, 226);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Weather.WeatherBindingSource);
            // 
            // cloud
            // 
            this.cloud.BackColor = System.Drawing.Color.Transparent;
            this.cloud.Image = global::Weather.Properties.Resources.cloud_icon_5;
            this.cloud.Location = new System.Drawing.Point(3, 131);
            this.cloud.Name = "cloud";
            this.cloud.Size = new System.Drawing.Size(109, 69);
            this.cloud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cloud.TabIndex = 13;
            this.cloud.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // WeatherInfoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "WeatherInfoView";
            this.Size = new System.Drawing.Size(426, 356);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label maxHumidity;
        private System.Windows.Forms.Label minHumidity;
        private System.Windows.Forms.Label windDirection;
        private System.Windows.Forms.Label windSpeed;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label mintemp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label maxtemp;
        private PolyMonControls.RadialGauge radialGauge1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private PolyMonControls.RadialGauge radialGauge2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox cloud;
        private System.Windows.Forms.Timer timer1;
    }
}
