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

namespace VorosCsanad_lamba1
{
    public partial class Form1 : Form
    {
        List<Raktar> raktar = new List<Raktar>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_beolv_Click(object sender, EventArgs e)
        {
            if (File.Exists("raktar.txt"))
            {
                StreamReader f = new StreamReader("raktar.txt");
                while(!f.EndOfStream)
                {
                    Raktar seged = new Raktar();
                    string[] raktaar = f.ReadLine().Split(';');
                    seged.Nev = raktaar[0];
                    seged.Mennyiseg = double.Parse(raktaar[1]);
                    seged.Ar = int.Parse(raktaar[2]);
                    raktar.Add(seged);
                }
                foreach (Raktar item in raktar)
                {
                    lbx_beolv.Items.Add(item);
                }
            }
        }

        private void rbtn_kbetu_CheckedChanged(object sender, EventArgs e)
        {
            lbx_eredm.Items.Clear();
            var kbetu = raktar.Where(x => x.Nev[0]=='k').ToList();
            int K = kbetu.Count;
            lbx_eredm.Items.Add(K);
           
        }

        private void rbtn_legdrag_CheckedChanged(object sender, EventArgs e)
        {
            lbx_eredm.Items.Clear();
            var legdragabb = raktar.Select(x => x.Ar).Max();
            Raktar legd = raktar.Where(x => x.Ar == legdragabb).FirstOrDefault();
            lbx_eredm.Items.Add(legd);
        }

        private void rbtn_ossz_CheckedChanged(object sender, EventArgs e)
        {
            lbx_eredm.Items.Clear();
            var osszert = raktar.Sum(x => x.Ar * x.Mennyiseg);
            lbx_eredm.Items.Add(osszert);
        }

        private void rbtn_sorrend_CheckedChanged(object sender, EventArgs e)
        {
            lbx_eredm.Items.Clear();
            var abc = raktar.OrderBy(x => x.Nev);
            foreach (var item in abc)
            {
                lbx_eredm.Items.Add(item);
            }
           
        }
    }
    class Raktar
    {
        public string Nev { get; set; }
        public double Mennyiseg { get; set; }
        public int Ar { get; set; }

        public override string ToString()
        {
            return $"Név:{Nev} Mennyiség:{Mennyiseg} Egységár:{Ar}";
        }
    }
}
