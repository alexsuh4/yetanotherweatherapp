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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maxHumidity = new System.Windows.Forms.Label();
            this.minHumidity = new System.Windows.Forms.Label();
            this.windDirection = new System.Windows.Forms.Label();
            this.windSpeed = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.mintemp = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.maxtemp = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.maxHumidity, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.minHumidity, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.windDirection, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.windSpeed, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99999F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(518, 442);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "max humidity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "min humidity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "wind dir";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "wind speed";
            // 
            // maxHumidity
            // 
            this.maxHumidity.AutoSize = true;
            this.maxHumidity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "MaximumRelativeHumidity", true));
            this.maxHumidity.Font = new System.Drawing.Font("Jazz LET", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.maxHumidity.Location = new System.Drawing.Point(262, 150);
            this.maxHumidity.Name = "maxHumidity";
            this.maxHumidity.Size = new System.Drawing.Size(62, 23);
            this.maxHumidity.TabIndex = 8;
            this.maxHumidity.Text = "label9";
            // 
            // minHumidity
            // 
            this.minHumidity.AutoSize = true;
            this.minHumidity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "MinimumRelativeHumidity", true));
            this.minHumidity.Font = new System.Drawing.Font("Jazz LET", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.minHumidity.Location = new System.Drawing.Point(262, 223);
            this.minHumidity.Name = "minHumidity";
            this.minHumidity.Size = new System.Drawing.Size(73, 23);
            this.minHumidity.TabIndex = 9;
            this.minHumidity.Text = "label10";
            // 
            // windDirection
            // 
            this.windDirection.AutoSize = true;
            this.windDirection.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "WindDirection", true));
            this.windDirection.Font = new System.Drawing.Font("Jazz LET", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.windDirection.Location = new System.Drawing.Point(262, 296);
            this.windDirection.Name = "windDirection";
            this.windDirection.Size = new System.Drawing.Size(73, 23);
            this.windDirection.TabIndex = 10;
            this.windDirection.Text = "label11";
            // 
            // windSpeed
            // 
            this.windSpeed.AutoSize = true;
            this.windSpeed.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "WindSpeed", true));
            this.windSpeed.Font = new System.Drawing.Font("Jazz LET", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.windSpeed.Location = new System.Drawing.Point(262, 369);
            this.windSpeed.Name = "windSpeed";
            this.windSpeed.Size = new System.Drawing.Size(73, 23);
            this.windSpeed.TabIndex = 11;
            this.windSpeed.Text = "label12";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.maxtemp, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.mintemp, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(512, 144);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // mintemp
            // 
            this.mintemp.AutoSize = true;
            this.mintemp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "MinimumTemperature", true));
            this.mintemp.Font = new System.Drawing.Font("Jazz LET", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.mintemp.Location = new System.Drawing.Point(223, 0);
            this.mintemp.Name = "mintemp";
            this.mintemp.Size = new System.Drawing.Size(108, 32);
            this.mintemp.TabIndex = 3;
            this.mintemp.Text = "label16";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Weather.WeatherBindingSource);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // maxtemp
            // 
            this.maxtemp.AutoSize = true;
            this.maxtemp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "MaximumTemperature", true));
            this.maxtemp.Font = new System.Drawing.Font("Jazz LET", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.maxtemp.Location = new System.Drawing.Point(109, 0);
            this.maxtemp.Name = "maxtemp";
            this.maxtemp.Size = new System.Drawing.Size(108, 32);
            this.maxtemp.TabIndex = 2;
            this.maxtemp.Text = "label15";
            // 
            // WeatherInfoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "WeatherInfoView";
            this.Size = new System.Drawing.Size(518, 442);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label maxHumidity;
        private System.Windows.Forms.Label minHumidity;
        private System.Windows.Forms.Label windDirection;
        private System.Windows.Forms.Label windSpeed;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label mintemp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label maxtemp;
    }
}
