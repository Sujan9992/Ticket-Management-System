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

namespace coursework
{
    public partial class ReportDashboard : Form
    {

        public ReportDashboard()
        {
            InitializeComponent();
        }

        private void dailyGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {         

        }

        private void viewDailyReport_Click(object sender, EventArgs e)
        {
            
            string[] lines = File.ReadAllLines("D:/customers.csv");
            int child = 0;
            int adult = 0;
            int group5 = 0;
            int group10 = 0;
            int group15 = 0;
        

            DateTime date = DateTime.Now;
            string dateNow = date.ToString("MM/dd/yyyy");

            if (lines.Length > 0)
            {
                //For Data
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] dataWords = lines[i].Split(',');

                   
                        if (dataWords[7].Equals("Child"))
                        {
                            child += int.Parse(dataWords[8]);
                        }
                        else if (dataWords[7].Equals("Adult"))
                        {
                            adult += int.Parse(dataWords[8]);
                        }
                        else if (dataWords[7].Equals("Group of 5"))
                        {
                            group5 += int.Parse(dataWords[8]);
                        }
                        else if (dataWords[7].Equals("Group of 10"))
                        {
                            group10 += int.Parse(dataWords[8]);
                        }
                        else if (dataWords[7].Equals("Group of 15"))
                        {
                            group15 += int.Parse(dataWords[8]);
                        }                     
                    
                }

                string filename = "D:/daily_reports.csv";
                if (File.Exists(filename))
                {
                    string[] reportWords = File.ReadAllLines(filename);
                    using (StreamWriter sw = new StreamWriter(filename))
                    {
                        if (reportWords.Length != 0)
                        {
                            string data = "Category," + "Total People," + "Date" + "\nChild," + child + "," + dateNow + "\nAdult," + adult + "," + dateNow + "\nGroup of 5," + group5 + "," + dateNow + "\nGroup of 10," + group10 + "," + dateNow + "\nGroup of 15," + group15 + "," + dateNow;
                            sw.WriteLine(data);
                        }
                        else
                        {
                            string data = "Child," + child + "," + dateNow + "\nAdult," + adult + "," + dateNow + "\nGroup of 5," + group5 + "," + dateNow + "\nGroup of 10," + group10 + "," + dateNow + "\nGroup 15," + group15 + "," + dateNow;
                            sw.WriteLine(data);
                        }
                    }
                }
                else
                {
                    var myFile = File.Create(filename);
                    myFile.Close();

                    using (StreamWriter sw = new StreamWriter(filename))
                    {
                        string data = "Category," + "Total People," + "Date" + "\nChild," + child + "," + dateNow + "\nAdult," + adult + "," + dateNow + "\nGroup of 5," + group5 + "," + dateNow + "\nGroup of 10," + group10 + "," + dateNow + "\nGroup of 15," + group15 + "," + dateNow;
                        sw.WriteLine(data);

                    }
                }
                MessageBox.Show("Daily Report created sucessfully.", "Sucess");
                BindData(filename);
            }
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
                dailyGrid.DataSource = dt;
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
                weeklyGrid.DataSource = dt1;
            }

        }
        private void BindData2(string filePath)
        {
            DataTable dt2 = new DataTable();
            string[] lines = File.ReadAllLines(filePath);
            if (lines.Length > 0)
            {
                //first line to create header
                string firstLine = lines[0];
                string[] headerLabels = firstLine.Split(',');
                foreach (string headerWord in headerLabels)
                {
                    dt2.Columns.Add(new DataColumn(headerWord));
                }
                //For Data
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] dataWords = lines[i].Split(',');
                    DataRow dr = dt2.NewRow();
                    int columnIndex = 0;
                    foreach (string headerWord in headerLabels)
                    {
                        dr[headerWord] = dataWords[columnIndex++];
                    }
                    dt2.Rows.Add(dr);
                }
            }
            if (dt2.Rows.Count > 0)
            {
                weeklyGrid.DataSource = dt2;
            }

        }


        private void viewWeeklyReport_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("D:/customers.csv");
            int peopleSunday = 0;
            int peopleMonday = 0;
            int peopleTuesday = 0;
            int peopleWednesday = 0;
            int peopleThursday = 0;
            int peopleFriday = 0;
            int peopleSaturday = 0;

            double moneySunday = 0;
            double moneyMonday = 0;
            double moneyTuesday = 0;
            double moneyWednesday = 0;
            double moneyThursday = 0;
            double moneyFriday = 0;
            double moneySaturday = 0;

            if (lines.Length > 0)
            {
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] dataWords = lines[i].Split(',');
                    string dataDate = dataWords[2];

                    DateTime date = DateTime.Now;
                    string dateNow = date.ToString("MM/dd/yyyy");

                    DateTime oDate1 = Convert.ToDateTime(dataDate);
                    DateTime oDate2 = Convert.ToDateTime(dateNow);

                    double diff = (oDate2 - oDate1).TotalDays;

                    if (diff <= 7)
                    {
                        if (dataWords[3].Equals("Sunday"))
                        {
                            peopleSunday += int.Parse(dataWords[8]);
                            moneySunday += double.Parse(dataWords[10]);
                        }
                        else if (dataWords[3].Equals("Monday"))
                        {
                            peopleMonday += int.Parse(dataWords[8]);
                            moneyMonday += double.Parse(dataWords[10]);
                        }
                        else if (dataWords[3].Equals("Tuesday"))
                        {
                            peopleTuesday += int.Parse(dataWords[8]);
                            moneyTuesday += double.Parse(dataWords[10]);
                        }
                        else if (dataWords[3].Equals("Wednesday"))
                        {
                            peopleWednesday += int.Parse(dataWords[8]);
                            moneyWednesday += double.Parse(dataWords[10]);
                        }
                        else if (dataWords[3].Equals("Thursday"))
                        {
                            peopleThursday += int.Parse(dataWords[8]);
                            moneyThursday += double.Parse(dataWords[10]);
                        }
                        else if (dataWords[3].Equals("Friday"))
                        {
                            peopleFriday += int.Parse(dataWords[8]);
                            moneyFriday += double.Parse(dataWords[10]);
                        }
                        else if (dataWords[3].Equals("Saturday"))
                        {
                            peopleSaturday += int.Parse(dataWords[8]);
                            moneySaturday += double.Parse(dataWords[10]);
                        }
                    }
                }

                string filename1 = "D:/weekly_reports.csv";
                if (File.Exists(filename1))
                {
                    string[] reportWords = File.ReadAllLines(filename1);
                    using (StreamWriter sw = new StreamWriter(filename1))
                    {
                        if (reportWords.Length != 0)
                        {
                            string data = "Day," + "Total People," + "Total Income" + "\nSunday," + peopleSunday + "," + moneySunday + "\nMonday," + peopleMonday + "," + moneyMonday + "\nTuesday," + peopleTuesday + "," + moneyTuesday + "\nWednesday," + peopleWednesday + "," + moneyWednesday + "\nThursday," + peopleThursday + "," + moneyThursday + "\nFriday," + peopleFriday + "," + moneyFriday + "\nSaturday," + peopleSaturday + "," + moneySaturday;
                            sw.WriteLine(data);
                        }
                        else
                        {
                            string data = "Sunday," + peopleSunday + "," + moneySunday + "\nMonday," + peopleMonday + "," + moneyMonday + "\nTuesday," + peopleTuesday + "," + moneyTuesday + "\nWednesday," + peopleWednesday + "," + moneyWednesday + "\nThursday," + peopleThursday + "," + moneyThursday + "\nFriday," + peopleFriday + "," + moneyFriday + "\nSaturday," + peopleSaturday + "," + moneySaturday;
                            sw.WriteLine(data);
                        }
                    }
                }
                else
                {
                    var myFile = File.Create(filename1);
                    myFile.Close();

                    using (StreamWriter sw = new StreamWriter(filename1))
                    {

                        string data = "Day," + "Total People," + "Total Income" + "\nSunday," + peopleSunday + "," + moneySunday + "\nMonday," + peopleMonday + "," + moneyMonday + "\nTuesday," + peopleTuesday + "," + moneyTuesday + "\nWednesday," + peopleWednesday + "," + moneyWednesday + "\nThursday," + peopleThursday + "," + moneyThursday + "\nFriday," + peopleFriday + "," + moneyFriday + "\nSaturday," + peopleSaturday + "," + moneySaturday;
                        sw.WriteLine(data);

                    }
                }
                MessageBox.Show("Weekly Report created sucessfully.", "Sucess");
                BindData1(filename1);
            }          

        }
        private static Weekly[] sort(Weekly[] a)
        {
            for (int i = 0; i < a.Length - 1; i++) //to place the element in it's correct spot
            {
                int minPos = i;
                for (int j = i + 1; j < a.Length; j++)
                { //to go through the unsorted array inorder for us to find the smallest element
                    if (a[j].TotalIncome < a[minPos].TotalIncome)
                    {
                        minPos = j;
                    }
                }
                //swapping elements
                Weekly temp = a[i];
                a[i] = a[minPos];
                a[minPos] = temp;
            }
            return a;
        }
        private void buttonSort_Click(object sender, EventArgs e)
        {
            
            string[] lines = File.ReadAllLines("D:/weekly_reports.csv");
            string filename3 = "D:/soretd.csv";
            Weekly[] array1 = new Weekly[7];
            List<Weekly> termsList = new List<Weekly>();

            string sortDay = "";
            int sortTotalPeople = 0;
            int sortTotalIncome = 0;

            if (lines.Length > 0)
            {
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] dataWords = lines[i].Split(',');
                    termsList.Add(new Weekly(dataWords[0], int.Parse(dataWords[1]), int.Parse(dataWords[2])));
                }
            }
            Weekly[] terms = termsList.ToArray();

            array1 = sort(terms);
            for (int i = 0; i < array1.Length; i++)
            {
                sortDay = array1[i].Day;
                sortTotalPeople = array1[i].TotalPeople;
                sortTotalIncome = array1[i].TotalIncome;

                if (File.Exists(filename3))
                {
                    string[] reportWords = File.ReadAllLines(filename3);
                    if (reportWords.Length == 8)
                    {
                        using (StreamWriter sw = new StreamWriter(filename3))
                        {
                            string data = "Day,Total People,Total Income" + "\n" + sortDay + "," + sortTotalPeople + "," + sortTotalIncome;
                            sw.WriteLine(data);
                        }

                    }
                    else
                    {
                        using (StreamWriter sw = new StreamWriter(filename3, append: true))
                        {
                            string data = sortDay + "," + sortTotalPeople + "," + sortTotalIncome;
                            sw.WriteLine(data);
                        }

                    }

                }
                else
                {
                    var myFile = File.Create(filename3);
                    myFile.Close();

                    using (StreamWriter sw = new StreamWriter(filename3))
                    {
                        string data = "Day,Total People,Total Income" + "\n" + sortDay + "," + sortTotalPeople + "," + sortTotalIncome;
                        sw.WriteLine(data);
                    }
                }
               
            }
            MessageBox.Show("Data sorted sucessfully.", "Sucess");
            BindData2(filename3);
        }
    }
}
