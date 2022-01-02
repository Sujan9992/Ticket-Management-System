using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace coursework
{
    internal class Sorting
    {
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
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("C:/weekly_reports.csv");
            string filename = "D:/soretd.csv";
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
                    //Console.WriteLine(dataWords[2]);
                    //Console.WriteLine(i);
                    //termsList.Add(int.Parse(dataWords[2]));
                    termsList.Add(new Weekly(dataWords[0], int.Parse(dataWords[1]), int.Parse(dataWords[2])));
                }
            }
            //int[] terms = termsList.ToArray();

            Weekly[] terms = termsList.ToArray();

            for (int i = 0; i < terms.Length; i++)
            {
                Console.WriteLine("Array: " + terms[i].Day + terms[i].TotalIncome);
            }

            array1 = sort(terms);
            for (int i = 0; i < array1.Length; i++)
            {
                sortDay = array1[i].Day;
                sortTotalPeople = array1[i].TotalPeople;
                sortTotalIncome = array1[i].TotalIncome;

                if (File.Exists(filename))
                {
                    string[] reportWords = File.ReadAllLines(filename);
                    if (reportWords.Length == 8)
                    {
                        using (StreamWriter sw = new StreamWriter(filename))
                        {
                            string data = "Day,Total People,Total Income" + "\n" + sortDay + "," + sortTotalPeople + "," + sortTotalIncome;
                            sw.WriteLine(data);
                        }

                    }
                    else
                    {
                        using (StreamWriter sw = new StreamWriter(filename, append: true))
                        {
                            string data = sortDay + "," + sortTotalPeople + "," + sortTotalIncome;
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
                        string data = "Day,Total People,Total Income" + "\n" + sortDay + "," + sortTotalPeople + "," + sortTotalIncome;
                        sw.WriteLine(data);
                    }
                }

                Console.WriteLine("Sorted: " + array1[i].Day + array1[i].TotalIncome);
            }

            Console.ReadLine();
        }
    }
}
