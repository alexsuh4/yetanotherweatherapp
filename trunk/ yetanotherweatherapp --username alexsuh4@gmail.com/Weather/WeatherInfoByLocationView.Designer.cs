namespace Weather
{
    partial class WeatherInfoByLocationView
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.weatherInfoView1 = new Weather.WeatherInfoView();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(513, 54);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // weatherInfoView1
            // 
            this.weatherInfoView1.CurrentInfo = null;
            this.weatherInfoView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weatherInfoView1.Location = new System.Drawing.Point(0, 54);
            this.weatherInfoView1.Name = "weatherInfoView1";
            this.weatherInfoView1.Size = new System.Drawing.Size(513, 372);
            this.weatherInfoView1.TabIndex = 0;
            // 
            // WeatherInfoByLocationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.weatherInfoView1);
            this.Controls.Add(this.comboBox1);
            this.Name = "WeatherInfoByLocationView";
            this.Size = new System.Drawing.Size(513, 426);
            this.ResumeLayout(false);

        }

        #endregion

        private WeatherInfoView weatherInfoView1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
