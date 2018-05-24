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

namespace AustralianSignLanguange
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            load("signs");
        }

        private void load(string rootFolder)
        {
            var signers = Directory.GetDirectories(rootFolder);

            /*for (int i = 0; i < signers.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {

                }
            }*/
            foreach (var signer in signers)
            {
                var samples = Directory.GetFiles(signer);

                foreach (var sample in samples)
                {
                    string[] lines = System.IO.File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + sample);
                    

                    // Display the file contents by using a foreach loop.
                    foreach (string line in lines)
                    {
                        // Use a tab to indent each line of the file.
                        Debug.WriteLine("\t" + line);
                    }
                }
            }
        }
    }
}
