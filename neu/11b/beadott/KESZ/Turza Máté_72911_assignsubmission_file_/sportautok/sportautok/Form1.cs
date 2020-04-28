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

namespace sportautok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        Ferrari EFerrari = new Ferrari(6600000, 2002, 1255, 660, 400);
        Bugatti BugattiC = new Bugatti(2600000, 2016, 1996, 1479, 200);
        Lamborghini Lamborev = new Lamborghini(1500000, 2007, 1665, 640, 20);
        Mercedes Mercedesamg = new Mercedes(116000, 2014, 1645, 516, 1000);
        Porsche porsche = new Porsche(295000, 1963, 1120, 370, 90000);


        private void button1_Click(object sender, EventArgs e)
        {
            
           
        }
            


            

        private void Form1_Load(object sender, EventArgs e)
        {

            comb1.Items.Add(EFerrari);
            comb1.Items.Add(BugattiC);
            comb1.Items.Add(Lamborev);
            comb1.Items.Add(porsche);
            comb1.Items.Add(Mercedesamg);


            comb2.Items.Add(EFerrari);
            comb2.Items.Add(BugattiC);
            comb2.Items.Add(Lamborev);
            comb2.Items.Add(porsche);
            comb2.Items.Add(Mercedesamg);


            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comb1.SelectedItem == EFerrari)
            {
                pictureBox1.Image = Image.FromFile("enzoferrari.jpg");
            }
            else if (comb1.SelectedItem == BugattiC)
            {
                pictureBox1.Image = Image.FromFile("bugachi.jpg");
            }
            else if (comb1.SelectedItem == Lamborev)
            {
                pictureBox1.Image = Image.FromFile("lamborev.jpg");
            }
            else if (comb1.SelectedItem == porsche)
            {
                pictureBox1.Image = Image.FromFile("porsche.jpg");
            }
            else
            {
                pictureBox1.Image = Image.FromFile("mercedesamg.jpg");
            }

        }
        
        private void comb2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comb2.SelectedItem == EFerrari)
            {
                pictureBox2.Image = Image.FromFile("enzoferrari.jpg");
            }
            else if (comb2.SelectedItem == BugattiC)
            {
                pictureBox2.Image = Image.FromFile("bugachi.jpg");
            }
            else if (comb2.SelectedItem == Lamborev)
            {
                pictureBox2.Image = Image.FromFile("lamborev.jpg");
            }
            else if (comb2.SelectedItem == porsche)
            {
                pictureBox2.Image = Image.FromFile("porsche.jpg");
            }
            else
            {
                pictureBox2.Image = Image.FromFile("mercedesamg.jpg");
            }
        }

        private void Btn_elt_Click(object sender, EventArgs e)
        {
           
        }

        private void RB_ar_CheckedChanged(object sender, EventArgs e)
        {
            
            
           
        }
    }
}
