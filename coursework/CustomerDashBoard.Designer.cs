namespace coursework
{
    partial class CustomerDashBoard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonTicket = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.dateTimePickerOutTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerInTime = new System.Windows.Forms.DateTimePicker();
            this.textBoxTotalAmount = new System.Windows.Forms.TextBox();
            this.textBoxTicketRate = new System.Windows.Forms.TextBox();
            this.textBoxTotalTime = new System.Windows.Forms.TextBox();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.textBoxCustomerID = new System.Windows.Forms.TextBox();
            this.labelTotalAmount = new System.Windows.Forms.Label();
            this.labelTicketRate = new System.Windows.Forms.Label();
            this.labelTotalTime = new System.Windows.Forms.Label();
            this.labelOutTime = new System.Windows.Forms.Label();
            this.labelInTime = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.labelCustomerID = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonLoad);
            this.panel1.Controls.Add(this.buttonCalculate);
            this.panel1.Controls.Add(this.buttonTicket);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.dataGridViewCustomer);
            this.panel1.Controls.Add(this.dateTimePickerOutTime);
            this.panel1.Controls.Add(this.dateTimePickerInTime);
            this.panel1.Controls.Add(this.textBoxTotalAmount);
            this.panel1.Controls.Add(this.textBoxTicketRate);
            this.panel1.Controls.Add(this.textBoxTotalTime);
            this.panel1.Controls.Add(this.dateTimePickerDate);
            this.panel1.Controls.Add(this.comboBoxCategory);
            this.panel1.Controls.Add(this.textBoxAddress);
            this.panel1.Controls.Add(this.textBoxCustomerName);
            this.panel1.Controls.Add(this.textBoxCustomerID);
            this.panel1.Controls.Add(this.labelTotalAmount);
            this.panel1.Controls.Add(this.labelTicketRate);
            this.panel1.Controls.Add(this.labelTotalTime);
            this.panel1.Controls.Add(this.labelOutTime);
            this.panel1.Controls.Add(this.labelInTime);
            this.panel1.Controls.Add(this.labelDate);
            this.panel1.Controls.Add(this.labelCategory);
            this.panel1.Controls.Add(this.labelAddress);
            this.panel1.Controls.Add(this.labelCustomerName);
            this.panel1.Controls.Add(this.labelCustomerID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 381);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonLoad
            // 
            this.buttonLoad.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonLoad.FlatAppearance.BorderSize = 0;
            this.buttonLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoad.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(108)))));
            this.buttonLoad.Location = new System.Drawing.Point(422, 301);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(119, 29);
            this.buttonLoad.TabIndex = 25;
            this.buttonLoad.Text = "Export";
            this.buttonLoad.UseVisualStyleBackColor = false;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonCalculate.FlatAppearance.BorderSize = 0;
            this.buttonCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalculate.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalculate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(108)))));
            this.buttonCalculate.Location = new System.Drawing.Point(149, 302);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(121, 28);
            this.buttonCalculate.TabIndex = 24;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = false;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonTicket
            // 
            this.buttonTicket.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonTicket.FlatAppearance.BorderSize = 0;
            this.buttonTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTicket.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTicket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(108)))));
            this.buttonTicket.Location = new System.Drawing.Point(547, 301);
            this.buttonTicket.Name = "buttonTicket";
            this.buttonTicket.Size = new System.Drawing.Size(197, 29);
            this.buttonTicket.TabIndex = 23;
            this.buttonTicket.Text = "View Ticket Rate";
            this.buttonTicket.UseVisualStyleBackColor = false;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(108)))));
            this.buttonSave.Location = new System.Drawing.Point(278, 301);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(138, 29);
            this.buttonSave.TabIndex = 22;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomer.Location = new System.Drawing.Point(278, 23);
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.Size = new System.Drawing.Size(466, 263);
            this.dataGridViewCustomer.TabIndex = 20;
            // 
            // dateTimePickerOutTime
            // 
            this.dateTimePickerOutTime.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(108)))));
            this.dateTimePickerOutTime.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(108)))));
            this.dateTimePickerOutTime.CustomFormat = "hh:ss tt";
            this.dateTimePickerOutTime.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerOutTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerOutTime.Location = new System.Drawing.Point(149, 179);
            this.dateTimePickerOutTime.Name = "dateTimePickerOutTime";
            this.dateTimePickerOutTime.ShowUpDown = true;
            this.dateTimePickerOutTime.Size = new System.Drawing.Size(121, 20);
            this.dateTimePickerOutTime.TabIndex = 19;
            // 
            // dateTimePickerInTime
            // 
            this.dateTimePickerInTime.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(108)))));
            this.dateTimePickerInTime.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(108)))));
            this.dateTimePickerInTime.CustomFormat = "hh:ss tt";
            this.dateTimePickerInTime.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerInTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerInTime.Location = new System.Drawing.Point(149, 153);
            this.dateTimePickerInTime.Name = "dateTimePickerInTime";
            this.dateTimePickerInTime.ShowUpDown = true;
            this.dateTimePickerInTime.Size = new System.Drawing.Size(121, 20);
            this.dateTimePickerInTime.TabIndex = 18;
            // 
            // textBoxTotalAmount
            // 
            this.textBoxTotalAmount.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(108)))));
            this.textBoxTotalAmount.Location = new System.Drawing.Point(149, 260);
            this.textBoxTotalAmount.Multiline = true;
            this.textBoxTotalAmount.Name = "textBoxTotalAmount";
            this.textBoxTotalAmount.Size = new System.Drawing.Size(121, 26);
            this.textBoxTotalAmount.TabIndex = 17;
            // 
            // textBoxTicketRate
            // 
            this.textBoxTicketRate.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTicketRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(108)))));
            this.textBoxTicketRate.Location = new System.Drawing.Point(149, 231);
            this.textBoxTicketRate.Multiline = true;
            this.textBoxTicketRate.Name = "textBoxTicketRate";
            this.textBoxTicketRate.Size = new System.Drawing.Size(121, 20);
            this.textBoxTicketRate.TabIndex = 16;
            // 
            // textBoxTotalTime
            // 
            this.textBoxTotalTime.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(108)))));
            this.textBoxTotalTime.Location = new System.Drawing.Point(149, 205);
            this.textBoxTotalTime.Multiline = true;
            this.textBoxTotalTime.Name = "textBoxTotalTime";
            this.textBoxTotalTime.Size = new System.Drawing.Size(121, 20);
            this.textBoxTotalTime.TabIndex = 15;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(108)))));
            this.dateTimePickerDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(108)))));
            this.dateTimePickerDate.CustomFormat = "dd-mm-yyyy";
            this.dateTimePickerDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePickerDate.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDate.Location = new System.Drawing.Point(149, 127);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.ShowUpDown = true;
            this.dateTimePickerDate.Size = new System.Drawing.Size(121, 20);
            this.dateTimePickerDate.TabIndex = 14;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(108)))));
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(149, 100);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCategory.TabIndex = 13;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(108)))));
            this.textBoxAddress.Location = new System.Drawing.Point(149, 74);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(121, 20);
            this.textBoxAddress.TabIndex = 12;
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(108)))));
            this.textBoxCustomerName.Location = new System.Drawing.Point(149, 48);
            this.textBoxCustomerName.Multiline = true;
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(121, 20);
            this.textBoxCustomerName.TabIndex = 11;
            // 
            // textBoxCustomerID
            // 
            this.textBoxCustomerID.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(108)))));
            this.textBoxCustomerID.Location = new System.Drawing.Point(149, 22);
            this.textBoxCustomerID.Multiline = true;
            this.textBoxCustomerID.Name = "textBoxCustomerID";
            this.textBoxCustomerID.Size = new System.Drawing.Size(121, 20);
            this.textBoxCustomerID.TabIndex = 10;
            // 
            // labelTotalAmount
            // 
            this.labelTotalAmount.AutoSize = true;
            this.labelTotalAmount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTotalAmount.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(108)))));
            this.labelTotalAmount.Location = new System.Drawing.Point(14, 263);
            this.labelTotalAmount.Name = "labelTotalAmount";
            this.labelTotalAmount.Size = new System.Drawing.Size(126, 19);
            this.labelTotalAmount.TabIndex = 9;
            this.labelTotalAmount.Text = "Total Amount:";
            // 
            // labelTicketRate
            // 
            this.labelTicketRate.AutoSize = true;
            this.labelTicketRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTicketRate.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTicketRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(108)))));
            this.labelTicketRate.Location = new System.Drawing.Point(23, 232);
            this.labelTicketRate.Name = "labelTicketRate";
            this.labelTicketRate.Size = new System.Drawing.Size(117, 19);
            this.labelTicketRate.TabIndex = 8;
            this.labelTicketRate.Text = "Ticket Rate:";
            // 
            // labelTotalTime
            // 
            this.labelTotalTime.AutoSize = true;
            this.labelTotalTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTotalTime.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(108)))));
            this.labelTotalTime.Location = new System.Drawing.Point(32, 206);
            this.labelTotalTime.Name = "labelTotalTime";
            this.labelTotalTime.Size = new System.Drawing.Size(108, 19);
            this.labelTotalTime.TabIndex = 7;
            this.labelTotalTime.Text = "Total Time:";
            // 
            // labelOutTime
            // 
            this.labelOutTime.AutoSize = true;
            this.labelOutTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelOutTime.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOutTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(108)))));
            this.labelOutTime.Location = new System.Drawing.Point(50, 180);
            this.labelOutTime.Name = "labelOutTime";
            this.labelOutTime.Size = new System.Drawing.Size(90, 19);
            this.labelOutTime.TabIndex = 6;
            this.labelOutTime.Text = "Out Time:";
            // 
            // labelInTime
            // 
            this.labelInTime.AutoSize = true;
            this.labelInTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelInTime.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(108)))));
            this.labelInTime.Location = new System.Drawing.Point(59, 154);
            this.labelInTime.Name = "labelInTime";
            this.labelInTime.Size = new System.Drawing.Size(81, 19);
            this.labelInTime.TabIndex = 5;
            this.labelInTime.Text = "In Time:";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDate.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(108)))));
            this.labelDate.Location = new System.Drawing.Point(86, 128);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(54, 19);
            this.labelDate.TabIndex = 4;
            this.labelDate.Text = "Date:";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCategory.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(108)))));
            this.labelCategory.Location = new System.Drawing.Point(50, 100);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(90, 19);
            this.labelCategory.TabIndex = 3;
            this.labelCategory.Text = "Category:";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelAddress.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(108)))));
            this.labelAddress.Location = new System.Drawing.Point(59, 75);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(81, 19);
            this.labelAddress.TabIndex = 2;
            this.labelAddress.Text = "Address:";
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCustomerName.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(108)))));
            this.labelCustomerName.Location = new System.Drawing.Point(5, 49);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(135, 19);
            this.labelCustomerName.TabIndex = 1;
            this.labelCustomerName.Text = "Customer Name:";
            // 
            // labelCustomerID
            // 
            this.labelCustomerID.AutoSize = true;
            this.labelCustomerID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCustomerID.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(108)))));
            this.labelCustomerID.Location = new System.Drawing.Point(23, 23);
            this.labelCustomerID.Name = "labelCustomerID";
            this.labelCustomerID.Size = new System.Drawing.Size(117, 19);
            this.labelCustomerID.TabIndex = 0;
            this.labelCustomerID.Text = "Customer Id:";
            // 
            // CustomerDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 381);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerDashBoard";
            this.Text = "CustomerDashBoard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelCustomerID;
        private System.Windows.Forms.Label labelTotalAmount;
        private System.Windows.Forms.Label labelTicketRate;
        private System.Windows.Forms.Label labelTotalTime;
        private System.Windows.Forms.Label labelOutTime;
        private System.Windows.Forms.Label labelInTime;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.TextBox textBoxTotalAmount;
        private System.Windows.Forms.TextBox textBoxTicketRate;
        private System.Windows.Forms.TextBox textBoxTotalTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.TextBox textBoxCustomerID;
        private System.Windows.Forms.DateTimePicker dateTimePickerInTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerOutTime;
        private System.Windows.Forms.DataGridView dataGridViewCustomer;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonTicket;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}