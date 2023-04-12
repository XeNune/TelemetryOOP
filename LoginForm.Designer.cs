
namespace WindowsFormsApp1
{
    partial class LoginForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.StopButton = new System.Windows.Forms.Button();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.InfoAboutLocation = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.gps_pic = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.close_but = new System.Windows.Forms.Label();
            this.titel = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gps_pic)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Transparent;
            this.MainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainPanel.BackgroundImage")));
            this.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainPanel.Controls.Add(this.StopButton);
            this.MainPanel.Controls.Add(this.gMapControl1);
            this.MainPanel.Controls.Add(this.InfoAboutLocation);
            this.MainPanel.Controls.Add(this.btnLoad);
            this.MainPanel.Controls.Add(this.gps_pic);
            this.MainPanel.Controls.Add(this.panel2);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(534, 511);
            this.MainPanel.TabIndex = 0;
            this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.MainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // StopButton
            // 
            this.StopButton.AllowDrop = true;
            this.StopButton.BackColor = System.Drawing.Color.White;
            this.StopButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopButton.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StopButton.Location = new System.Drawing.Point(369, 434);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(117, 65);
            this.StopButton.TabIndex = 9;
            this.StopButton.Text = "Остановить слежку";
            this.StopButton.UseVisualStyleBackColor = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(80, 192);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(406, 224);
            this.gMapControl1.TabIndex = 8;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.Load += new System.EventHandler(this.gMapControl1_Load);
            // 
            // InfoAboutLocation
            // 
            this.InfoAboutLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InfoAboutLocation.Location = new System.Drawing.Point(80, 71);
            this.InfoAboutLocation.Multiline = true;
            this.InfoAboutLocation.Name = "InfoAboutLocation";
            this.InfoAboutLocation.Size = new System.Drawing.Size(406, 97);
            this.InfoAboutLocation.TabIndex = 7;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.White;
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLoad.FlatAppearance.BorderSize = 10;
            this.btnLoad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnLoad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLoad.Location = new System.Drawing.Point(80, 434);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(184, 65);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "Отслеживать";
            this.btnLoad.UseVisualStyleBackColor = false;
            // 
            // gps_pic
            // 
            this.gps_pic.BackColor = System.Drawing.Color.White;
            this.gps_pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gps_pic.Image = global::WindowsFormsApp1.Properties.Resources.geo1_300x300;
            this.gps_pic.Location = new System.Drawing.Point(10, 86);
            this.gps_pic.Name = "gps_pic";
            this.gps_pic.Size = new System.Drawing.Size(64, 64);
            this.gps_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gps_pic.TabIndex = 1;
            this.gps_pic.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.close_but);
            this.panel2.Controls.Add(this.titel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(534, 65);
            this.panel2.TabIndex = 0;
            // 
            // close_but
            // 
            this.close_but.AllowDrop = true;
            this.close_but.AutoSize = true;
            this.close_but.BackColor = System.Drawing.Color.Black;
            this.close_but.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close_but.ForeColor = System.Drawing.Color.White;
            this.close_but.Location = new System.Drawing.Point(501, 0);
            this.close_but.Name = "close_but";
            this.close_but.Size = new System.Drawing.Size(33, 31);
            this.close_but.TabIndex = 1;
            this.close_but.Text = "X";
            this.close_but.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.close_but.Click += new System.EventHandler(this.close_but_Click_1);
            // 
            // titel
            // 
            this.titel.BackColor = System.Drawing.Color.Transparent;
            this.titel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titel.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titel.ForeColor = System.Drawing.Color.Black;
            this.titel.Location = new System.Drawing.Point(0, 0);
            this.titel.Name = "titel";
            this.titel.Size = new System.Drawing.Size(534, 65);
            this.titel.TabIndex = 0;
            this.titel.Text = "Местоположение";
            this.titel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 511);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gps_pic)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label titel;
        private System.Windows.Forms.Label close_but;
        private System.Windows.Forms.PictureBox gps_pic;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox InfoAboutLocation;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Button StopButton;
    }
}