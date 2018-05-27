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
using System.Diagnostics;
using Accord.Controls;
using Accord.MachineLearning.VectorMachines.Learning;
using Accord.Math.Optimization.Losses;
using Accord.Statistics;
using Accord.Statistics.Kernels;

namespace AustralianSignLanguange
{
    public partial class Form1 : Form
    {
        String rootFolder;

        Dictionary<string, List<List<int>>> data;

        List<String> allKata;

        int[,] mean;
        


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rootFolder = "signs";
            allKata = new List<String>();   
            data = new Dictionary<string, List<List<int>>>();
            List<List<int>> dataAlive = new List<List<int>>();
        }

        private void getAllKata(String rootFolder)
        {
            allKata.Clear();
            checkedListBoxAllKata.Items.Clear();
            checkedListBoxOrang.Items.Clear();

            log("GET ALL KATA");

            foreach (String signer in Directory.GetDirectories(rootFolder))
            {
                checkedListBoxOrang.Items.Add(signer.Split('\\')[1], true);

                foreach (String directoryFile in Directory.GetFiles(signer))
                {
                    String fileName = directoryFile.Split('\\')[2];
                    String kata = fileName.Substring(0, fileName.Length - 6).ToLower();
                    
                    if (!allKata.Contains(kata))
                    {
                        allKata.Add(kata);
                    }
                }
            }

            foreach (String kata in allKata)
            {
                checkedListBoxAllKata.Items.Add(kata, true);
            }

            log("GET ALL KATA DONE");
            log("------------------------------------");
        }

        private async void train()
        {
            log("TRAINING");
            log("Preparing Data");

            for (int i = 0; i < allKata.Count(); i++)
            {
                data.Add(allKata[i], new List<List<int>>());
            }

            await Task.Run(() =>
            {
                foreach (String signer in checkedListBoxOrang.Items)
                {
                    String signerNew = rootFolder + "\\" + signer;
                    foreach (String directoryFile in Directory.GetFiles(signerNew))
                    {
                        String fileName = directoryFile.Split('\\')[2];
                        Debug.WriteLine(fileName);
                        String kata = fileName.Substring(0, fileName.Length - 6).ToLower();
                        if (checkedListBoxAllKata.Items.Contains(kata))
                        {
                            log(kata);

                            String[] lines = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + directoryFile);

                            foreach (string line in lines)
                            {
                                for (int i = 0; i < allKata.Count(); i++)
                                {
                                    if (allKata[i] == kata)
                                    {
                                        data["alive"][0].Add(1);
                                        data["alive"][0].Add(2);
                                    }
                                }
                                // Use a tab to indent each line of the file.
                                //Debug.WriteLine("\t" + line);
                            }
                        }
                    }
                }
            });
            
            //https://github.com/accord-net/framework/wiki/Classification
            // Read the Excel worksheet into a DataTable
            //DataTable table = new ExcelReader("examples.xls").GetWorksheet("Classification - Yin Yang");

            // Convert the DataTable to input and output vectors
            //double[][] inputs = table.ToJagged<double>("X", "Y");
            //int[] outputs = table.Columns["G"].ToArray<int>();

            // Plot the data
            //ScatterplotBox.Show("Yin-Yang", inputs, outputs).Hold();
            log("------------------------------------");
        }

        private void result()
        {

        }

        private async void log(String message)
        {
            textBoxLog.Invoke(
                new Action(() =>
                {
                    textBoxLog.AppendText(message + "\r\n");
                    textBoxLog.SelectionStart = textBoxLog.TextLength;
                    textBoxLog.ScrollToCaret();
                })
            );
            
        }

        private void buttonInit_Click(object sender, EventArgs e)
        {
            getAllKata(rootFolder);
        }

        private void buttonTrain_Click(object sender, EventArgs e)
        {
            train();
        }

        private void meanNormalization()
        {

        }

        private void covariance()
        {

        }

        private void eigenValue()
        {

        }

        private void eigenVector()
        {

        }

        private void pcaResult()
        {

        }

        private void pca()
        {
            meanNormalization();
            covariance();
            eigenValue();
            eigenVector();
            pcaResult();
        }
    }
}
