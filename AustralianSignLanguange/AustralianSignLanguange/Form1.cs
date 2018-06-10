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
                                                                 //Dictionary<string, List<List<Double>>> newData; //x asli dikurangin mean

        //Dictionary<string, List<List<Double>>> hteta;
        //Dictionary<string, List<List<Double>>> htetaBaru;
        //Dictionary<string, List<List<Double>>> teta;


        /* linear regression var */
        Double[] y = new Double[98];
        Double[] cost = new Double[98];
        Double[] jumBaris = new Double[98];
        List<List<Double>> hteta = new List<List<Double>>();
        List<List<Double>> htetaBaru = new List<List<Double>>();
        List<List<Double>> teta = new List<List<Double>>();
        List<Double> teta0 = new List<Double>();
        List<List<Double>> tempteta = new List<List<Double>>();
        List<Double> tempteta0 = new List<Double>();
        Double alpha = 0.00000000000000000001;
        Double[] j = new Double[98];

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
            //hteta = new Dictionary<string, List<List<Double>>>();
            //htetaBaru = new Dictionary<string, List<List<Double>>>();
            //teta = new Dictionary<string, List<List<Double>>>();
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
                Double[] min = { 100, 100, 100, 100, 100, 100, 100, 100, 100 };
                Double[] max = { -100, -100, -100, -100, -100, -100, -100, -100, -100 };
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
                }
                jumBaris[i] = ctrBaris;
                teta0.Add(0);
                tempteta0.Add(0);
            }
            for (int i = 0; i < checkedListBoxAllKata.Items.Count; i++)
            {
                List<Double> sublist = new List<Double>();
                for (int j = 0; j < 9; j++)
                {
                    sublist.Add(0);
                }
                tempteta.Add(sublist);
                teta.Add(sublist);
            }
            for (int i = 0; i < y.Length; i++)
            {
                y[i] = i+1;
                cost[i] = 0;
                j[i] = 1;
            }
            for (int i = 0; i < checkedListBoxAllKata.Items.Count; i++)
            {
                y[i] = (y[i] - 1) * (1 - 0) / (98 - 1);
                List<Double> sublist = new List<Double>();
                foreach (List<Double> baris in data[checkedListBoxAllKata.Items[i].ToString()]){
                    foreach(Double column in baris)
                    {
                        //log(i + "");
                        //hteta[i].Add(0);
                        //htetaBaru[i].Add(0);
                    }
                    sublist.Add(0);
                }
                hteta.Add(sublist);
                htetaBaru.Add(sublist);
            }
        }
        
        private void Learn()
        { 
            int counterr = 0;
            while (counterr != iterasi)
            {
                counterr++;
                for (int i = 0; i < checkedListBoxAllKata.Items.Count; i++)
                {
                    String kata = checkedListBoxAllKata.Items[i].ToString();
                    int hitungBaris = 0;
                    Double tempHitung = 0;
                    //hitung hteta
                    foreach (List<Double> baris in dataNormalisasi[kata])
                    {
                        int ctr = 0;
                        tempHitung = 0;
                        tempHitung += (teta0[i]);
                        foreach (Double column in baris)
                        {
                            tempHitung += (teta[i][ctr] * column);
                            ctr++;
                            //log(column + "");
                        }
                        hteta[i][hitungBaris] = 1 / (1 + Math.Exp(-tempHitung));
                        log(hteta[i][hitungBaris] + "");
                        hitungBaris++;
                    }

                    //hitung teta
                    hitungBaris = 0;
                    foreach (List<Double> baris in dataNormalisasi[kata])
                    {
                        int ctr = 0;
                        tempteta0[i] += (hteta[i][hitungBaris] - y[i]);
                        foreach (Double column in baris)
                        {
                            tempteta[i][ctr] += ((hteta[i][hitungBaris] - y[i]) * column);
                            ctr++;
                        }
                        hitungBaris++;
                    }
                    teta0[i] = teta0[i] - (alpha * tempteta0[i]);
                    for (int j = 0; j < 9; j++)
                    {
                        teta[i][j] = teta[i][j] - (alpha * tempteta[i][j]);
                    }

                    //hitung hteta
                    hitungBaris = 0;
                    foreach (List<Double> baris in dataNormalisasi[kata])
                    {
                        int ctr = 0;
                        tempHitung += (teta0[i]);
                        foreach (Double column in baris)
                        {
                            tempHitung += (teta[i][ctr] * column);
                            ctr++;
                        }
                        hteta[i][hitungBaris] = 1 / (1 + Math.Exp(-tempHitung));
                        hitungBaris++;
                    }

                    Double total = 0;
                    for (int x = 0; x < jumBaris[i] ; x++)
                    {
                        total += ((y[i] * Math.Log(hteta[i][x])) + ((1 - y[i]) * Math.Log(1 - hteta[i][x])));
                    }
                    j[i] = -total / jumBaris[i];
                    cost[i] = j[i];
                }
            }
            //log(hteta[95][1] + "");
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
                    for (int i = 0; i < checkedListBoxAllKata.Items.Count; i++)
                    {
                        //log(y[i] + "");
                    }
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
    }
}
