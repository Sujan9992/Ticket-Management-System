namespace coursework
{
    partial class StaffDashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffDashBoard));
            this.username = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.viewChart = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.reportViewButton = new System.Windows.Forms.Button();
            this.customerViewButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelShow = new System.Windows.Forms.Panel();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelShow.SuspendLayout();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(108)))));
            this.username.Location = new System.Drawing.Point(45, 108);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(82, 24);
            this.username.TabIndex = 1;
            this.username.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.viewChart);
            this.panel1.Controls.Add(this.logoutButton);
            this.panel1.Controls.Add(this.reportViewButton);
            this.panel1.Controls.Add(this.customerViewButton);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.username);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(146, 479);
            this.panel1.TabIndex = 2;
            // 
            // viewChart
            // 
            this.viewChart.FlatAppearance.BorderSize = 0;
            this.viewChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewChart.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewChart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(108)))));
            this.viewChart.Location = new System.Drawing.Point(3, 270);
            this.viewChart.Name = "viewChart";
            this.viewChart.Size = new System.Drawing.Size(124, 31);
            this.viewChart.TabIndex = 6;
            this.viewChart.Text = "Chart";
            this.viewChart.UseVisualStyleBackColor = true;
            this.viewChart.Click += new System.EventHandler(this.viewChart_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(108)))));
            this.logoutButton.Location = new System.Drawing.Point(3, 306);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(124, 31);
            this.logoutButton.TabIndex = 5;
            this.logoutButton.Text = "Log out";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // reportViewButton
            // 
            this.reportViewButton.FlatAppearance.BorderSize = 0;
            this.reportViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportViewButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportViewButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(108)))));
            this.reportViewButton.Location = new System.Drawing.Point(3, 236);
            this.reportViewButton.Name = "reportViewButton";
            this.reportViewButton.Size = new System.Drawing.Size(124, 28);
            this.reportViewButton.TabIndex = 4;
            this.reportViewButton.Text = "Report";
            this.reportViewButton.UseVisualStyleBackColor = true;
            this.reportViewButton.Click += new System.EventHandler(this.reportViewButton_Click);
            // 
            // customerViewButton
            // 
            this.customerViewButton.FlatAppearance.BorderSize = 0;
            this.customerViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerViewButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerViewButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(108)))));
            this.customerViewButton.Location = new System.Drawing.Point(3, 199);
            this.customerViewButton.Name = "customerViewButton";
            this.customerViewButton.Size = new System.Drawing.Size(124, 31);
            this.customerViewButton.TabIndex = 3;
            this.customerViewButton.Text = "Customer";
            this.customerViewButton.UseVisualStyleBackColor = true;
            this.customerViewButton.Click += new System.EventHandler(this.customerViewButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panelShow
            // 
            this.panelShow.Controls.Add(this.welcomeLabel);
            this.panelShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelShow.Location = new System.Drawing.Point(146, 0);
            this.panelShow.Name = "panelShow";
            this.panelShow.Size = new System.Drawing.Size(837, 479);
            this.panelShow.TabIndex = 3;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(108)))));
            this.welcomeLabel.Location = new System.Drawing.Point(245, 213);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(350, 28);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome to Staff Dashboard";
            // 
            // StaffDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 479);
            this.Controls.Add(this.panelShow);
            this.Controls.Add(this.panel1);
            this.Name = "StaffDashBoard";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff Panel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelShow.ResumeLayout(false);
            this.panelShow.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button reportViewButton;
        private System.Windows.Forms.Button customerViewButton;
        private System.Windows.Forms.Panel panelShow;
        private System.Windows.Forms.Button viewChart;
        private System.Windows.Forms.Label welcomeLabel;
    }
}