using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coursework
{
    public partial class ChartDashBoard : Form
    {
        public ChartDashBoard()
        {
            InitializeComponent();
        }

        private void chartBtn_Click(object sender, EventArgs e)
        {
            loadChart();
        }
        private void showChart(int ps, int pm, int pt, int pw, int pth, int pf, int psa, double ms, double mm, double mt, double mw, double mth, double mf, double msa)
        {
            chart1.Series["Price"].Points.AddXY("Sunday",ps);
            chart1.Series["Price"].Points.AddXY("Monday", pm);
            chart1.Series["Price"].Points.AddXY("Tuesday", pt);
            chart1.Series["Price"].Points.AddXY("Wednesday", pw);
            chart1.Series["Price"].Points.AddXY("Thursday", pth);
            chart1.Series["Price"].Points.AddXY("Friday", pf);
            chart1.Series["Price"].Points.AddXY("Saturday", psa);


            chart1.Series["People"].Points.AddXY("Sunday", ms);
            chart1.Series["People"].Points.AddXY("Monday", mm);
            chart1.Series["People"].Points.AddXY("Tuesday", mt);
            chart1.Series["People"].Points.AddXY("Wednesday", mw);
            chart1.Series["People"].Points.AddXY("Thursday", mth);
            chart1.Series["People"].Points.AddXY("Friday", mf);
            chart1.Series["People"].Points.AddXY("Saturday", msa);
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
                
            }

        }
        private void loadChart() {
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
                showChart(peopleSunday, peopleMonday, peopleTuesday, peopleWednesday, peopleThursday, peopleFriday, peopleSaturday, moneySunday, moneyMonday, moneyTuesday, moneyWednesday, moneyThursday, moneyFriday, moneySaturday);

                MessageBox.Show("Weekly Report created sucessfully.", "Sucess");
                BindData1(filename1);
            }
        }
    }
}
