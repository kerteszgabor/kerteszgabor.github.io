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

namespace Memória_Melinda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Memoria> SRAM = new List<Memoria>();
        List<Memoria> DRAM = new List<Memoria>();
        List<Memoria> PROM = new List<Memoria>();
        List<Memoria> EPROM = new List<Memoria>();

       

        private void button1_Click(object sender, EventArgs e)
        {
            Ismerteto.Items.Clear();
            if (rb_SRAM.Checked)
            {
                StreamReader fbe = new StreamReader("SRAM.txt");
                while (!fbe.EndOfStream)
                {
                    string[] elemek = fbe.ReadLine().Split(';');
                    Memoria memoria = Memoria.Factory(elemek[0], int.Parse(elemek[1]), elemek[2], elemek[3], elemek[4], elemek[5], elemek[6]);
                    SRAM.Add(memoria);
                }
                fbe.Close();

                foreach (Memoria item in SRAM)
                {
                    Ismerteto.Items.Add(item);
                }

        }else if(rb_DRAM.Checked)
            {
                Ismerteto.Items.Clear();
                StreamReader fbe = new StreamReader("DRAM.txt");
                while (!fbe.EndOfStream)
                {
                    string[] elemek = fbe.ReadLine().Split(';');
                    Memoria memoria = Memoria.Factory(elemek[0], int.Parse(elemek[1]), elemek[2], elemek[3], elemek[4], elemek[5], elemek[6]);
                    DRAM.Add(memoria);
                }
                fbe.Close();

                foreach (Memoria item in DRAM)
                {
                    Ismerteto.Items.Add(item);
                }

            }else if(rb_PROM.Checked)
            {
                Ismerteto.Items.Clear();
                StreamReader fbe = new StreamReader("PROM.txt");
                while (!fbe.EndOfStream)
                {
                    string[] elemek = fbe.ReadLine().Split(';');
                    Memoria memoria = Memoria.Factory(elemek[0], int.Parse(elemek[1]), elemek[2], elemek[3], elemek[4], elemek[5], elemek[6]);
                    PROM.Add(memoria);
                }
                fbe.Close();

                foreach (Memoria item in PROM)
                {
                    Ismerteto.Items.Add(item);
                }
            }
            else
            {
                Ismerteto.Items.Clear();
                StreamReader fbe = new StreamReader("EPROM.txt");
                while (!fbe.EndOfStream)
                {
                    string[] elemek = fbe.ReadLine().Split(';');
                    Memoria memoria = Memoria.Factory(elemek[0], int.Parse(elemek[1]), elemek[2], elemek[3], elemek[4], elemek[5], elemek[6]);
                    EPROM.Add(memoria);
                }
                fbe.Close();

                foreach (Memoria item in EPROM)
                {
                    Ismerteto.Items.Add(item);
                }
            }

        }

        private void bt_has_Click(object sender, EventArgs e)
        {
            Label tak1 = new Label();
            Label tak2 = new Label();
            Label kat1 = new Label();
            Label kat2 = new Label();
            Label tor1 = new Label();
            Label tor2 = new Label();
            Label fel1 = new Label();
            Label fel2 = new Label();
            Label seb1 = new Label();
            Label seb2 = new Label();
            Label ar1 = new Label();
            Label ar2 = new Label();

            tak1.Parent = this.p_tak1;
            tak2.Parent = this.p_tak2;
            kat1.Parent = this.p_k1;
            kat2.Parent = this.p_k2;
            tor1.Parent = this.p_t1;
            tor2.Parent = this.p_t2;
            fel1.Parent = this.p_f1;
            fel2.Parent = this.p_f2;
            seb1.Parent = this.p_s1;
            seb2.Parent = this.p_s2;
            ar1.Parent = this.p_a1;
            ar2.Parent = this.p_a2;

            tak1.Text = 64.ToString();
            tak2.Text = 32.ToString();
            kat1.Text = "olvasás/írás";
            kat2.Text = "olvasás/írás";
            tor1.Text = "elektromos";
            tor2.Text = "elektromos";
            fel1.Text = "igen";
            fel2.Text = "igen";
            seb1.Text = "képes a CPU sebességére";
            seb2.Text = "lassabb, mint a cpu";
            ar1.Text = "olcsó";
            ar2.Text = "olcsó";

            tak1.Location = new Point(20);
            tak2.Location = new Point(40);
            kat1.Location = new Point(20);
            kat2.Location = new Point(40);
            tor1.Location = new Point(20);
            tor2.Location = new Point(40);
            fel1.Location = new Point(20);
            fel2.Location = new Point(40);
            seb1.Location = new Point(20);
            seb2.Location = new Point(40);
            ar1.Location = new Point(20);
            ar2.Location = new Point(40);
        }

        private void bt_has2_Click(object sender, EventArgs e)
        {
            Label tak3 = new Label();
            Label tak4 = new Label();
            Label kat3 = new Label();
            Label kat4 = new Label();
            Label tor3 = new Label();
            Label tor4 = new Label();
            Label fel3 = new Label();
            Label fel4 = new Label();
            Label seb3 = new Label();
            Label seb4 = new Label();
            Label ar3 = new Label();
            Label ar4 = new Label();

            tak3.Parent = this.p_tak3;
            tak4.Parent = this.p_tak4;
            kat3.Parent = this.p_k3;
            kat4.Parent = this.p_k4;
            tor3.Parent = this.p_t3;
            tor4.Parent = this.p_t4;
            fel3.Parent = this.p_f3;
            fel4.Parent = this.p_f4;
            seb3.Parent = this.p_s3;
            seb4.Parent = this.p_s4;
            ar3.Parent = this.p_a3;
            ar4.Parent = this.p_a4;

            tak3.Text = 64.ToString();
            tak4.Text = 16.ToString();
            kat3.Text = "csak olvasható";
            kat4.Text = "főleg olvasás";
            tor3.Text = "nem lehet";
            tor4.Text = "UV-fény";
            fel3.Text = "nem";
            fel4.Text = "nem";
            seb3.Text = "gyors";
            seb4.Text = "gyors";
            ar3.Text = "olcsó";
            ar4.Text = "drága";

            tak3.Location = new Point(20);
            tak4.Location = new Point(40);
            kat3.Location = new Point(20);
            kat4.Location = new Point(40);
            tor3.Location = new Point(20);
            tor4.Location = new Point(40);
            fel3.Location = new Point(20);
            fel4.Location = new Point(40);
            seb3.Location = new Point(20);
            seb4.Location = new Point(40);
            ar3.Location = new Point(20);
            ar4.Location = new Point(40);
        }
    }
        
    }
