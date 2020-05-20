using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Schvorczi_Gergo_raktar_05._10
{
    public partial class Form1 : Form
    {
        List<Adatok> raktar = new List<Adatok>();
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_beolv_Click(object sender, EventArgs e)
        {
            rb_kval.Enabled = true;
            rb_legd.Enabled = true;
            rb_ossz.Enabled = true;
            rb_abc.Enabled = true;

            lb_beolv.Items.Clear();

            if (File.Exists("raktar.txt"))
            {
                StreamReader f = new StreamReader("raktar.txt");
                
                while (!f.EndOfStream)
                {
                    Adatok seged = new Adatok();
                    string[] split = f.ReadLine().Split(';');
                    seged.Gyumolcsnev = split[0];
                    seged.Mennyiseg = double.Parse(split[1]);
                    seged.Egysegar = int.Parse(split[2]);
                    raktar.Add(seged);
                }
                foreach ( Adatok item in raktar)
                { lb_beolv.Items.Add(item.ToString()); }
            }
        }

        private void rb_kval_CheckedChanged(object sender, EventArgs e)
        {
            lb_ered.Items.Clear();
            var Kval = raktar.Where(x => x.Gyumolcsnev[0]=='k').ToList();
            int kval = Kval.Count;
            lb_ered.Items.Add($"K beűvel kezdődő gyümölcsök száma: {kval}");
        }

        private void rb_legd_CheckedChanged(object sender, EventArgs e)
        {
            lb_ered.Items.Clear();
            var legdr = raktar.Select(x => x.Egysegar).Max();
            Adatok Legdr = raktar.Where(x => x.Egysegar == legdr).FirstOrDefault();
            lb_ered.Items.Add($"A legdrágább gyümölcs a(z) {Legdr.Gyumolcsnev}, az egységára: {Legdr.Egysegar}/kg");
        }

        private void rb_ossz_CheckedChanged(object sender, EventArgs e)
        {
            lb_ered.Items.Clear();
            double ossz = raktar.Sum(x => x.Egysegar*x.Mennyiseg);
            lb_ered.Items.Add($"A raktár összértéke: {ossz} Ft");
        }

        private void rb_abc_CheckedChanged(object sender, EventArgs e)
        {
            lb_ered.Items.Clear();
            var abc = raktar.OrderBy(x => x.Gyumolcsnev);
            foreach (var item in abc)
            { lb_ered.Items.Add(item); }
        }
    }

    class Adatok
    {
        public string Gyumolcsnev { get; set; }
        public double Mennyiseg { get; set; }
        public int Egysegar { get; set; }

        public override string ToString()
        {
            return $"Név: {Gyumolcsnev}, Mennyiség: {Mennyiseg} kg, Egységára: {Egysegar} Ft." ;
        }
    }
}
