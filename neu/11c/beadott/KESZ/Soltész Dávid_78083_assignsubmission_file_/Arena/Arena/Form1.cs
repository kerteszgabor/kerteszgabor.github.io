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

namespace Arena
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Szorny> szornyek = new List<Szorny>();

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader be = new StreamReader("szornyek.txt");
            if (szornyek.Count >= 100)
            {
                while (!be.EndOfStream)
                {

                    string[] el = be.ReadLine().Split(':');
                    szornyek.Add(Szorny.Factory(el[0], el[1], int.Parse(el[2])));

                }

                foreach (Szorny item in szornyek)
                {
                    listBox1.Items.Add(item.ToString());
                }
            }
        }      


        private void button2_Click(object sender, EventArgs e)
        {
            int eredmeny = 0;
            Random b = new Random();
            if (szornyek.Count >= 2)
            {
                Szorny egyik = szornyek[b.Next(szornyek.Count)];
                Szorny masik;
                do
                {
                    masik = szornyek[b.Next(szornyek.Count)];
                }
                while (egyik.Nev == masik.Nev);
                {
                     eredmeny = egyik.Megkuzd(masik);
                }
                listBox2.Items.Clear();
                if (eredmeny > 0)
                {
                    listBox2.Items.Add(egyik);
                  //  egyik.Tapasztalat += 3;
                }
                else
                {
                    listBox2.Items.Add(masik);
                  //  masik.Tapasztalat += 3;
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            /* Random d = new Random();


             for ( int i = 0; i < szornyek.Count; i++)
             {
                 if (i == d.Next(0,szornyek.Count + 1))
                 {

                 }
             }


         */
        }
    }
}
