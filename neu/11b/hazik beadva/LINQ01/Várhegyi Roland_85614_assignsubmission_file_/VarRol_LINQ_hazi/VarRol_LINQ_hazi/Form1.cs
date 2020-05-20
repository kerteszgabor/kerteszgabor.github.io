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
using System.Linq;


namespace VarRol_LINQ_hazi
{
    public partial class Form1 : Form
    {
        List<T> Gyumolcsok = new List<T>();
        public Form1()
        {
            InitializeComponent();
        }

        void Beolvas(string fajl)
        {
            if (File.Exists(fajl))
            {
                StreamReader f = new StreamReader(fajl);
                T seged;

                while (!f.EndOfStream)
                {
                        seged = new T();
                        string[] darabolt = f.ReadLine().Split(';');
                        seged.Gyumolcsnev =(darabolt[0]);
                        seged.Mennyiges = Convert.ToDouble(darabolt[1]);
                        seged.Egysegar = int.Parse(darabolt[2]);
                        Gyumolcsok.Add(seged);  
                }
                f.Close();
            }
        }
        

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Beolvas("raktar.txt");
            Gyumolcsok.ForEach(x => LB_1.Items.Add(x));
            rb_k_kezd.Enabled = true;
            RB_abcrend.Enabled = true;
            RB_legdragabb_gyum.Enabled = true;
            RB_osszertek.Enabled = true;
            RB_legdraggyum.Enabled = true;

        }

        

        private void rb_k_kezd_CheckedChanged(object sender, EventArgs e)
        {
            LB_2.Items.Clear();
            var osszesk = Gyumolcsok.Where(x => x.Gyumolcsnev.StartsWith("k")).Count();
            LB_2.Items.Add($"Ennyi K betűvel kezdődő gyümolcs van: {osszesk}");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            LB_2.Items.Clear();
            var legnagyobbar = Gyumolcsok.Max(x => x.Egysegar);
            LB_2.Items.Add($"Legdrágább gyümölcs ára: {legnagyobbar}");
        }

        private void RB_legdraggyum_CheckedChanged(object sender, EventArgs e)
        {
            LB_2.Items.Clear();
            var legnagyobbar = Gyumolcsok.Max(x => x.Egysegar);
            T leg = Gyumolcsok.Where(x => x.Egysegar == legnagyobbar).FirstOrDefault();
            LB_2.Items.Add($"Legdágább gyümölcs: {leg.Gyumolcsnev}");
        }

        private void RB_osszertek_CheckedChanged(object sender, EventArgs e)
        {
            LB_2.Items.Clear();
            double osszertek = Gyumolcsok.Sum(x => x.Egysegar * x.Mennyiges);
            LB_2.Items.Add($"A raktár összértéke: {osszertek}");
        }

        private void RB_abcrend_CheckedChanged(object sender, EventArgs e)
        {
            LB_2.Items.Clear();
            
            var abc = Gyumolcsok.OrderBy(x => x.Gyumolcsnev);
            foreach (var item in abc)
            {
                LB_2.Items.Add(item);
            }
        }

        
    }
    class T
    {
        public string Gyumolcsnev { get; set; }
        public double Mennyiges { get; set; }
        public int Egysegar { get; set; }

        public override string ToString()
        {
            return $"{Gyumolcsnev}, Mennyiség: {Mennyiges}, Egységár: {Egysegar}";
        }
    }
}
