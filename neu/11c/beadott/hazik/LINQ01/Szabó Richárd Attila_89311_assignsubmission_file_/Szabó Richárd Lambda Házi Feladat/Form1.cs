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

namespace Szabó_Richárd_Lambda_Házi_Feladat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        List<Raktar> Lista = new List<Raktar>();
        private void bt_indit_Click(object sender, EventArgs e)
        {
            if (File.Exists("raktar.txt"))
            {
                StreamReader fbe = new StreamReader("raktar.txt");
                while (!fbe.EndOfStream)
                {
                    string sor = fbe.ReadLine();
                    string[] darab = sor.Split(';');
                    Raktar raktar = new Raktar(darab[0], Convert.ToDouble(darab[1]), int.Parse(darab[2]));
                    Lista.Add(raktar);
                    lb_lista.Items.Add(raktar);
                }
            }
        }

        //K betűvel kezdődő.
        private void bt_k_Click(object sender, EventArgs e)
        {
            var kbetuvelkezdodo = Lista.Where(x => x.gyumolcsnev.StartsWith("k")).Count();
            lb_k.Text = kbetuvelkezdodo.ToString();
        }

        //Legdrágább gyümölcs ára.
        private void bt_maxar_Click(object sender, EventArgs e)
        {
            var maxar = Lista.Max(x => x.egysegar);
            var legdragabbgyumolcs = Lista.Find(x => x.egysegar == maxar);
            lb_maxar.Text = legdragabbgyumolcs.ToString();
        }

        //Legdrágább gyümölcs neve.
        private void bt_maxarnev_Click(object sender, EventArgs e)
        {
            var maxar = Lista.Max(x => x.egysegar);
            var legdragabbgyumolcs = Lista.Find(x => x.egysegar == maxar);
            lb_maxarnev.Text = legdragabbgyumolcs.gyumolcsnev.ToString();
        }

        //Raktár összértéke.
        private void bt_osszertek_Click(object sender, EventArgs e)
        {
            double osszertek = Lista.Sum(x => x.mennyiseg * x.egysegar);
            lb_osszertek.Text=($"A raktár összértéke: {osszertek}.");
        }

        //ABC sorrend.
        private void bt_abc_Click(object sender, EventArgs e)
        {
            var rendezettlista = Lista.OrderBy(x => x.gyumolcsnev);
            foreach (var item in rendezettlista)
            {
                lb_abc.Items.Add(item.ToString());
            }
        }
    }
}
