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

        int[] usingColumns = { 0, 1, 2, 3, 6, 7, 8, 9, 14 };

        Dictionary<string, List<List<Decimal>>> data;
        Dictionary<string, List<List<Decimal>>> dataNormalisasi;
        Dictionary<string, List<List<Decimal>>> newData;

        Dictionary<string, Decimal> mean;
        Dictionary<string, Decimal> datavariance;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rootFolder = "signs";
            data = new Dictionary<string, List<List<Decimal>>>();
            dataNormalisasi = new Dictionary<string, List<List<Decimal>>>();
            newData = new Dictionary<string, List<List<Decimal>>>();
            mean = new Dictionary<string, Decimal>();
            datavariance = new Dictionary<string, Decimal>();
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

        private void normalisasiData()
        {
            for (int i = 0; i < checkedListBoxAllKata.Items.Count; i++)
            {
                Decimal[] min = { 100, 100, 100, 100, 100, 100, 100, 100, 100 };
                Decimal[] max = { -100, -100, -100, -100, -100, -100, -100, -100, -100 };
                String kata = checkedListBoxAllKata.Items[i].ToString();
                foreach (List<Decimal> baris in data[kata])
                {
                    int ctr = 0;
                    foreach (Decimal column in baris)
                    {
                        if (column < min[ctr])
                        {
                            min[ctr] = column;
                        }
                        if (column > max[ctr])
                        {
                            max[ctr] = column;
                        }
                        ctr++;
                    }
                }
                foreach (List<Decimal> baris in data[kata])
                {
                    int ctr = 0;
                    List<Decimal> row = new List<Decimal>();
                    foreach (Decimal column in baris)
                    {
                        if (max[ctr] - min[ctr] == 0)
                        {
                            row.Add(0);
                        }
                        else
                        {
                            row.Add((column - min[ctr]) * (1 - 0) / (max[ctr] - min[ctr]));
                        }
                        ctr++;
                    }
                    dataNormalisasi[kata].Add(row);
                }
            }
        }

        private void train()
        {
            log("TRAINING");
            log("Preparing Data");

            for (int i = 0; i < checkedListBoxAllKata.Items.Count; i++)
            {
                data.Add(checkedListBoxAllKata.Items[i].ToString(), new List<List<Decimal>>());
                dataNormalisasi.Add(checkedListBoxAllKata.Items[i].ToString(), new List<List<Decimal>>());
                newData.Add(checkedListBoxAllKata.Items[i].ToString(), new List<List<Decimal>>());
                for (int j = 0; j < usingColumns.Length; j++)
                {
                    mean.Add(checkedListBoxAllKata.Items[i].ToString() + "X" + usingColumns[j], new Decimal());
                    datavariance.Add(checkedListBoxAllKata.Items[i].ToString() + "X" + usingColumns[j], new Decimal());
                }
            }
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
                                if (usingColumn == 14)
                                {
                                    if(dataKolom[usingColumn]== "0x3F")
                                    {
                                        baris.Add(1);
                                    }
                                    else
                                    {
                                        baris.Add(0);
                                    }
                                }
                                else
                                {
                                    baris.Add(Convert.ToDecimal(dataKolom[usingColumn]));
                                }
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
            Task.Run(new Action(()=>
                {
                    train();
                    normalisasiData();
                    meanNormalization();
                    variance();
                    for (int i = 0; i < checkedListBoxAllKata.Items.Count; i++)
                    {
                        List<List<Decimal>> value = newData[checkedListBoxAllKata.Items[i].ToString()];

                        foreach (var baris in value)
                        {
                            foreach (var column in baris)
                            {
                                Debug.WriteLine(column);
                            }
                        }
                    }
                })
            );
        }

        private void meanNormalization()
        {
            for (int i = 0; i < checkedListBoxAllKata.Items.Count; i++)
            {
                int length = 0;
                String kata = checkedListBoxAllKata.Items[i].ToString();
                foreach (List<Decimal> baris in dataNormalisasi[kata])
                {
                    int ctr = 0;
                    foreach (Decimal column in baris)
                    {
                        Decimal count = mean[kata + "X" + usingColumns[ctr]] + column;
                        mean[kata + "X" + usingColumns[ctr]] = count;
                        ctr++;
                    }
                    length++;
                }
                //log(i + " " + length);
                for (int j = 0; j < usingColumns.Length; j++)
                {
                    mean[kata + "X" + usingColumns[j]] = mean[kata + "X" + usingColumns[j]] / length;
                }

                foreach (List<Decimal> baris in dataNormalisasi[kata])
                {
                    List<Decimal> row = new List<Decimal>();
                    int ctr = 0;
                    foreach (Decimal column in baris)
                    {
                        row.Add(Convert.ToDecimal(column)-mean[kata + "X" + usingColumns[ctr]]);
                        ctr++;
                    }
                    newData[kata].Add(row);
                }
            }
        }

        private void variance()
        {
            for (int i = 0; i < checkedListBoxAllKata.Items.Count; i++)
            {
                String kata = checkedListBoxAllKata.Items[i].ToString();
                int length = 0;
                foreach (List<Decimal> baris in newData[kata])
                {
                    int ctr = 0;
                    foreach (Decimal column in baris)
                    {
                        Decimal count = column*column;
                        //log("count = " + (datavariance[checkedListBoxAllKata.Items[i].ToString() + "X" + usingColumns[ctr]]) + "");
                        datavariance[kata + "X" + usingColumns[ctr]] = datavariance[kata + "X" + usingColumns[ctr]]+count;
                        //log((datavariance[checkedListBoxAllKata.Items[i].ToString() + "X" + usingColumns[ctr]]) + "");
                        ctr++;
                    }
                    length++;
                }
                for (int j = 0; j < usingColumns.Length; j++)
                {
                    //log(datavariance[checkedListBoxAllKata.Items[i].ToString() + "X" + usingColumns[j]]+"");
                    Decimal temp = datavariance[kata + "X" + usingColumns[j]] / (length - 1);
                    datavariance[kata + "X" + usingColumns[j]] = temp;
                    //log(datavariance[checkedListBoxAllKata.Items[i].ToString() + "X" + usingColumns[j]] + "");
                }
            }
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
