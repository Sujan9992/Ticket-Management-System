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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.totalComboBox = new System.Windows.Forms.ComboBox();
            this.totalText = new System.Windows.Forms.Label();
            this.dataGridViewTicket = new System.Windows.Forms.DataGridView();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryText = new System.Windows.Forms.Label();
            this.totalTimeCOmboBox = new System.Windows.Forms.ComboBox();
            this.weekDayCombo = new System.Windows.Forms.ComboBox();
            this.weekDayTxt = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonTicket = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.dateTimePickerOutTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerInTime = new System.Windows.Forms.DateTimePicker();
            this.textBoxTotalAmount = new System.Windows.Forms.TextBox();
            this.textBoxTicketRate = new System.Windows.Forms.TextBox();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.textBoxCustomerID = new System.Windows.Forms.TextBox();
            this.labelTotalAmount = new System.Windows.Forms.Label();
            this.labelTicketRate = new System.Windows.Forms.Label();
            this.labelTotalTime = new System.Windows.Forms.Label();
            this.labelOutTime = new System.Windows.Forms.Label();
            this.labelInTime = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.labelCustomerID = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTicket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.totalComboBox);
            this.mainPanel.Controls.Add(this.totalText);
            this.mainPanel.Controls.Add(this.textBox1);
            this.mainPanel.Controls.Add(this.dataGridViewTicket);
            this.mainPanel.Controls.Add(this.categoryComboBox);
            this.mainPanel.Controls.Add(this.categoryText);
            this.mainPanel.Controls.Add(this.totalTimeCOmboBox);
            this.mainPanel.Controls.Add(this.weekDayCombo);
            this.mainPanel.Controls.Add(this.weekDayTxt);
            this.mainPanel.Controls.Add(this.buttonCalculate);
            this.mainPanel.Controls.Add(this.buttonTicket);
            this.mainPanel.Controls.Add(this.buttonSave);
            this.mainPanel.Controls.Add(this.dataGridViewCustomer);
            this.mainPanel.Controls.Add(this.dateTimePickerOutTime);
            this.mainPanel.Controls.Add(this.dateTimePickerInTime);
            this.mainPanel.Controls.Add(this.textBoxTotalAmount);
            this.mainPanel.Controls.Add(this.textBoxTicketRate);
            this.mainPanel.Controls.Add(this.dateTimePickerDate);
            this.mainPanel.Controls.Add(this.textBoxCustomerName);
            this.mainPanel.Controls.Add(this.textBoxCustomerID);
            this.mainPanel.Controls.Add(this.labelTotalAmount);
            this.mainPanel.Controls.Add(this.labelTicketRate);
            this.mainPanel.Controls.Add(this.labelTotalTime);
            this.mainPanel.Controls.Add(this.labelOutTime);
            this.mainPanel.Controls.Add(this.labelInTime);
            this.mainPanel.Controls.Add(this.labelDate);
            this.mainPanel.Controls.Add(this.labelCustomerName);
            this.mainPanel.Controls.Add(this.labelCustomerID);
            this.mainPanel.Location = new System.Drawing.Point(3, 3);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(891, 526);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // totalComboBox
            // 
            this.totalComboBox.FormattingEnabled = true;
            this.totalComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "10",
            "15"});
            this.totalComboBox.Location = new System.Drawing.Point(149, 239);
            this.totalComboBox.Name = "totalComboBox";
            this.totalComboBox.Size = new System.Drawing.Size(121, 21);
            this.totalComboBox.TabIndex = 39;
            // 
            // totalText
            // 
            this.totalText.AutoSize = true;
            this.totalText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(108)))));
            this.totalText.Location = new System.Drawing.Point(77, 238);
            this.totalText.Name = "totalText";
            this.totalText.Size = new System.Drawing.Size(63, 19);
            this.totalText.TabIndex = 38;
            this.totalText.Text = "Total:";
            // 
            // dataGridViewTicket
            // 
            this.dataGridViewTicket.AllowUserToAddRows = false;
            this.dataGridViewTicket.AllowUserToDeleteRows = false;
            this.dataGridViewTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTicket.Location = new System.Drawing.Point(278, 324);
            this.dataGridViewTicket.Name = "dataGridViewTicket";
            this.dataGridViewTicket.ReadOnly = true;
            this.dataGridViewTicket.Size = new System.Drawing.Size(524, 135);
            this.dataGridViewTicket.TabIndex = 36;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "Child",
            "Adult",
            "Group of 5",
            "Group of 10",
            "Group of 15"});
            this.categoryComboBox.Location = new System.Drawing.Point(149, 213);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.categoryComboBox.TabIndex = 35;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // categoryText
            // 
            this.categoryText.AutoSize = true;
            this.categoryText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(108)))));
            this.categoryText.Location = new System.Drawing.Point(50, 212);
            this.categoryText.Name = "categoryText";
            this.categoryText.Size = new System.Drawing.Size(90, 19);
            this.categoryText.TabIndex = 34;
            this.categoryText.Text = "Category:";
            // 
            // totalTimeCOmboBox
            // 
            this.totalTimeCOmboBox.FormattingEnabled = true;
            this.totalTimeCOmboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "Whole Day"});
            this.totalTimeCOmboBox.Location = new System.Drawing.Point(149, 182);
            this.totalTimeCOmboBox.Name = "totalTimeCOmboBox";
            this.totalTimeCOmboBox.Size = new System.Drawing.Size(121, 21);
            this.totalTimeCOmboBox.TabIndex = 33;
            // 
            // weekDayCombo
            // 
            this.weekDayCombo.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekDayCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(108)))));
            this.weekDayCombo.FormattingEnabled = true;
            this.weekDayCombo.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.weekDayCombo.Location = new System.Drawing.Point(149, 103);
            this.weekDayCombo.Name = "weekDayCombo";
            this.weekDayCombo.Size = new System.Drawing.Size(121, 21);
            this.weekDayCombo.TabIndex = 27;
            // 
            // weekDayTxt
            // 
            this.weekDayTxt.AutoSize = true;
            this.weekDayTxt.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekDayTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(108)))));
            this.weekDayTxt.Location = new System.Drawing.Point(50, 101);
            this.weekDayTxt.Name = "weekDayTxt";
            this.weekDayTxt.Size = new System.Drawing.Size(90, 19);
            this.weekDayTxt.TabIndex = 26;
            this.weekDayTxt.Text = "Week Day:";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonCalculate.FlatAppearance.BorderSize = 0;
            this.buttonCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalculate.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalculate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(108)))));
            this.buttonCalculate.Location = new System.Drawing.Point(149, 321);
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
            this.buttonTicket.Location = new System.Drawing.Point(631, 289);
            this.buttonTicket.Name = "buttonTicket";
            this.buttonTicket.Size = new System.Drawing.Size(171, 29);
            this.buttonTicket.TabIndex = 23;
            this.buttonTicket.Text = "View Ticket Rate";
            this.buttonTicket.UseVisualStyleBackColor = false;
            this.buttonTicket.Click += new System.EventHandler(this.buttonTicket_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(108)))));
            this.buttonSave.Location = new System.Drawing.Point(519, 290);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(96, 29);
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
            this.dataGridViewCustomer.Size = new System.Drawing.Size(524, 260);
            this.dataGridViewCustomer.TabIndex = 20;
            // 
            // dateTimePickerOutTime
            // 
            this.dateTimePickerOutTime.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(108)))));
            this.dateTimePickerOutTime.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(108)))));
            this.dateTimePickerOutTime.CustomFormat = " ";
            this.dateTimePickerOutTime.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerOutTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerOutTime.Location = new System.Drawing.Point(149, 156);
            this.dateTimePickerOutTime.Name = "dateTimePickerOutTime";
            this.dateTimePickerOutTime.ShowUpDown = true;
            this.dateTimePickerOutTime.Size = new System.Drawing.Size(121, 20);
            this.dateTimePickerOutTime.TabIndex = 19;
            this.dateTimePickerOutTime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dateTimePickerOutTime_MouseDown);
            // 
            // dateTimePickerInTime
            // 
            this.dateTimePickerInTime.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(108)))));
            this.dateTimePickerInTime.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(108)))));
            this.dateTimePickerInTime.CustomFormat = " ";
            this.dateTimePickerInTime.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerInTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerInTime.Location = new System.Drawing.Point(149, 130);
            this.dateTimePickerInTime.Name = "dateTimePickerInTime";
            this.dateTimePickerInTime.ShowUpDown = true;
            this.dateTimePickerInTime.Size = new System.Drawing.Size(121, 20);
            this.dateTimePickerInTime.TabIndex = 18;
            this.dateTimePickerInTime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dateTimePickerInTime_MouseDown);
            // 
            // textBoxTotalAmount
            // 
            this.textBoxTotalAmount.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(108)))));
            this.textBoxTotalAmount.Location = new System.Drawing.Point(149, 292);
            this.textBoxTotalAmount.Multiline = true;
            this.textBoxTotalAmount.Name = "textBoxTotalAmount";
            this.textBoxTotalAmount.ReadOnly = true;
            this.textBoxTotalAmount.Size = new System.Drawing.Size(121, 22);
            this.textBoxTotalAmount.TabIndex = 17;
            // 
            // textBoxTicketRate
            // 
            this.textBoxTicketRate.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTicketRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(108)))));
            this.textBoxTicketRate.Location = new System.Drawing.Point(149, 266);
            this.textBoxTicketRate.Multiline = true;
            this.textBoxTicketRate.Name = "textBoxTicketRate";
            this.textBoxTicketRate.Size = new System.Drawing.Size(121, 20);
            this.textBoxTicketRate.TabIndex = 16;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(108)))));
            this.dateTimePickerDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(108)))));
            this.dateTimePickerDate.CustomFormat = "dd-mm-yyyy";
            this.dateTimePickerDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePickerDate.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDate.Location = new System.Drawing.Point(149, 77);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.ShowUpDown = true;
            this.dateTimePickerDate.Size = new System.Drawing.Size(121, 20);
            this.dateTimePickerDate.TabIndex = 14;
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
            this.labelTotalAmount.Location = new System.Drawing.Point(14, 295);
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
            this.labelTicketRate.Location = new System.Drawing.Point(23, 264);
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
            this.labelTotalTime.Location = new System.Drawing.Point(41, 182);
            this.labelTotalTime.Name = "labelTotalTime";
            this.labelTotalTime.Size = new System.Drawing.Size(99, 19);
            this.labelTotalTime.TabIndex = 7;
            this.labelTotalTime.Text = "Time(Hrs):";
            // 
            // labelOutTime
            // 
            this.labelOutTime.AutoSize = true;
            this.labelOutTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelOutTime.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOutTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(108)))));
            this.labelOutTime.Location = new System.Drawing.Point(50, 157);
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
            this.labelInTime.Location = new System.Drawing.Point(59, 130);
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
            this.labelDate.Location = new System.Drawing.Point(86, 78);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(54, 19);
            this.labelDate.TabIndex = 4;
            this.labelDate.Text = "Date:";
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(108)))));
            this.textBox1.Location = new System.Drawing.Point(278, 292);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(235, 20);
            this.textBox1.TabIndex = 37;
            // 
            // CustomerDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 537);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerDashBoard";
            this.Text = "CustomerDashBoard";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTicket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label labelCustomerID;
        private System.Windows.Forms.Label labelTotalAmount;
        private System.Windows.Forms.Label labelTicketRate;
        private System.Windows.Forms.Label labelTotalTime;
        private System.Windows.Forms.Label labelOutTime;
        private System.Windows.Forms.Label labelInTime;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.TextBox textBoxTotalAmount;
        private System.Windows.Forms.TextBox textBoxTicketRate;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.TextBox textBoxCustomerID;
        private System.Windows.Forms.DateTimePicker dateTimePickerInTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerOutTime;
        private System.Windows.Forms.DataGridView dataGridViewCustomer;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonTicket;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label weekDayTxt;
        private System.Windows.Forms.ComboBox weekDayCombo;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label categoryText;
        private System.Windows.Forms.ComboBox totalTimeCOmboBox;
        private System.Windows.Forms.DataGridView dataGridViewTicket;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label totalText;
        private System.Windows.Forms.ComboBox totalComboBox;
        private System.Windows.Forms.TextBox textBox1;
    }
}