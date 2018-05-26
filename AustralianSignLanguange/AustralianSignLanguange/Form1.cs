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
        Dictionary<string, List<int>> data;

        String[] kata = {"alive", "all", "answer", "boy", "building", "buy", "change",
                    "cold", "come", "computer", "cost", "crazy", "danger", "deaf",
                    "different", "draw", "drink", "eat", "exit", "flash-light",
                    "forget", "girl", "give", "glove", "go", "God", "happy", "head",
                    "hear","hello", "her", "hot", "how", "hurry", "hurt", "I",
                    "innocent", "is", "joke", "juice", "know", "later", "lose",
                    "love", "make", "man", "maybe", "mine", "money", "more", "name",
                    "no", "Norway", "not-my-problem", "paper", "pen", "please",
                    "polite", "question", "read", "ready", "research", "responsible",
                    "right", "sad", "same", "science", "share", "shop", "soon",
                    "sorry", "spend", "stubborn", "surprise", "take", "temper",
                    "thank", "think", "tray", "us", "voluntary", "wait", "what",
                    "when", "where", "which", "who", "why", "wild", "will",
                    "write", "wrong", "yes", "you", "zero"};

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            data = new Dictionary<string, List<int>>();

            data.Add("alive", new List<int>());
            data["alive"].Add(123);
            data["alive"].Add(123);
            data["alive"].Add(123);
            data["alive"].Add(123);
            
            load("signs");
        }

        private void load(string rootFolder)
        {
            var signers = Directory.GetDirectories(rootFolder);

            foreach (var signer in signers)
            {
                var samples = Directory.GetFiles(signer);
                foreach (var sample in samples)
                {
                    String name = sample.ToString();
                    String[] filename = name.Split('\\');
                    
                    string[] lines = System.IO.File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + sample);
                    
                    // Display the file contents by using a foreach loop.
                    foreach (string line in lines)
                    {
                        for(int i = 0; i < kata.Length; i++)
                        {
                            if (kata[i] == filename[2])
                            {

                            }
                        }
                        // Use a tab to indent each line of the file.
                        //Debug.WriteLine("\t" + line);
                    }
                }
            }
        }
    }
}
