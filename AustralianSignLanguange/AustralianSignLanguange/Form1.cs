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

        int[] usingColumns = { 0, 1, 2 };

        Dictionary<string, List<List<Decimal>>> data;

        int[,] mean;
        


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rootFolder = "signs";
            data = new Dictionary<string, List<List<Decimal>>>();
        }

        private void getAllKata(String rootFolder)
        {
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
                    
                    if (!checkedListBoxAllKata.Items.Contains(kata))
                    {
                        checkedListBoxAllKata.Items.Add(kata, true);
                    }
                }
            }

            log("GET ALL KATA DONE");
            log("------------------------------------");
        }

        private async void train()
        {
            log("TRAINING");
            log("Preparing Data");

            for (int i = 0; i < checkedListBoxAllKata.Items.Count; i++)
            {
                data.Add(checkedListBoxAllKata.Items[i].ToString(), new List<List<Decimal>>());
            }

            await Task.Run(() =>
            {
                Application.UseWaitCursor = true;
                foreach (String signer in checkedListBoxOrang.CheckedItems)
                {
                    String signerNew = rootFolder + "\\" + signer;
                    foreach (String directoryFile in Directory.GetFiles(signerNew))
                    {
                        String fileName = directoryFile.Split('\\')[2];
                        String kata = fileName.Substring(0, fileName.Length - 6).ToLower();
                        if (checkedListBoxAllKata.CheckedItems.Contains(kata))
                        {
                            String[] lines = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + directoryFile);

                            foreach (string line in lines)
                            {
                                List<Decimal> baris = new List<Decimal>();
                                String[] dataKolom = line.Split(',');
                                foreach (int usingColumn in usingColumns)
                                {
                                    baris.Add(Convert.ToDecimal(dataKolom[usingColumn]));
                                }
                                data[kata].Add(baris);
                            }
                            /*foreach (List<Decimal> item1 in data[kata])
                            {
                                String temp = "";
                                foreach (Decimal item2 in item1)
                                {
                                    temp += item2 + "-";
                                }
                                log(temp);
                            }*/
                        }
                    }
                }
                Application.UseWaitCursor = false;
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

        private void log(String message)
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

        private void buttonOrangSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxOrang.Items.Count; i++)
            {
                checkedListBoxOrang.SetItemChecked(i, true);
            }
        }

        private void buttonOrangUnselectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxOrang.Items.Count; i++)
            {
                checkedListBoxOrang.SetItemChecked(i, false);
            }
        }

        private void buttonKataSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxAllKata.Items.Count; i++)
            {
                checkedListBoxAllKata.SetItemChecked(i, true);
            }
        }

        private void buttonKataUnselectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxAllKata.Items.Count; i++)
            {
                checkedListBoxAllKata.SetItemChecked(i, false);
            }
        }
    }
}
