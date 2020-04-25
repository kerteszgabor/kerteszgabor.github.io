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

                foreach (Memoria item in PROM)
                {
                    Ismerteto.Items.Add(item);
                }
            }

        }

        private void bt_ramf_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}