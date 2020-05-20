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

namespace Raktar_gyumolcs
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        List<Raktar> raktar = new List<Raktar>();

        void Beolvas(string file)
        {
            if (File.Exists(file))
            {
                StreamReader fbe = File.OpenText(file);
                Raktar seged = null;
                while (!fbe.EndOfStream)
                {

                    seged = new Raktar();
                    string[] darab = fbe.ReadLine().Split(';');
                    seged.Gynev = darab[0];
                    seged.Mennyiseg = Convert.ToDouble(darab[1]);
                    seged.Egysegar = int.Parse(darab[2]);
                    raktar.Add(seged);

                }
            }
        }
            private void bt_beolvas_Click(object sender, EventArgs e)
        {
            Beolvas("raktar.txt");
         foreach (var item in raktar)
            {
                lb_raktarom.Items.Add(item);
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            lb_eredmeny.Items.Clear();
            var k = raktar.Where(x => x.Gynev == "k").FirstOrDefault();
            lb_eredmeny.Items.Add($"K-val kezdödö gyümik összesen: {k}");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lb_eredmeny.Items.Clear();
            int legdragabbgy = raktar.Max(x => x.Egysegar);
            lb_eredmeny.Items.Add($"Legdrágább gyümi egységára: {legdragabbgy}");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            lb_eredmeny.Items.Clear();
            int legdragabbgy = raktar.Max(x => x.Egysegar);
            Raktar legdragabbgyn = raktar.Where(x => x.Egysegar == legdragabbgy).FirstOrDefault();
            lb_eredmeny.Items.Add($"Legdrágabb gyümi: {legdragabbgyn}");
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            lb_eredmeny.Items.Clear();
            //lamdbával nem megy
            double ossz = 0;
           foreach( var m in raktar)
            {
                ossz = +m.Mennyiseg * m.Egysegar;
            }
            lb_eredmeny.Items.Add($" Raktár értéke:{ossz} ft");
            lb_eredmeny.Items.Add(raktar.Sum(x => x.Egysegar * x.Mennyiseg));
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            lb_eredmeny.Items.Clear();
            var ABC = raktar.OrderByDescending(x => x.Gynev);
            foreach (var m in ABC)
            {
                lb_eredmeny.Items.Add(m);
            }
        }
    }
}
                  
        
          
          
      
