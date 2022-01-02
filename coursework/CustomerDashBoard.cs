using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace coursework
{
    public partial class CustomerDashBoard : Form
    {
        public CustomerDashBoard()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            int totalAmount;
            int total;
            String totalTime;
            int rate;

            try
            {
                String resultString;
                rate = Int32.Parse(textBoxTicketRate.Text);
                resultString = Regex.Match(totalComboBox.Text, @"\d+").Value;
                totalTime = totalTimeCOmboBox.Text;


                if (categoryComboBox.Text == "Child" || categoryComboBox.Text == "Adult")
                {
                    total = Int32.Parse(resultString);
                    totalAmount = rate * total;
                    textBoxTotalAmount.Text = totalAmount.ToString();
                }
                else
                {
                    totalAmount = rate;
                    textBoxTotalAmount.Text = totalAmount.ToString();
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error Found.");
            }
            


        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxCustomerID.Text == "")
            {
                MessageBox.Show("Enter your Customer ID.");
                textBoxCustomerID.Focus();
            }
            else if (textBoxCustomerName.Text == "")
            {
                MessageBox.Show("Enter your Customer name.");
                textBoxCustomerName.Focus();
            }      
            else if (dateTimePickerDate.Text == "")
            {
                MessageBox.Show("Enter the Date.");
                dateTimePickerDate.Focus();
            }
            else if (weekDayCombo.Text == "")
            {
                MessageBox.Show("Enter the week day.");
                weekDayCombo.Focus();
            }
            else if (dateTimePickerInTime.Text == "")
            {
                MessageBox.Show("Enter the In time.");
                dateTimePickerInTime.Focus();
            }
            else if (dateTimePickerOutTime.Text == "")
            {
                MessageBox.Show("Enter the Out time.");
                dateTimePickerOutTime.Focus();
            }
            else if (categoryComboBox.Text == "")
            {
                MessageBox.Show("Enter the category.");
                categoryComboBox.Focus();
            }
            else if (textBoxTicketRate.Text == "")
            {
                MessageBox.Show("Enter the ticket rate.");
                textBoxTicketRate.Focus();
            }
            else if (textBoxTotalAmount.Text == "")
            {
                MessageBox.Show("Enter the total amount.");
                textBoxTotalAmount.Focus();
            }
            else if (totalComboBox.Text == "")
            {
                MessageBox.Show("Enter the age.");
                totalComboBox.Focus();
            }
            else if (totalTimeCOmboBox.Text == "")
            {
                MessageBox.Show("Enter the time.");
                totalTimeCOmboBox.Focus();
            }
           
            else
            {
               
                string FileName = @"D:\customers.csv";
                    if (!File.Exists(FileName))
                    {
                        string HeaderText = "Customer ID" + "," + "Name" + "," + "Date"
                            + "," + "Day" + "," + "In Time" + "," + "Out Time" + "," + "Total Time" + "," +
                            "Category" + "," + "Total People" + "," + "Ticket Rate" + "," + "Total Amount" +
                            Environment.NewLine;
                        File.WriteAllText(FileName, HeaderText);
                    }
                    string clientDetails = textBoxCustomerID.Text + "," + textBoxCustomerName.Text + "," +
                        dateTimePickerDate.Text + "," + weekDayCombo.Text + "," + dateTimePickerInTime.Text + "," +
                        dateTimePickerOutTime.Text + "," + totalTimeCOmboBox.Text + "," + categoryComboBox.Text + "," +
                        totalComboBox.Text + "," + textBoxTicketRate.Text + "," + textBoxTotalAmount.Text +
                        "\n";
                    File.AppendAllText(FileName, clientDetails);
                    MessageBox.Show("Data Inserted");
                    BindData(FileName);

                categoryComboBox.Text = "";
                totalComboBox.Text = "";
                textBoxCustomerID.Text = "";
                textBoxCustomerName.Text = "";
                dateTimePickerDate.Text = "";
                weekDayCombo.Text = "";
                dateTimePickerInTime.Text = "";
                dateTimePickerOutTime.Text = "";
                totalTimeCOmboBox.Text = "";
                textBoxTicketRate.Text = "";
                textBoxTotalAmount.Text = "";
                
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BindData(string filePath)
        {
            DataTable dt = new DataTable();
            string[] lines = File.ReadAllLines(filePath);
            if (lines.Length > 0)
            {
                //first line to create header
                string firstLine = lines[0];
                string[] headerLabels = firstLine.Split(',');
                foreach (string headerWord in headerLabels)
                {
                    dt.Columns.Add(new DataColumn(headerWord));
                }
                //For Data
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] dataWords = lines[i].Split(',');
                    DataRow dr = dt.NewRow();
                    int columnIndex = 0;
                    foreach (string headerWord in headerLabels)
                    {
                        dr[headerWord] = dataWords[columnIndex++];
                    }
                    dt.Rows.Add(dr);
                }
            }
            if (dt.Rows.Count > 0)
            {
                dataGridViewCustomer.DataSource = dt;
            }

        }
        private void BindData1(string filePath)
        {
            DataTable dt1 = new DataTable();
            string[] lines = File.ReadAllLines(filePath);
            if (lines.Length > 0)
            {
                //first line to create header
                string firstLine = lines[0];
                string[] headerLabels = firstLine.Split(',');
                foreach (string headerWord in headerLabels)
                {
                    dt1.Columns.Add(new DataColumn(headerWord));
                }
                //For Data
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] dataWords = lines[i].Split(',');
                    DataRow dr = dt1.NewRow();
                    int columnIndex = 0;
                    foreach (string headerWord in headerLabels)
                    {
                        dr[headerWord] = dataWords[columnIndex++];
                    }
                    dt1.Rows.Add(dr);
                }
            }
            if (dt1.Rows.Count > 0)
            {
                dataGridViewTicket.DataSource = dt1;
            }

        }

        private void dateTimePickerInTime_MouseDown(object sender, MouseEventArgs e)
        {
            dateTimePickerInTime.CustomFormat = "hh:mm tt";
        }

        private void dateTimePickerOutTime_MouseDown(object sender, MouseEventArgs e)
        {
            dateTimePickerOutTime.CustomFormat = "hh:mm tt";
        }

        private void ageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {

        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonTicket_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBox1.Text = openFileDialog1.FileName;
            BindData1(textBox1.Text);
        }
    }
}
