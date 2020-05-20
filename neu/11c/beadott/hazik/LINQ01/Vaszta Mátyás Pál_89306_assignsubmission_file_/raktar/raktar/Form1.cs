using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace raktar
{
   
    public partial class Form1 : Form
    {
        class Raktar
        {
            public string gyumolcs { get; set; }
            public double mennyiseg { get; set; }
            public int egysegar { get; set; }

            public override string ToString()
            {
                return $"{gyumolcs}, Mennyiség: {mennyiseg}, Egységár: {egysegar}";
            }
        }
        List<Raktar> raktar = new List<Raktar>();
        public Form1()
        {
            InitializeComponent();
        }
        void Beolvas(string fajl)
        {
            if (File.Exists(fajl))
            {
                StreamReader f = new StreamReader(fajl);
                Raktar seged = null;
                int i = 0;

                while (!f.EndOfStream)
                {
                    string[] darabolt = f.ReadLine().Split(';');
                    seged = new Raktar();
                    seged.gyumolcs = darabolt[0];
                    seged.mennyiseg =Convert.ToDouble(darabolt[1]);
                    seged.egysegar =int.Parse(darabolt[2]);
                    raktar.Add(seged);
                    ++i;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Beolvas("raktar.txt");
            raktar.ForEach(raktar => listBox1.Items.Add(raktar));
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            var k = raktar.Where(x => x.gyumolcs[0] == 'k').Count();
            listBox2.Items.Add($"A K betűvel kezdödő gyümölcsök száma: {k}");
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            int legdragabb = raktar.Max(x => x.egysegar);
            listBox2.Items.Add($"A legdrágbb gyümölcs ára: {legdragabb}");
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            int legdragabb = raktar.Max(x => x.egysegar);
            var legdragb = raktar.Find(x => x.egysegar == legdragabb);
            listBox2.Items.Add($"A legdrágbb gyümölcs neve: {legdragb.gyumolcs}");
            
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            int osszertek = raktar.Sum(x => Convert.ToInt32(x.mennyiseg) * x.egysegar);
            listBox2.Items.Add($"A raktár összértéke: {osszertek}");
        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            var newlist = raktar.OrderBy(x => x.gyumolcs);
            foreach(var item in newlist)
            { listBox2.Items.Add(item); }

        }
    }
}
