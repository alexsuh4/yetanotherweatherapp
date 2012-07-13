namespace Weather
{
    partial class Form1
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
                waiter.Dispose();
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.picwait = new System.Windows.Forms.PictureBox();
            this.lwait = new System.Windows.Forms.Label();
            this.panelwait = new System.Windows.Forms.TableLayoutPanel();
            this.weatherInfoByLocationView1 = new Weather.WeatherInfoByLocationView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picwait)).BeginInit();
            this.panelwait.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(457, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.aboutToolStripMenuItem.Text = "about";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // picwait
            // 
            this.picwait.Image = ((System.Drawing.Image)(resources.GetObject("picwait.Image")));
            this.picwait.Location = new System.Drawing.Point(3, 3);
            this.picwait.Name = "picwait";
            this.picwait.Size = new System.Drawing.Size(124, 122);
            this.picwait.TabIndex = 0;
            this.picwait.TabStop = false;
            // 
            // lwait
            // 
            this.lwait.AutoSize = true;
            this.lwait.Location = new System.Drawing.Point(3, 128);
            this.lwait.Name = "lwait";
            this.lwait.Size = new System.Drawing.Size(60, 13);
            this.lwait.TabIndex = 1;
            this.lwait.Text = "please wait";
            // 
            // panelwait
            // 
            this.panelwait.ColumnCount = 1;
            this.panelwait.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelwait.Controls.Add(this.lwait, 0, 1);
            this.panelwait.Controls.Add(this.picwait, 0, 0);
            this.panelwait.Location = new System.Drawing.Point(145, 129);
            this.panelwait.Name = "panelwait";
            this.panelwait.RowCount = 2;
            this.panelwait.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.panelwait.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelwait.Size = new System.Drawing.Size(130, 146);
            this.panelwait.TabIndex = 2;
            this.panelwait.Visible = false;
            // 
            // weatherInfoByLocationView1
            // 
            this.weatherInfoByLocationView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weatherInfoByLocationView1.Location = new System.Drawing.Point(0, 24);
            this.weatherInfoByLocationView1.Name = "weatherInfoByLocationView1";
            this.weatherInfoByLocationView1.Size = new System.Drawing.Size(457, 393);
            this.weatherInfoByLocationView1.TabIndex = 0;
            this.weatherInfoByLocationView1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 417);
            this.Controls.Add(this.panelwait);
            this.Controls.Add(this.weatherInfoByLocationView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picwait)).EndInit();
            this.panelwait.ResumeLayout(false);
            this.panelwait.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WeatherInfoByLocationView weatherInfoByLocationView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lwait;
        private System.Windows.Forms.PictureBox picwait;
        private System.Windows.Forms.TableLayoutPanel panelwait;
    }
}

