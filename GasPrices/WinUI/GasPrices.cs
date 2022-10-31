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
using GPLibrary;
/*
 * 10.26.2022
 * CSC 253
 * Lourdes Linares
 * Calculates the average price of gas per year
 * Calculates the average price per month 
 * Displays the highest and lowest prices of gas for each year
 * Makes a new text file that lists the dates and prices sorted from lowest to highest
 * Makes a new text file that lists the dates and prices sorted from highest to lowest
 * MM-DD-YYYY:Price
 * 
 */
namespace WinUI
{
    public partial class GasPrices : Form
    {
        private static List<string> fileOutput = ReadFile.FileReader("GasPrices.txt");
        private static List<GasRecord> gasPrices = new List<GasRecord>();
        public GasPrices()
        {
            InitializeComponent();
            CreateObjList();
            WriteFile();
        }


        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AvgYButton_Click(object sender, EventArgs e)
        {
            for(int i = 1993; i < 2014; i++)
            {
                List<GasRecord> avgYP = gasPrices.FindAll(gas => gas.Year == i);
                var average = avgYP.Average(gas => gas.Price); //linq
                DisplayLB.Items.Add($"{i}:{average}");
            }
             
        }

        private void AvgMButton_Click(object sender, EventArgs e)
        {
            for(int j = 1993; j < 2014; j++)
            {
                for (int i = 1; i < 13; i++)
                {
                    List<GasRecord> avgMP = gasPrices.FindAll(gas => gas.Month == i);
                    var average = avgMP.Average(gas => gas.Price); //ling
                    DisplayLB.Items.Add($"{i}-{j}:{average}");
                }
            }
            
        }

        private void HiLoPerYButton_Click(object sender, EventArgs e)
        {
            for (int i = 1993; i < 2014; i++)
            {
                List<GasRecord> perYear = gasPrices.FindAll(gas => gas.Year == i);
                var minimum = perYear.Min(gas => gas.Price);
                var maximum = perYear.Max(gas => gas.Price);
                DisplayLB.Items.Add($"Minimum price for {i} is {minimum}");
                DisplayLB.Items.Add($"Maximum price for {i} is {maximum}");
            }
            
        }

        private static void WriteFile()
        {
            StreamWriter fileHigh2Low;
            StreamWriter fileLow2High;
            string filenameL = "LowestToHighest.txt";
            string filenameH = "HighestToLowest.txt";
            try
            {
                if (File.Exists(filenameL))
                {
                    File.Delete(filenameL);
                }
                if (File.Exists(filenameH))
                {
                    File.Delete(filenameH);
                }
                fileHigh2Low = File.CreateText(filenameH);
                fileLow2High = File.CreateText(filenameL);

                var high2low = gasPrices.OrderByDescending(gas => gas.Price).ToList();
                var low2high = gasPrices.OrderBy(gas => gas.Price);
                foreach (GasRecord record in high2low)
                {
                    fileHigh2Low.WriteLine(record.ToString());
                }
                fileHigh2Low.Close();
                foreach (GasRecord record in low2high)
                {
                    fileLow2High.WriteLine(record.ToString());
                }
                fileLow2High.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private static void CreateObjList()
        {
            foreach (string item in fileOutput)
            {
                string[] dateTprice = item.Split(':');
                Double.TryParse(dateTprice[1], out double gasPrice);

                string[] dateT = dateTprice[0].Split('-');
                Int32.TryParse(dateT[0], out int M);
                Int32.TryParse(dateT[1], out int D);
                Int32.TryParse(dateT[2], out int Y);

                GasRecord gasRecord = new GasRecord(M, D, Y, gasPrice);

                gasPrices.Add(gasRecord);
            }
        }
    }
}
