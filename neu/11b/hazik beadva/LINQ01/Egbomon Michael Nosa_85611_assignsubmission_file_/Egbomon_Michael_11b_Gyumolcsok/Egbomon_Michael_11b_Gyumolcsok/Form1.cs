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

namespace Egbomon_Michael_11b_Gyumolcsok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text = "Egbomon Michael 11b - Gyümölcsök";
        }

        List<Gyumolcs> gyumolcsok = new List<Gyumolcs>();

        void Beolvas(string f)
        {
            if (File.Exists(f))
            {
                StreamReader fbe = new StreamReader(f);
                Gyumolcs seged=null;
                int i = 0;

                while (!fbe.EndOfStream)
                {
                    seged = new Gyumolcs();
                    string[] darabolt = fbe.ReadLine().Split(';');
                    seged.Nev = darabolt[0];
                    seged.Mennyiseg = double.Parse(darabolt[1]);
                    seged.Ar = int.Parse(darabolt[2]);

                    gyumolcsok.Add(seged);

                    ++i;
                }
                fbe.Close();
                gp_opciok.Enabled = true;
            }
            else
            {
                MessageBox.Show("A megadott fájl nem létezik!", "Beolvasási Hiba",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btn_beolvas_Click(object sender, EventArgs e)
        {
            lb_elemek.Items.Clear();

            Beolvas("raktar.txt");

            gyumolcsok.ForEach(gyumolcsok => lb_elemek.Items.Add(gyumolcsok));

        }

        private void rb_k_betuvel_kezdodo_CheckedChanged(object sender, EventArgs e)
        {
            lb_eredmeny.Items.Clear();

            int Kdarab = gyumolcsok.Where(x => x.Nev.ToLower().StartsWith("k")).Count();

            lb_eredmeny.Items.Add($"{Kdarab} darab k betűvel kezdődő gyümölcsnév van!");

        }

        private void rb_legdragabb_ar_CheckedChanged(object sender, EventArgs e)
        {
            lb_eredmeny.Items.Clear();

            double MaxAr = gyumolcsok.Max(x => x.Ar);

            lb_eredmeny.Items.Add($"A legdrágább gyümölcs ára: {MaxAr}");

        }

        private void rb_legdragabb_gyumolcs_CheckedChanged(object sender, EventArgs e)
        {
            lb_eredmeny.Items.Clear();

            Gyumolcs legdragabb = gyumolcsok.Find(x => x.Ar == gyumolcsok.Max(n=>n.Ar));

            lb_eredmeny.Items.Add($"A legdrágább gyümölcs neve: {legdragabb.Nev}");

        }

        private void rb_raktar_osszertek_CheckedChanged(object sender, EventArgs e)
        {
            lb_eredmeny.Items.Clear();

            double OsszErtek = gyumolcsok.Sum(x => x.Ar * x.Mennyiseg);

            lb_eredmeny.Items.Add($"A raktár összértéke: {OsszErtek}");

        }

        private void rb_abc_sorrend_CheckedChanged(object sender, EventArgs e)
        {
            lb_eredmeny.Items.Clear();

            var RendezettLista = gyumolcsok.OrderBy(x => x.Nev);

            foreach (var item in RendezettLista)
            {
                lb_eredmeny.Items.Add(item);
            }

        }
    }

    class Gyumolcs
    {
        public string Nev { get; set; }
        public double Mennyiseg { get; set; }
        public int Ar { get; set; }

        public override string ToString()
        {
            return $"{Nev}, Mennyiség: {Mennyiseg}, Egységár: {Ar}";
        }
    }

}
