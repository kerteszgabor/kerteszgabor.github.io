using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szabó_Richárd_Projekt
{
    public partial class Form1 : Form
    {

        List<Weapons> fegyok = new List<Weapons>();

        int a = 0;
        int b = 0;
        public Form1()
        {
            InitializeComponent();
            Classic Classic = new Classic();
            Frenzy Frenzy = new Frenzy();
            Ghost Ghost = new Ghost();
            Sheriff Sheriff = new Sheriff();
            Stinger Stinger = new Stinger();
            Spectre Spectre = new Spectre();
            Ares Ares = new Ares();
            Odin Odin = new Odin();
            Bulldog Bulldog = new Bulldog();
            Guardian Guardian = new Guardian();
            Phantom Phantom = new Phantom();
            Vandal Vandal = new Vandal();
            Marshal Marshal = new Marshal();
            Operator Operator = new Operator();

            fegyok.Add(Classic);
            fegyok.Add(Frenzy);
            fegyok.Add(Ghost);
            fegyok.Add(Sheriff);
            fegyok.Add(Stinger);
            fegyok.Add(Spectre);
            fegyok.Add(Ares);
            fegyok.Add(Odin);
            fegyok.Add(Bulldog);
            fegyok.Add(Guardian);
            fegyok.Add(Phantom);
            fegyok.Add(Vandal);
            fegyok.Add(Marshal);
            fegyok.Add(Operator);
        }
        private void bt_indit_Click(object sender, EventArgs e)
        {
            if (a < 1)
            {            
                foreach (var fegyo in fegyok)
                {
                    lb_fegyverlista.Items.Add(fegyo.ToString());
                }
                a++;
            }
            else MessageBox.Show("Már meg vannak jelenítve a fegyverek.");

            if (tb_tavolsag.Text == "")
            {
                MessageBox.Show("Adj meg egy távolságot!");
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {        
            var kivalasztottIndex = lb_fegyverlista.SelectedIndex;
            pb_fegyver.ImageLocation = fegyok[kivalasztottIndex].KepPath;
            pb_fegyver.SizeMode = PictureBoxSizeMode.StretchImage;

            try
            {
                fegyok[kivalasztottIndex].Tavolsag = int.Parse(tb_tavolsag.Text);
                b++;
            }
            catch(FormatException)
            {
                MessageBox.Show("Számot kérek a távolsághoz. :)");
            }     

        }

        private void bt_fejsebzes_Click(object sender, EventArgs e)
        {
            if (b > 0)
            {
                var kivalasztottIndex = lb_fegyverlista.SelectedIndex;
                MessageBox.Show(fegyok[kivalasztottIndex].Fejsebzes.ToString() + " sebzést okoz fejre a fegyver");
            }
            else MessageBox.Show("Előbb jelenítsd meg a fegyvereket/adj meg távolságot/válassz ki egy fegyvert!");
        }

        private void bt_testsebzes_Click(object sender, EventArgs e)
        {
            if (b > 0) 
            {
                var kivalasztottIndex = lb_fegyverlista.SelectedIndex;
                MessageBox.Show(fegyok[kivalasztottIndex].Testsebzes.ToString() + " sebzést okoz testre a fegyver.");
            }
            else MessageBox.Show("Előbb jelenítsd meg a fegyvereket/adj meg távolságot/válassz ki egy fegyvert!");
        }

        private void bt_labsebzes_Click(object sender, EventArgs e)
        {
            if (b > 0)
            {
                var kivalasztottIndex = lb_fegyverlista.SelectedIndex;
                MessageBox.Show(fegyok[kivalasztottIndex].Labsebzes.ToString() + " sebzést okoz lábra a fegyver.");
            }
            else MessageBox.Show("Előbb jelenítsd meg a fegyvereket/adj meg távolságot/válassz ki egy fegyvert!");
        }

        private void bt_fegyverar_Click(object sender, EventArgs e)
        {
            if (b > 0)
            {
                var kivalasztottIndex = lb_fegyverlista.SelectedIndex;
                MessageBox.Show(fegyok[kivalasztottIndex].Creds.ToString() + " creditbe kerül a fegyver.");
            }
            else MessageBox.Show("Előbb jelenítsd meg a fegyvereket/adj meg távolságot/válassz ki egy fegyvert!");
        }

        private void bt_fegyverfirerate_Click(object sender, EventArgs e)
        {
            if (b > 0)
            {
                var kivalasztottIndex = lb_fegyverlista.SelectedIndex;
                MessageBox.Show(fegyok[kivalasztottIndex].Firerate.ToString() + " a firerateje a fegyvernek.");
            }
            else MessageBox.Show("Előbb jelenítsd meg a fegyvereket/adj meg távolságot/válassz ki egy fegyvert!");
        }

        private void bt_fegyvertarmeret_Click(object sender, EventArgs e)
        {
            if (b > 0)
            {
                var kivalasztottIndex = lb_fegyverlista.SelectedIndex;
                MessageBox.Show(fegyok[kivalasztottIndex].Tarmeret.ToString() + " a tármérete a fegyvernek.");
            }
            else MessageBox.Show("Előbb jelenítsd meg a fegyvereket/adj meg távolságot/válassz ki egy fegyvert!");
        }
    }
}
