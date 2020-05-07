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

namespace Szoftver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Word word;
        Paint paint;
        Image image;

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("Szoftver.txt"))
            {
                StreamReader be = new StreamReader("Szoftver.txt");
                while (!be.EndOfStream)
                {
                    string[] sor = be.ReadLine().Split(';');
                    if (sor[0] == "Word") 
                    {
                        word = new Word(sor[0], int.Parse(sor[1]), sor[2], sor[3]);
                    }
                    else if (sor[0] == "Paint") 
                    {
                        paint = new Paint(sor[0], int.Parse(sor[1]), sor[2], sor[3]);
                    }
                }
                be.Close();
            }
            else
            {
                MessageBox.Show("Nincs file.");
            }
        }


        //Információk kiírása
        private void BT_wordinfo_Click(object sender, EventArgs e)
        {
            LB_kiir.Items.Clear();
            LB_kiir.Items.Add(word.Nev);
            LB_kiir.Items.Add(word.Kiadaseve);
            LB_kiir.Items.Add(word.Kiado);
            LB_kiir.Items.Add(word.Info);
            LB_kiir.Visible = true;
        }
        private void BT_paintinfo_Click(object sender, EventArgs e)
        {
            LB_kiir.Items.Clear();
            LB_kiir.Items.Add(paint.Nev);
            LB_kiir.Items.Add(paint.Kiadaseve);
            LB_kiir.Items.Add(paint.Kiado);
            LB_kiir.Items.Add(paint.Info);
            LB_kiir.Visible = true;
        }


        //Visible
        private void BT_word_Click(object sender, EventArgs e)
        {
            BT_word.Visible = false;
            BT_paint.Visible = false;
            BT_wordinfo.Visible = true;
            BT_paintinfo.Visible = false;
            BT_vissza.Visible = true;
            BT_kep.Visible = false;
            pictureBox1.Visible = false;
            GB_szerkesztés.Visible = true;

            //GroupBox eleinek visszaálítása
            TB_wordszoveg.Text = "-szó-";
            R.Value = 255;
            G.Value = 20;
            B.Value = 147;
            Meret.Value = 15;
            LBL_worderedmeny.Text = "";
        }
        private void BT_paint_Click(object sender, EventArgs e)
        {
            BT_word.Visible = false;
            BT_paint.Visible = false;
            BT_wordinfo.Visible = false;
            BT_paintinfo.Visible = true;
            BT_vissza.Visible = true;
            BT_kep.Visible = true;
            pictureBox1.Visible = true;

            //Kép "megvizsgálása"
            if (File.Exists("kep.jpg"))
            {
                image = Image.FromFile("kep.jpg");
                BT_kep.Enabled = true;
            }
            else
            {
                MessageBox.Show("Nincs kep.jpg file.");
                BT_kep.Enabled = false;
            }
        }
        private void BT_vissza_Click(object sender, EventArgs e)
        {
            BT_word.Visible = true;
            BT_paint.Visible = true;
            LB_kiir.Visible = false;
            BT_wordinfo.Visible = false;
            BT_paintinfo.Visible = false;
            BT_vissza.Visible = false;
            BT_kep.Visible = false;
            pictureBox1.Visible = false;
            GB_szerkesztés.Visible = false;

            LB_kiir.Items.Clear();
        }
        private void BT_visszaP_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox1.Height = 0;
            pictureBox1.Width = 0;
            BT_paintinfo.Visible = true;
            BT_vissza.Visible = true;
            BT_kep.Visible = true;
            BT_visszaP.Visible = false;
            LB_kiir.Visible = true;
        }


        //Image megjelenítése
        private void BT_kep_Click(object sender, EventArgs e)
        {
            BT_paintinfo.Visible = false;
            BT_kep.Visible = false;
            LB_kiir.Visible = false;
            BT_vissza.Visible = false;
            BT_visszaP.Visible = true;

            pictureBox1.Width = paint.Width(image);
            pictureBox1.Height = paint.Height(image);
            pictureBox1.Image = paint.Kep(image);
        }


        //Szerkesztés - full automata
        private void TB_wordszoveg_TextChanged(object sender, EventArgs e)
        {
            if(TB_wordszoveg.Text.Contains(' '))
            {
                TB_wordszoveg.Text = "";
            }

            LBL_worderedmeny.Text = TB_wordszoveg.Text;
            LBL_worderedmeny.ForeColor = Color.FromArgb((int)R.Value, (int)G.Value, (int)B.Value);
            LBL_worderedmeny.Font = new Font("Arial", (int)Meret.Value);
        }
        private void R_ValueChanged(object sender, EventArgs e)
        {
            LBL_worderedmeny.Text = TB_wordszoveg.Text;
            LBL_worderedmeny.ForeColor = Color.FromArgb((int)R.Value, (int)G.Value, (int)B.Value);
            LBL_worderedmeny.Font = new Font("Arial", (int)Meret.Value);
        }
        private void G_ValueChanged(object sender, EventArgs e)
        {
            LBL_worderedmeny.Text = TB_wordszoveg.Text;
            LBL_worderedmeny.ForeColor = Color.FromArgb((int)R.Value, (int)G.Value, (int)B.Value);
            LBL_worderedmeny.Font = new Font("Arial", (int)Meret.Value);
        }
        private void B_ValueChanged(object sender, EventArgs e)
        {
            LBL_worderedmeny.Text = TB_wordszoveg.Text;
            LBL_worderedmeny.ForeColor = Color.FromArgb((int)R.Value, (int)G.Value, (int)B.Value);
            LBL_worderedmeny.Font = new Font("Arial", (int)Meret.Value);
        }
        private void Meret_ValueChanged(object sender, EventArgs e)
        {
            LBL_worderedmeny.Text = TB_wordszoveg.Text;
            LBL_worderedmeny.ForeColor = Color.FromArgb((int)R.Value, (int)G.Value, (int)B.Value);
            LBL_worderedmeny.Font = new Font("Arial", (int)Meret.Value);
        }
    }
}