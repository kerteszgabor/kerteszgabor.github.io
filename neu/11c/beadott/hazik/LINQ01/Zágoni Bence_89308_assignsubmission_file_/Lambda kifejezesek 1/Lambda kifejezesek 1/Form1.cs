using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lambda_kifejezesek_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int eredmeny;
        double atlag;
        Random r = new Random();
       
        int[] szamok = {1, 4, 9, 15, 41, 68, 33 };

        private void bt1_Click(object sender, EventArgs e)
        {

            lb0.Items.Clear();
            
            foreach (int item in szamok)
            {
                lb0.Items.Add(item);
            }

            lb0.Visible = true;
            gp0.Visible = true;
            lb1.Visible = true;
            label1.Visible = true;            
        }


        private void radioButton1_Click(object sender, EventArgs e)
        {
            lb1.Items.Clear();
            try
            {
                eredmeny = Array.Find(szamok, x => x > 5);
                lb1.Items.Add(eredmeny);
            }
            catch
            {
                lb1.Items.Add("Nincs ilyen elem");
            }
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            lb1.Items.Clear();
            try
            {
                eredmeny = Array.Find(szamok, x => x > 50);
                lb1.Items.Add(eredmeny);
            }
            catch
            {
                lb1.Items.Add("Nincs ilyen elem");
            }
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            lb1.Items.Clear();
            try
            {
                Array.ForEach(szamok.Where(x => x > 5).ToArray(), x => lb1.Items.Add(x));
            }
            catch
            {
                lb1.Items.Add("Nincs ilyen szám");
            }
        }
       
        private void radioButton4_Click(object sender, EventArgs e)
        {
            lb1.Items.Clear();
            try
            {
                Array.ForEach(szamok.Where(x => x > 50).ToArray(), x => lb1.Items.Add(x));

            }
            catch
            {
                lb1.Items.Add("Nincs ilyen szám");
            }
        }

        private void radioButton5_Click(object sender, EventArgs e)
        {
            lb1.Items.Clear();

            try
            {
                Array.ForEach(szamok.Where(x => (x >= 2 && x <= 6)).ToArray(), x => lb1.Items.Add(x));
            }
            catch
            {
                lb1.Items.Add("Nincs ilyen szám");
            }
        }

        private void radioButton6_Click(object sender, EventArgs e)
        {
            lb1.Items.Clear();
            try
            {
                eredmeny = szamok.First(x => (x % 2 == 0));
                lb1.Items.Add(eredmeny);
            }
            catch
            {
                lb1.Items.Add("Nincs páros szám");
            }
        }

        private void radioButton7_Click(object sender, EventArgs e)
        {
            lb1.Items.Clear();
            try
            {
                eredmeny = szamok.Last(x => (x % 2 == 0));
                lb1.Items.Add(eredmeny);     
            }
            catch
            {
                lb1.Items.Add("Nincs páros szám");
            }
        }
        

        private void radioButton8_Click(object sender, EventArgs e)
        {
            lb1.Items.Clear();
            try
            {
                Array.ForEach(szamok.Where(x => (x % 2 == 0)).ToArray(), x => lb1.Items.Add(x));
            }
            catch
            {
                lb1.Items.Add("Nincs megadva szám");
            }
        }

        private void radioButton9_Click(object sender, EventArgs e)
        {
            lb1.Items.Clear();
            try
            {
                Array.ForEach(szamok, x => lb1.Items.Add(x * x));
            }
            catch
            {
                lb1.Items.Add("Nincs megadva szám");
            }
        }

        private void radioButton10_Click(object sender, EventArgs e)
        {
            lb1.Items.Clear();
            try
            {
                Array.ForEach(szamok.Select(x => x * x * x).ToArray(), x => lb1.Items.Add(x));
            }
            catch
            {
                lb1.Items.Add("Nincs megadva szám");
            }
        }

        private void radioButton11_Click(object sender, EventArgs e)
        {
            lb1.Items.Clear();
            try
            {
                eredmeny = szamok.Sum();
                lb1.Items.Add(eredmeny);
            }
            catch
            {
                lb1.Items.Add("Nincs megadva szám");
            }
        }

        private void radioButton12_Click(object sender, EventArgs e)
        {
            lb1.Items.Clear();
            try
            {
                eredmeny = szamok.Sum(x => x * x);
                lb1.Items.Add(eredmeny);
            }
            catch
            {
                lb1.Items.Add("Nincs megadva szám");
            }
        }

        private void radioButton13_Click(object sender, EventArgs e)
        {
            lb1.Items.Clear();
            try
            {
                eredmeny = szamok.Where(x => (x % 2 == 0)).Sum();
                lb1.Items.Add(eredmeny);
            }
            catch
            {
                lb1.Items.Add("Nincs páros szám");
            }
        }

        private void radioButton14_Click(object sender, EventArgs e)
        {
            lb1.Items.Clear();
            try
            {
                atlag = szamok.Average();
                lb1.Items.Add(atlag);
            }
            catch
            {
                lb1.Items.Add("Nincs megadva szám");
            }
        }

        private void radioButton15_Click(object sender, EventArgs e)
        {
            lb1.Items.Clear();
            try
            {
                atlag = szamok.Where(x => (x % 2 == 0)).Average();
                lb1.Items.Add(atlag);
            }
            catch
            {
                lb1.Items.Add("Nincs páros szám");
            }
        }

        private void radioButton16_Click(object sender, EventArgs e)
        {
            lb1.Items.Clear();
            try
            {
                atlag = szamok.Where(x => (x % 2 == 0)).Count();
                lb1.Items.Add(atlag);
            }
            catch
            {
                lb1.Items.Add("Nincs páros szám");
            }
        }

        private void radioButton17_Click(object sender, EventArgs e)
        {
            lb1.Items.Clear();
            try
            {
                eredmeny = szamok.Max();
                lb1.Items.Add(eredmeny);
            }
            catch
            {
                lb1.Items.Add("Nincs megadva szám");
            }
        }

        private void radioButton18_Click(object sender, EventArgs e)
        {
            lb1.Items.Clear();
            try
            {
                eredmeny = szamok.Max();
                int hely = Array.IndexOf(szamok, eredmeny);
                lb1.Items.Add(hely);
            }
            catch
            {
                lb1.Items.Add("Nincs megadva szám");
            }
        }

        private void radioButton19_Click(object sender, EventArgs e)
        {
            lb1.Items.Clear();
            try
            {
                eredmeny = szamok.Where(x => (x % 2 == 0)).Max();
                lb1.Items.Add(eredmeny);
            }
            catch
            {
                lb1.Items.Add("Nincsen páros szám");
            }
        }

        private void radioButton20_Click(object sender, EventArgs e)
        {
            lb1.Items.Clear();
            try
            {
                eredmeny = szamok.Where(x => (x < 0)).Max();
                lb1.Items.Add(eredmeny);
            }
            catch
            {
                lb1.Items.Add("Nincs negatív szám");
            }
        }
    }
}
