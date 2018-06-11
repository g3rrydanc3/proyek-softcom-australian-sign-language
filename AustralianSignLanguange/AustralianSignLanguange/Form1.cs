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
        int iterasi = 0;

        Dictionary<string, List<List<Double>>> data; //data awal
        Dictionary<string, List<List<Double>>> dataNormalisasi; //x yang telah di normalisasi

        /* linear regression var */
        Double[] y = new Double[98];
        List<Double> newY = new List<Double>();
        Double cost = 0;
        Double jumBaris = 0;
        List<Double> hteta = new List<Double>();
        List<Double> htetaBaru = new List<Double>();
        Double[] teta = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        Double teta0 = 0;
        Double[] tempteta = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        Double tempteta0 = 0;
        Double alpha = 0.0000001;
        Double j = 50000;
        Double[] min = { 100, 100, 100, 100, 100, 100, 100, 100, 100 };
        Double[] max = { -100, -100, -100, -100, -100, -100, -100, -100, -100 };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rootFolder = "signs";
            data = new Dictionary<string, List<List<Double>>>();
            dataNormalisasi = new Dictionary<string, List<List<Double>>>();

            iterasi = 50;
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
                String kata = checkedListBoxAllKata.Items[i].ToString();
                foreach (List<Double> baris in data[kata])
                {
                    int ctr = 0;
                    foreach (Double column in baris)
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
                int ctrBaris = 0;
                foreach (List<Double> baris in data[kata])
                {
                    int ctr = 0;
                    List<Double> row = new List<Double>();
                    foreach (Double column in baris)
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
                    ctrBaris++;
                    dataNormalisasi[kata].Add(row);
                    jumBaris++;
                }
            }
            for (int i = 0; i < y.Length; i++)
            {
                y[i] = i+1;
            }
            for (int i = 0; i < checkedListBoxAllKata.Items.Count; i++)
            {
                y[i] = (y[i] - 1) * (1 - 0) / (98 - 1);
                List<Double> sublist = new List<Double>();
                foreach (List<Double> baris in data[checkedListBoxAllKata.Items[i].ToString()]){
                    foreach(Double column in baris)
                    {
                    }
                    hteta.Add(0);
                    htetaBaru.Add(0);
                    newY.Add(y[i]);
                }
            }
        }
        
        private void Learn()
        { 
            int counterr = 0;
            while (counterr != iterasi)
            {
                counterr++;
                Double tempHitung = 0;
                int hitungBaris = 0;

                //hitung hteta
                for (int i = 0; i < checkedListBoxAllKata.Items.Count; i++)
                {
                    String kata = checkedListBoxAllKata.Items[i].ToString();
                    foreach (List<Double> baris in dataNormalisasi[kata])
                    {
                        int ctr = 0;
                        tempHitung = 0;
                        tempHitung += (teta0);
                        foreach (Double column in baris)
                        {
                            tempHitung += (teta[ctr] * column);
                            ctr++;
                        }
                        hteta[hitungBaris] = 1 / (1 + Math.Exp(-tempHitung));
                        hitungBaris++;
                    }
                }

                //hitung teta
                hitungBaris = 0;
                for (int i = 0; i < checkedListBoxAllKata.Items.Count; i++)
                {
                    String kata = checkedListBoxAllKata.Items[i].ToString();
                    foreach (List<Double> baris in dataNormalisasi[kata])
                    {
                        int ctr = 0;
                        tempteta0 += (hteta[hitungBaris] - newY[hitungBaris]);
                        foreach (Double column in baris)
                        {
                            tempteta[ctr] += ((hteta[hitungBaris] - newY[hitungBaris]) * column);
                            ctr++;
                        }
                        hitungBaris++;
                    }
                }
                teta0 = teta0 - (alpha * tempteta0);
                for (int j = 0; j < 9; j++)
                {
                    teta[j] = teta[j] - (alpha * tempteta[j]);
                }


                //hitung hteta
                hitungBaris = 0;
                for (int i = 0; i < checkedListBoxAllKata.Items.Count; i++)
                {
                    String kata = checkedListBoxAllKata.Items[i].ToString();
                    foreach (List<Double> baris in dataNormalisasi[kata])
                    {
                        int ctr = 0;
                        tempHitung += (teta0);
                        foreach (Double column in baris)
                        {
                            tempHitung += (teta[ctr] * column);
                            ctr++;
                        }
                        hteta[hitungBaris] = 1 / (1 + Math.Exp(-tempHitung));
                        hitungBaris++;
                    }
                }

                Double total = 0;
                for (int x = 0; x < jumBaris; x++)
                {
                    if (hteta[x] != 0)
                    {
                        total += ((newY[x] * Math.Log(hteta[x])) + ((1 - newY[x]) * Math.Log(1 - hteta[x])));
                    }
                }
                j = -total / jumBaris;
                //log("j : " + j);
                cost = j;
            }
            iterasi = 0;
            MessageBox.Show("Iterasi Selesai");
        }

        private void train()
        {
            log("TRAINING");
            log("Preparing Data");

            for (int i = 0; i < checkedListBoxAllKata.Items.Count; i++)
            {
                data.Add(checkedListBoxAllKata.Items[i].ToString(), new List<List<Double>>());
                dataNormalisasi.Add(checkedListBoxAllKata.Items[i].ToString(), new List<List<Double>>());
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
                            List<Double> baris = new List<Double>();
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
                                    baris.Add(Convert.ToDouble(dataKolom[usingColumn]));
                                }
                            }
                            data[kata].Add(baris);
                        }
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
                    Learn();
                    for (int i = 0; i < 132; i++)
                    {
                        log("hteta : " + hteta[i]);
                    }
                    for (int x = 0; x < jumBaris; x++)
                    {
                        //log("hteta : " + hteta[x]);
                    }
                    log("jumBaris : " + jumBaris);
                    log("hteta : " + hteta[394800]);
                    log("new Y : " + newY[394800]);
                    log("teta0 : " + teta0);
                    for (int x = 0; x < 9; x++)
                    {
                        log("teta" + (x+1)  + ": " + teta[x]);
                    }
                    log("cost : " + cost);
                })
            );
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

        private void Calculate_Click(object sender, EventArgs e)
        {
            double normal1 = ((Double.Parse(x1.Text) - min[0]) * (1 - 0)) / (max[0] - min[0]);
            double normal2 = ((Double.Parse(x2.Text) - min[1]) * (1 - 0)) / (max[1] - min[1]);
            double normal3 = ((Double.Parse(x3.Text) - min[2]) * (1 - 0)) / (max[2] - min[2]);
            double normal4 = ((Double.Parse(x4.Text) - min[3]) * (1 - 0)) / (max[3] - min[3]);
            double normal5 = ((Double.Parse(x5.Text) - min[4]) * (1 - 0)) / (max[4] - min[4]);
            double normal6 = ((Double.Parse(x6.Text) - min[5]) * (1 - 0)) / (max[5] - min[5]);
            double normal7 = ((Double.Parse(x7.Text) - min[6]) * (1 - 0)) / (max[6] - min[6]);
            double normal8 = ((Double.Parse(x8.Text) - min[7]) * (1 - 0)) / (max[7] - min[7]);
            double normal9 = ((Double.Parse(x9.Text) - min[8]) * (1 - 0)) / (max[8] - min[8]);
            //double hitung = teta0[tempTeta0.Count - 1] + (tempTeta1[tempTeta0.Count - 1] * normal1) + (tempTeta2[tempTeta0.Count - 1] * normal2) + (tempTeta3[tempTeta0.Count - 1] * normal3);
            //label14.Text = ((Math.Round(1 / (1 + Math.Exp(-hitung)))) + 1).ToString();
            /*if (Math.Round(1 / (1 + Math.Exp(-hitung))) + 1 == 1)
            {
                label13.Text = "the patient survived 5 years or longer";
            }
            else
            {
                label13.Text = "the patient died within 5 year";
            }*/
        }
    }
}
