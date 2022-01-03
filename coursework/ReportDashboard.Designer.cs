namespace coursework
{
    partial class ReportDashboard
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
            this.reportPanel = new System.Windows.Forms.Panel();
            this.buttonSort = new System.Windows.Forms.Button();
            this.weeklyGrid = new System.Windows.Forms.DataGridView();
            this.dailyGrid = new System.Windows.Forms.DataGridView();
            this.viewWeeklyReport = new System.Windows.Forms.Button();
            this.viewDailyReport = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.reportPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weeklyGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // reportPanel
            // 
            this.reportPanel.Controls.Add(this.buttonSort);
            this.reportPanel.Controls.Add(this.weeklyGrid);
            this.reportPanel.Controls.Add(this.dailyGrid);
            this.reportPanel.Controls.Add(this.viewWeeklyReport);
            this.reportPanel.Controls.Add(this.viewDailyReport);
            this.reportPanel.Location = new System.Drawing.Point(1, 2);
            this.reportPanel.Name = "reportPanel";
            this.reportPanel.Size = new System.Drawing.Size(834, 449);
            this.reportPanel.TabIndex = 0;
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(566, 269);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(110, 23);
            this.buttonSort.TabIndex = 8;
            this.buttonSort.Text = "Sort by Income";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // weeklyGrid
            // 
            this.weeklyGrid.AllowUserToAddRows = false;
            this.weeklyGrid.AllowUserToDeleteRows = false;
            this.weeklyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.weeklyGrid.Location = new System.Drawing.Point(434, 19);
            this.weeklyGrid.Name = "weeklyGrid";
            this.weeklyGrid.ReadOnly = true;
            this.weeklyGrid.Size = new System.Drawing.Size(383, 215);
            this.weeklyGrid.TabIndex = 7;
            // 
            // dailyGrid
            // 
            this.dailyGrid.AllowUserToAddRows = false;
            this.dailyGrid.AllowUserToDeleteRows = false;
            this.dailyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dailyGrid.Location = new System.Drawing.Point(11, 19);
            this.dailyGrid.Name = "dailyGrid";
            this.dailyGrid.ReadOnly = true;
            this.dailyGrid.Size = new System.Drawing.Size(395, 215);
            this.dailyGrid.TabIndex = 6;
            // 
            // viewWeeklyReport
            // 
            this.viewWeeklyReport.Location = new System.Drawing.Point(585, 240);
            this.viewWeeklyReport.Name = "viewWeeklyReport";
            this.viewWeeklyReport.Size = new System.Drawing.Size(75, 23);
            this.viewWeeklyReport.TabIndex = 5;
            this.viewWeeklyReport.Text = "Weekly Report";
            this.viewWeeklyReport.UseVisualStyleBackColor = true;
            this.viewWeeklyReport.Click += new System.EventHandler(this.viewWeeklyReport_Click);
            // 
            // viewDailyReport
            // 
            this.viewDailyReport.Location = new System.Drawing.Point(147, 240);
            this.viewDailyReport.Name = "viewDailyReport";
            this.viewDailyReport.Size = new System.Drawing.Size(75, 23);
            this.viewDailyReport.TabIndex = 4;
            this.viewDailyReport.Text = "Daily Report";
            this.viewDailyReport.UseVisualStyleBackColor = true;
            this.viewDailyReport.Click += new System.EventHandler(this.viewDailyReport_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ReportDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 450);
            this.Controls.Add(this.reportPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportDashboard";
            this.ShowIcon = false;
            this.Text = "ReportDashboard";
            this.reportPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.weeklyGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel reportPanel;
        private System.Windows.Forms.DataGridView weeklyGrid;
        private System.Windows.Forms.DataGridView dailyGrid;
        private System.Windows.Forms.Button viewWeeklyReport;
        private System.Windows.Forms.Button viewDailyReport;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonSort;
    }
}