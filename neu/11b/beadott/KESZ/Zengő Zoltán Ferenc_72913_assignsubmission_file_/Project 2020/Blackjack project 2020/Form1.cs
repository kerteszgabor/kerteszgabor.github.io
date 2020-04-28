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

namespace Blackjack_project_2020
{
    public partial class Blackjack : Form
    {
        List<Felhasznalo> User = new List<Felhasznalo>();
        //List<Guest> Guest = new List<Guest>();
        string username;
        int zseton;
        int egyenleg;       
        int egytizen = 0;
        int osztoert = 0;
        int userert = 0;
        bool felez = false;
        int[] osztás = new int[4];
        int[] szinek = new int[4];
        int jatekban = 0;
        int felezert;
        int elozo;
        Random rnd = new Random();
        int lapertek;
        int szin;
        int kod;
        bool uto = false;
        bool veszítt = false;
        bool banksok = false;
        public Blackjack()
        {
            InitializeComponent();
            beolv();
            kartyaurit();
            betolt();
        }

        public void beolv()
        {
            //User.Add(new Felhasznalo("admin", "admin", 20000, "0000-0000-0000-0000", "00/00", 000, 100000, "admin@gmail.com"));
            string[] fel_sorok = File.ReadAllLines("Felhasználó.txt");
            foreach (var item in fel_sorok)
            {
                User.Add(new Member(item.Split(';')[0], item.Split(';')[1], int.Parse(item.Split(';')[2]), item.Split(';')[3], item.Split(';')[4], int.Parse(item.Split(';')[5]), int.Parse(item.Split(';')[6]), item.Split(';')[7]));
            }
        }
        private void cb_hozzaad_CheckedChanged(object sender, EventArgs e)
        {
            if (pnl_bankkartya.Visible == true)
            {
                pnl_bankkartya.Location = new Point(521, 12);
                pnl_bankkartya.Visible = false;
                btn_regisztracio.Enabled = true;
            }
            else if (pnl_bankkartya.Visible == false)
            {
                pnl_bankkartya.Location = new Point(962, 254);
                pnl_bankkartya.Visible = true;
                btn_regisztracio.Enabled = false;
            }
        }
        //Felesleg
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //Felesleg
        private void label8_Click(object sender, EventArgs e)
        {

        }
        //Felesleg
        private void label46_Click(object sender, EventArgs e)
        {

        }
        //Felesleg
        private void label34_Click(object sender, EventArgs e)
        {

        }
        //Felesleg
        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
        //Belépés Panel
        private void btn_belepes_Click(object sender, EventArgs e)
        {
            //Beléptetés
            string felhasz = tb_befelhasz.Text;
            string jelszo = tb_bejelszo.Text;
            bool siker = false;

            foreach (var item in User)
            {
                if (tb_befelhasz.Text.Length > 0 && tb_bejelszo.Text.Length > 0)
                {
                    if (item.Felhasznalonev == felhasz && item.Jelszo == jelszo)
                    {
                        pnl_jatek.BringToFront();
                        pnl_jatek.Location = new Point(0, 0);
                        pnl_jatek.Visible = true;
                        pnl_belepes.Visible = false;
                        lbl_zsetonod.Text = zseton.ToString();
                        siker = true;
                        pnl_belepes.Location = new Point(12, 12);
                        btn_ismetles.Enabled = false;
                        username = item.Felhasznalonev;
                        zseton = item.Zseton;
                        egyenleg = item.Egyenleg;
                    }
                }
            }
            if (siker == false)
            {
                MessageBox.Show("A felhasználónév vagy a jelszó nem egyezik");
                tb_befelhasz.BackColor = Color.Red;
                tb_bejelszo.BackColor = Color.Red;
            }
        }

        private void tb_befelhasz_Click(object sender, EventArgs e)
        {
            //giccs
            tb_befelhasz.BackColor = Color.White;
            tb_bejelszo.BackColor = Color.White;
        }

        private void tb_bejelszo_Click(object sender, EventArgs e)
        {
            //giccs
            tb_befelhasz.BackColor = Color.White;
            tb_bejelszo.BackColor = Color.White;
        }

        private void btn_guest_Click(object sender, EventArgs e)
        {
            //Guest generálás félig kész
            Random r = new Random();
            int guestszam = r.Next(675342, 9823627);
            username = "guest" + guestszam;
            zseton = 10000;
            egyenleg = 0;
        }

        private void btn_elfelejt_Click(object sender, EventArgs e)
        {
            //Kódkérés megjelenítés
            pnl_belepes.Visible = false;
            pnl_belepes.Location = new Point(12, 12);
            pnl_emailkod.Location = new Point(653, 416);
            pnl_emailkod.Visible = true;
        }

        private void btn_regisztracio_Click(object sender, EventArgs e)
        {
            //Regisztráció megjelenítés
            pnl_regisztracio.Location = new Point(672, 254);
            pnl_regisztracio.Visible = true;
            pnl_belepes.Visible = false;
            pnl_belepes.Location = new Point(12, 12);
        }
        //Regisztráció panel
        private void btn_regisztralok_Click(object sender, EventArgs e)
        {
            if (tb_refelhasz.Text.Length > 0 && tb_rejelszo.Text.Length > 0 && tb_rejelszoujra.Text.Length > 0 && tb_reemail.Text.Length > 0 && cb_elfogad.Checked == true && cb_nemrob.Checked == true)
            {
                bool van = false;
                string email = tb_reemail.Text;


                foreach (var item in User)
                {
                    if (username == item.Felhasznalonev && email == item.Email)
                    {
                        van = true;
                    }
                    else
                    {
                        van = false;
                    }
                }
                if (van == false)
                {
                    if (email.Contains(" ") == false && email.Contains("@"))
                    {
                        int kukachely = (email.IndexOf("@") + 1);
                        int emailhossz = tb_reemail.Text.Length;
                        int db = emailhossz - kukachely;
                        string domaindot = email.Substring(kukachely, db);
                        if (domaindot.Contains(".") && domaindot.Length >= 6)
                        {
                            int domainhossz = (domaindot.IndexOf(".") + 1);
                            int com = domaindot.Length - domainhossz;
                            int domain = domaindot.Length - com;
                            if (com >= 2 && domain >= 3)
                            {
                                if (tb_rejelszo.Text == tb_rejelszoujra.Text)
                                {
                                    User.Add(new Felhasznalo(tb_refelhasz.Text, tb_rejelszo.Text, 25000, tb_kartyaszam.Text, tb_lejarat.Text, int.Parse(tb_cvc.Text), 0, tb_reemail.Text));
                                    StreamWriter stream = new StreamWriter("Felhasználó.txt", true);
                                    foreach (var item in User)
                                    {
                                        if (tb_refelhasz.Text == item.Felhasznalonev)
                                        {
                                            stream.WriteLine($"{item.Felhasznalonev};{item.Jelszo};{item.Zseton};{item.Kartyaszam};{item.Lejarat};{item.Cvc};{item.Egyenleg};{item.Email}");
                                        }
                                    }
                                    stream.Close();
                                    //bejelentkezés
                                    pnl_bankkartya.Visible = false;
                                    pnl_belepes.Location = new Point(699, 343);
                                    pnl_regisztracio.Visible = false;
                                    pnl_belepes.Visible = true;
                                    pnl_regisztracio.Location = new Point(239, 12);
                                    tb_reemail.Text = "";
                                    tb_refelhasz.Text = "";
                                    tb_rejelszo.Text = "";
                                    tb_rejelszoujra.Text = "";
                                    tb_cvc.Text = "000";
                                    tb_lejarat.Text = "00/00";
                                    tb_kartyaszam.Text = "0000-0000-0000-0000";
                                    cb_elfogad.Checked = false;
                                    cb_hozzaad.Checked = false;
                                    cb_nemrob.Checked = false;
                                }
                                else
                                {
                                    MessageBox.Show("A két jelszó nem egyezik!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Az email formátum nem megfelelő");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Az email formátum nem megfelelő ne tartalmazzon\n szóközt vagy tartalmazzon @-ot");
                    }
                }
                else
                {
                    MessageBox.Show("A felhasználó vagy email cím már létezik");
                }
            }
            else
            {
                MessageBox.Show("Tölts ki minden mezőt vagy pipáld ki a szükséges állításokat");
            }
        }

        private void btn_revissza_Click(object sender, EventArgs e)
        {
            pnl_belepes.Location = new Point(699, 343);
            pnl_belepes.Visible = true;
            pnl_regisztracio.Visible = false;
            pnl_regisztracio.Location = new Point(239, 12);
        }

        private void btn_kovissza_Click(object sender, EventArgs e)
        {
            pnl_belepes.Visible = true;
            pnl_belepes.Location = new Point(699, 343);
            pnl_emailkod.Location = new Point(521, 303);
            pnl_emailkod.Visible = false;
        }

        private void btn_emailker_Click(object sender, EventArgs e)
        {
            bool van = false;

            foreach (var item in User)
            {
                if (tb_emailbe.Text == item.Email || tb_emailbe.Text == item.Felhasznalonev)
                {
                    van = true;
                }
            }

            if (van == true)
            {
                pnl_emailkod.Visible = false;
                pnl_emailkod.Location = new Point(521, 303);
                pnl_jelszocsere.Location = new Point(714, 407);
                pnl_kapkod.Location = new Point(714, 319);
                pnl_kapkod.Visible = true;
                pnl_jelszocsere.Visible = true;
                kod = rnd.Next(1819821, 9599555);
                lbl_kapkod.Text = kod.ToString();
            }
            else
            {
                MessageBox.Show("A felhasználó nem létezik");
            }
        }

        public void lapkeresert()
        {
                    
            if (lapertek >= 10)
            {
                userert += 10;
                if (userert > 21)
                {
                    veszítt = true;
                }
            }
            else if (lapertek > 1)
            {
                userert += lapertek;
                if (userert > 21)
                {
                    veszítt = true;
                }
            }
            else
            {
                if (userert + 11 > 21)
                {
                    userert += 1;
                    if (userert > 21)
                    {
                        veszítt = true;
                    }
                }
                else
                {
                    btn_1.Visible = true;
                    btn_1.Text = (userert + 1).ToString();
                    btn_11.Visible = true;
                    btn_11.Text = (userert + 11).ToString();
                    lbl_szoveg19.Visible = true;
                }
            }            
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (felez == false)
            {
                lbl_playerert.Text = btn_1.Text;
                userert = int.Parse(btn_1.Text);
                btn_1.Visible = false;
                btn_11.Visible = false;
                lbl_szoveg19.Visible = false;
                btn_ismetles.Enabled = true;
                btn_max.Enabled = true;
                btn_egyeni.Enabled = true;
            }
            else
            {

            }
        }

        private void btn_11_Click(object sender, EventArgs e)
        {
            if (felez == false)
            {
                lbl_playerert.Text = btn_11.Text;
                userert = int.Parse(btn_11.Text);
                btn_1.Visible = false;
                btn_11.Visible = false;
                lbl_szoveg19.Visible = false;
                btn_ismetles.Enabled = true;
                btn_max.Enabled = true;
                btn_egyeni.Enabled = true;
            }
            else
            {

            }
        }

        private void sb_egyeni_Scroll(object sender, ScrollEventArgs e)
        {
            btn_betesz.Visible = true;
            sb_egyeni.Maximum = zseton;
            int kiír = ((sb_egyeni.Value - (zseton + 25)) * (-1)) / 2;
            btn_betesz.Text = kiír.ToString();
        }

        private void btn_betesz_Click(object sender, EventArgs e)
        {
            int tet = int.Parse(btn_betesz.Text);
            jatekban = tet;
            zseton = zseton - tet;
            lbl_zsetonod.Text = zseton.ToString();
            sb_egyeni.Visible = false;
            btn_betesz.Visible = false;
            Osztás();
            elozo = tet;
            btn_ismetles.Enabled = true;
            btn_min.Enabled = false;
            lbl_playerert.Text = userert.ToString();
            if (btn_1.Visible == true)
            {
                btn_min.Enabled = false;
                btn_ismetles.Enabled = false;
                btn_max.Enabled = false;
                btn_egyeni.Enabled = false;
            }
        }

        public void Osztás()
        {
            Random r = new Random();
            gombok();
            for (int i = 0; i < 4; i++)
            {
                osztás[i] = r.Next(1, 14);
                szinek[i] = r.Next(1, 5);

                if (i == 0)
                {
                    if (osztás[i] > 10)
                    {
                        switch (osztás[i])
                        {
                            case 11:
                                lbl_lapert33.Text = "J";
                                lbl_lapert34.Text = "J";
                                switch (szinek[i])
                                {
                                    case 1:
                                        pb_lapszin33.Image = Image.FromFile("pikk.jpg");
                                        pb_lapszin34.Image = Image.FromFile("pikk.jpg");
                                        break;
                                    case 2:
                                        pb_lapszin33.Image = Image.FromFile("kor.jpg");
                                        pb_lapszin34.Image = Image.FromFile("kor.jpg");
                                        break;
                                    case 3:
                                        pb_lapszin33.Image = Image.FromFile("treff.jpg");
                                        pb_lapszin34.Image = Image.FromFile("treff.jpg");
                                        break;
                                    case 4:
                                        pb_lapszin33.Image = Image.FromFile("karo.jpg");
                                        pb_lapszin34.Image = Image.FromFile("karo.jpg");
                                        break;
                                }
                                break;
                            case 12:
                                lbl_lapert33.Text = "Q";
                                lbl_lapert34.Text = "Q";
                                switch (szinek[i])
                                {
                                    case 1:
                                        pb_lapszin33.Image = Image.FromFile("pikk.jpg");
                                        pb_lapszin34.Image = Image.FromFile("pikk.jpg");
                                        break;
                                    case 2:
                                        pb_lapszin33.Image = Image.FromFile("kor.jpg");
                                        pb_lapszin34.Image = Image.FromFile("kor.jpg");
                                        break;
                                    case 3:
                                        pb_lapszin33.Image = Image.FromFile("treff.jpg");
                                        pb_lapszin34.Image = Image.FromFile("treff.jpg");
                                        break;
                                    case 4:
                                        pb_lapszin33.Image = Image.FromFile("karo.jpg");
                                        pb_lapszin34.Image = Image.FromFile("karo.jpg");
                                        break;
                                }
                                break;
                            case 13:
                                lbl_lapert33.Text = "K";
                                lbl_lapert34.Text = "K";
                                switch (szinek[i])
                                {
                                    case 1:
                                        pb_lapszin33.Image = Image.FromFile("pikk.jpg");
                                        pb_lapszin34.Image = Image.FromFile("pikk.jpg");
                                        break;
                                    case 2:
                                        pb_lapszin33.Image = Image.FromFile("kor.jpg");
                                        pb_lapszin34.Image = Image.FromFile("kor.jpg");
                                        break;
                                    case 3:
                                        pb_lapszin33.Image = Image.FromFile("treff.jpg");
                                        pb_lapszin34.Image = Image.FromFile("treff.jpg");
                                        break;
                                    case 4:
                                        pb_lapszin33.Image = Image.FromFile("karo.jpg");
                                        pb_lapszin34.Image = Image.FromFile("karo.jpg");
                                        break;
                                }
                                break;
                        }
                        osztás[i] = 10;
                        pnl_lap17.BorderStyle = BorderStyle.FixedSingle;
                        pnl_lap17.BackColor = Color.White;
                    }
                    else if (osztás[i] > 1)
                    {
                        lbl_lapert33.Text = osztás[i].ToString();
                        lbl_lapert34.Text = osztás[i].ToString();
                        pnl_lap17.BorderStyle = BorderStyle.FixedSingle;
                        pnl_lap17.BackColor = Color.White;
                        switch (szinek[i])
                        {
                            case 1:
                                pb_lapszin33.Image = Image.FromFile("pikk.jpg");
                                pb_lapszin34.Image = Image.FromFile("pikk.jpg");
                                break;
                            case 2:
                                pb_lapszin33.Image = Image.FromFile("kor.jpg");
                                pb_lapszin34.Image = Image.FromFile("kor.jpg");
                                break;
                            case 3:
                                pb_lapszin33.Image = Image.FromFile("treff.jpg");
                                pb_lapszin34.Image = Image.FromFile("treff.jpg");
                                break;
                            case 4:
                                pb_lapszin33.Image = Image.FromFile("karo.jpg");
                                pb_lapszin34.Image = Image.FromFile("karo.jpg");
                                break;
                        }
                    }
                    else
                    {
                        lbl_lapert33.Text = "A";
                        lbl_lapert34.Text = "A";
                        pnl_lap17.BorderStyle = BorderStyle.FixedSingle;
                        pnl_lap17.BackColor = Color.White;
                        switch (szinek[i])
                        {
                            case 1:
                                pb_lapszin33.Image = Image.FromFile("pikk.jpg");
                                pb_lapszin34.Image = Image.FromFile("pikk.jpg");
                                break;
                            case 2:
                                pb_lapszin33.Image = Image.FromFile("kor.jpg");
                                pb_lapszin34.Image = Image.FromFile("kor.jpg");
                                break;
                            case 3:
                                pb_lapszin33.Image = Image.FromFile("treff.jpg");
                                pb_lapszin34.Image = Image.FromFile("treff.jpg");
                                break;
                            case 4:
                                pb_lapszin33.Image = Image.FromFile("karo.jpg");
                                pb_lapszin34.Image = Image.FromFile("karo.jpg");
                                break;
                        }
                    }
                }
                else if (i == 1)
                {
                    if (osztás[i] > 10)
                    {
                        switch (osztás[i])
                        {
                            case 11:
                                lbl_lapert1.Text = "J";
                                lbl_lapert2.Text = "J";
                                switch (szinek[i])
                                {
                                    case 1:
                                        pb_lapszin1.Image = Image.FromFile("pikk.jpg");
                                        pb_lapszin2.Image = Image.FromFile("pikk.jpg");
                                        break;
                                    case 2:
                                        pb_lapszin1.Image = Image.FromFile("kor.jpg");
                                        pb_lapszin2.Image = Image.FromFile("kor.jpg");
                                        break;
                                    case 3:
                                        pb_lapszin1.Image = Image.FromFile("treff.jpg");
                                        pb_lapszin2.Image = Image.FromFile("treff.jpg");
                                        break;
                                    case 4:
                                        pb_lapszin1.Image = Image.FromFile("karo.jpg");
                                        pb_lapszin2.Image = Image.FromFile("karo.jpg");
                                        break;
                                }
                                break;
                            case 12:
                                lbl_lapert1.Text = "Q";
                                lbl_lapert2.Text = "Q";
                                switch (szinek[i])
                                {
                                    case 1:
                                        pb_lapszin1.Image = Image.FromFile("pikk.jpg");
                                        pb_lapszin2.Image = Image.FromFile("pikk.jpg");
                                        break;
                                    case 2:
                                        pb_lapszin1.Image = Image.FromFile("kor.jpg");
                                        pb_lapszin2.Image = Image.FromFile("kor.jpg");
                                        break;
                                    case 3:
                                        pb_lapszin1.Image = Image.FromFile("treff.jpg");
                                        pb_lapszin2.Image = Image.FromFile("treff.jpg");
                                        break;
                                    case 4:
                                        pb_lapszin1.Image = Image.FromFile("karo.jpg");
                                        pb_lapszin2.Image = Image.FromFile("karo.jpg");
                                        break;
                                }
                                break;
                            case 13:
                                lbl_lapert1.Text = "K";
                                lbl_lapert2.Text = "K";
                                switch (szinek[i])
                                {
                                    case 1:
                                        pb_lapszin1.Image = Image.FromFile("pikk.jpg");
                                        pb_lapszin2.Image = Image.FromFile("pikk.jpg");
                                        break;
                                    case 2:
                                        pb_lapszin1.Image = Image.FromFile("kor.jpg");
                                        pb_lapszin2.Image = Image.FromFile("kor.jpg");
                                        break;
                                    case 3:
                                        pb_lapszin1.Image = Image.FromFile("treff.jpg");
                                        pb_lapszin2.Image = Image.FromFile("treff.jpg");
                                        break;
                                    case 4:
                                        pb_lapszin1.Image = Image.FromFile("karo.jpg");
                                        pb_lapszin2.Image = Image.FromFile("karo.jpg");
                                        break;
                                }
                                break;
                        }
                        osztás[i] = 10;
                        pnl_lap1.BorderStyle = BorderStyle.FixedSingle;
                        pnl_lap1.BackColor = Color.White;                        
                    }
                    else if (osztás[i] > 1)
                    {
                        lbl_lapert1.Text = osztás[i].ToString();
                        lbl_lapert2.Text = osztás[i].ToString();
                        pnl_lap1.BorderStyle = BorderStyle.FixedSingle;
                        pnl_lap1.BackColor = Color.White;
                        switch (szinek[i])
                        {
                            case 1:
                                pb_lapszin1.Image = Image.FromFile("pikk.jpg");
                                pb_lapszin2.Image = Image.FromFile("pikk.jpg");
                                break;
                            case 2:
                                pb_lapszin1.Image = Image.FromFile("kor.jpg");
                                pb_lapszin2.Image = Image.FromFile("kor.jpg");
                                break;
                            case 3:
                                pb_lapszin1.Image = Image.FromFile("treff.jpg");
                                pb_lapszin2.Image = Image.FromFile("treff.jpg");
                                break;
                            case 4:
                                pb_lapszin1.Image = Image.FromFile("karo.jpg");
                                pb_lapszin2.Image = Image.FromFile("karo.jpg");
                                break;
                        }
                    }
                    else
                    {
                        lbl_lapert1.Text = "A";
                        lbl_lapert2.Text = "A";
                        pnl_lap1.BorderStyle = BorderStyle.FixedSingle;
                        pnl_lap1.BackColor = Color.White;
                        switch (szinek[i])
                        {
                            case 1:
                                pb_lapszin1.Image = Image.FromFile("pikk.jpg");
                                pb_lapszin2.Image = Image.FromFile("pikk.jpg");
                                break;
                            case 2:
                                pb_lapszin1.Image = Image.FromFile("kor.jpg");
                                pb_lapszin2.Image = Image.FromFile("kor.jpg");
                                break;
                            case 3:
                                pb_lapszin1.Image = Image.FromFile("treff.jpg");
                                pb_lapszin2.Image = Image.FromFile("treff.jpg");
                                break;
                            case 4:
                                pb_lapszin1.Image = Image.FromFile("karo.jpg");
                                pb_lapszin2.Image = Image.FromFile("karo.jpg");
                                break;
                        }
                    }
                }
                else if (i == 2)
                {
                    if (osztás[i] > 10)
                    {
                        switch (osztás[i])
                        {
                            case 11:
                                lbl_lapert35.Text = "J";
                                lbl_lapert36.Text = "J";
                                switch (szinek[i])
                                {
                                    case 1:
                                        pb_lapszin35.Image = Image.FromFile("pikk.jpg");
                                        pb_lapszin36.Image = Image.FromFile("pikk.jpg");
                                        break;
                                    case 2:
                                        pb_lapszin35.Image = Image.FromFile("kor.jpg");
                                        pb_lapszin36.Image = Image.FromFile("kor.jpg");
                                        break;
                                    case 3:
                                        pb_lapszin35.Image = Image.FromFile("treff.jpg");
                                        pb_lapszin36.Image = Image.FromFile("treff.jpg");
                                        break;
                                    case 4:
                                        pb_lapszin35.Image = Image.FromFile("karo.jpg");
                                        pb_lapszin36.Image = Image.FromFile("karo.jpg");
                                        break;
                                }
                                break;
                            case 12:
                                lbl_lapert35.Text = "Q";
                                lbl_lapert36.Text = "Q";
                                switch (szinek[i])
                                {
                                    case 1:
                                        pb_lapszin35.Image = Image.FromFile("pikk.jpg");
                                        pb_lapszin36.Image = Image.FromFile("pikk.jpg");
                                        break;
                                    case 2:
                                        pb_lapszin35.Image = Image.FromFile("kor.jpg");
                                        pb_lapszin36.Image = Image.FromFile("kor.jpg");
                                        break;
                                    case 3:
                                        pb_lapszin35.Image = Image.FromFile("treff.jpg");
                                        pb_lapszin36.Image = Image.FromFile("treff.jpg");
                                        break;
                                    case 4:
                                        pb_lapszin35.Image = Image.FromFile("karo.jpg");
                                        pb_lapszin36.Image = Image.FromFile("karo.jpg");
                                        break;
                                }
                                break;
                            case 13:
                                lbl_lapert35.Text = "K";
                                lbl_lapert36.Text = "K";
                                switch (szinek[i])
                                {
                                    case 1:
                                        pb_lapszin35.Image = Image.FromFile("pikk.jpg");
                                        pb_lapszin36.Image = Image.FromFile("pikk.jpg");
                                        break;
                                    case 2:
                                        pb_lapszin35.Image = Image.FromFile("kor.jpg");
                                        pb_lapszin36.Image = Image.FromFile("kor.jpg");
                                        break;
                                    case 3:
                                        pb_lapszin35.Image = Image.FromFile("treff.jpg");
                                        pb_lapszin36.Image = Image.FromFile("treff.jpg");
                                        break;
                                    case 4:
                                        pb_lapszin35.Image = Image.FromFile("karo.jpg");
                                        pb_lapszin36.Image = Image.FromFile("karo.jpg");
                                        break;
                                }
                                break;
                        }
                        osztás[i] = 10;
                        pnl_lap18.BorderStyle = BorderStyle.FixedSingle;
                        pnl_lap18.BackColor = Color.White;
                    }
                    else if (osztás[i] > 1)
                    {
                        lbl_lapert35.Text = osztás[i].ToString();
                        lbl_lapert36.Text = osztás[i].ToString();
                        pnl_lap18.BorderStyle = BorderStyle.FixedSingle;
                        pnl_lap18.BackColor = Color.White;
                        switch (szinek[i])
                        {
                            case 1:
                                pb_lapszin35.Image = Image.FromFile("pikk.jpg");
                                pb_lapszin36.Image = Image.FromFile("pikk.jpg");
                                break;
                            case 2:
                                pb_lapszin35.Image = Image.FromFile("kor.jpg");
                                pb_lapszin36.Image = Image.FromFile("kor.jpg");
                                break;
                            case 3:
                                pb_lapszin35.Image = Image.FromFile("treff.jpg");
                                pb_lapszin36.Image = Image.FromFile("treff.jpg");
                                break;
                            case 4:
                                pb_lapszin35.Image = Image.FromFile("karo.jpg");
                                pb_lapszin36.Image = Image.FromFile("karo.jpg");
                                break;
                        }
                    }
                    else
                    {
                        lbl_lapert35.Text = "A";
                        lbl_lapert36.Text = "A";
                        pnl_lap18.BorderStyle = BorderStyle.FixedSingle;
                        pnl_lap18.BackColor = Color.White;
                        switch (szinek[i])
                        {
                            case 1:
                                pb_lapszin35.Image = Image.FromFile("pikk.jpg");
                                pb_lapszin36.Image = Image.FromFile("pikk.jpg");
                                break;
                            case 2:
                                pb_lapszin35.Image = Image.FromFile("kor.jpg");
                                pb_lapszin36.Image = Image.FromFile("kor.jpg");
                                break;
                            case 3:
                                pb_lapszin35.Image = Image.FromFile("treff.jpg");
                                pb_lapszin36.Image = Image.FromFile("treff.jpg");
                                break;
                            case 4:
                                pb_lapszin35.Image = Image.FromFile("karo.jpg");
                                pb_lapszin36.Image = Image.FromFile("karo.jpg");
                                break;
                        }
                    }
                }
                else if (i == 3)
                {
                    if (osztás[i] > 10)
                    {
                        switch (osztás[i])
                        {
                            case 11:
                                lbl_lapert3.Text = "J";
                                lbl_lapert4.Text = "J";
                                switch (szinek[i])
                                {
                                    case 1:
                                        pb_lapszin3.Image = Image.FromFile("pikk.jpg");
                                        pb_lapszin4.Image = Image.FromFile("pikk.jpg");
                                        break;
                                    case 2:
                                        pb_lapszin3.Image = Image.FromFile("kor.jpg");
                                        pb_lapszin4.Image = Image.FromFile("kor.jpg");
                                        break;
                                    case 3:
                                        pb_lapszin3.Image = Image.FromFile("treff.jpg");
                                        pb_lapszin4.Image = Image.FromFile("treff.jpg");
                                        break;
                                    case 4:
                                        pb_lapszin3.Image = Image.FromFile("karo.jpg");
                                        pb_lapszin4.Image = Image.FromFile("karo.jpg");
                                        break;
                                }
                                break;
                            case 12:
                                lbl_lapert3.Text = "Q";
                                lbl_lapert4.Text = "Q";
                                switch (szinek[i])
                                {
                                    case 1:
                                        pb_lapszin3.Image = Image.FromFile("pikk.jpg");
                                        pb_lapszin4.Image = Image.FromFile("pikk.jpg");
                                        break;
                                    case 2:
                                        pb_lapszin3.Image = Image.FromFile("kor.jpg");
                                        pb_lapszin4.Image = Image.FromFile("kor.jpg");
                                        break;
                                    case 3:
                                        pb_lapszin3.Image = Image.FromFile("treff.jpg");
                                        pb_lapszin4.Image = Image.FromFile("treff.jpg");
                                        break;
                                    case 4:
                                        pb_lapszin3.Image = Image.FromFile("karo.jpg");
                                        pb_lapszin4.Image = Image.FromFile("karo.jpg");
                                        break;
                                }
                                break;
                            case 13:
                                lbl_lapert3.Text = "K";
                                lbl_lapert4.Text = "K";
                                switch (szinek[i])
                                {
                                    case 1:
                                        pb_lapszin3.Image = Image.FromFile("pikk.jpg");
                                        pb_lapszin4.Image = Image.FromFile("pikk.jpg");
                                        break;
                                    case 2:
                                        pb_lapszin3.Image = Image.FromFile("kor.jpg");
                                        pb_lapszin4.Image = Image.FromFile("kor.jpg");
                                        break;
                                    case 3:
                                        pb_lapszin3.Image = Image.FromFile("treff.jpg");
                                        pb_lapszin4.Image = Image.FromFile("treff.jpg");
                                        break;
                                    case 4:
                                        pb_lapszin3.Image = Image.FromFile("karo.jpg");
                                        pb_lapszin4.Image = Image.FromFile("karo.jpg");
                                        break;
                                }
                                break;
                        }
                        osztás[i] = 10;
                        pnl_lap2.BorderStyle = BorderStyle.FixedSingle;
                        pnl_lap2.BackColor = Color.Black;
                        pb_lapszin3.Visible = false;
                        pb_lapszin4.Visible = false;
                    }
                    else if (osztás[i] > 1)
                    {
                        lbl_lapert3.Text = osztás[i].ToString();
                        lbl_lapert4.Text = osztás[i].ToString();
                        pnl_lap2.BorderStyle = BorderStyle.FixedSingle;
                        pnl_lap2.BackColor = Color.Black;
                        pb_lapszin3.Visible = false;
                        pb_lapszin4.Visible = false;
                        switch (szinek[i])
                        {
                            case 1:
                                pb_lapszin3.Image = Image.FromFile("pikk.jpg");
                                pb_lapszin4.Image = Image.FromFile("pikk.jpg");
                                break;
                            case 2:
                                pb_lapszin3.Image = Image.FromFile("kor.jpg");
                                pb_lapszin4.Image = Image.FromFile("kor.jpg");
                                break;
                            case 3:
                                pb_lapszin3.Image = Image.FromFile("treff.jpg");
                                pb_lapszin4.Image = Image.FromFile("treff.jpg");
                                break;
                            case 4:
                                pb_lapszin3.Image = Image.FromFile("karo.jpg");
                                pb_lapszin4.Image = Image.FromFile("karo.jpg");
                                break;
                        }
                    }
                    else
                    {
                        lbl_lapert3.Text = "A";
                        lbl_lapert4.Text = "A";
                        pnl_lap2.BorderStyle = BorderStyle.FixedSingle;
                        pnl_lap2.BackColor = Color.Black;
                        pb_lapszin3.Visible = false;
                        pb_lapszin4.Visible = false;
                        switch (szinek[i])
                        {
                            case 1:
                                pb_lapszin3.Image = Image.FromFile("pikk.jpg");
                                pb_lapszin4.Image = Image.FromFile("pikk.jpg");
                                break;
                            case 2:
                                pb_lapszin3.Image = Image.FromFile("kor.jpg");
                                pb_lapszin4.Image = Image.FromFile("kor.jpg");
                                break;
                            case 3:
                                pb_lapszin3.Image = Image.FromFile("treff.jpg");
                                pb_lapszin4.Image = Image.FromFile("treff.jpg");
                                break;
                            case 4:
                                pb_lapszin3.Image = Image.FromFile("karo.jpg");
                                pb_lapszin4.Image = Image.FromFile("karo.jpg");
                                break;
                        }
                    }
                }
            }
            if (osztás[0] == 1 || osztás[2] == 1)
            {
                if (osztás[0] == 1)
                {
                    if (11 + osztás[2] == 21)
                    {
                        if ((11 + osztás[1]) == 21 || (11 + osztás[3]) == 21)
                        {
                            pnl_lap4.BackColor = Color.White;
                            pnl_lap4.BorderStyle = BorderStyle.FixedSingle;
                            MessageBox.Show("Döntetlen");
                            ertekeles();
                        }
                        else
                        {
                            pnl_lap4.BackColor = Color.White;
                            pnl_lap4.BorderStyle = BorderStyle.FixedSingle;
                            MessageBox.Show("Nyertél");
                            ertekeles();
                        }
                    }
                    else
                    {
                        if (11 + osztás[2] < 21)
                        {
                            btn_1.Text = (1 + osztás[2]).ToString();
                            btn_1.Visible = true;
                            btn_11.Text = (11 + osztás[2]).ToString();
                            btn_11.Visible = true;
                            lbl_szoveg19.Visible = true;
                        }
                        else
                        {
                            userert = 1 + osztás[2];
                        }
                    }

                }
                else
                {
                    if (11 + osztás[0] == 21)
                    {
                        if ((11 + osztás[1]) == 21 || (11 + osztás[3]) == 21)
                        {                            
                            pnl_lap4.BackColor = Color.White;
                            pnl_lap4.BorderStyle = BorderStyle.FixedSingle;
                            MessageBox.Show("Döntetlen");
                            ertekeles();
                        }
                        else
                        {
                            pnl_lap4.BackColor = Color.White;
                            pnl_lap4.BorderStyle = BorderStyle.FixedSingle;
                            MessageBox.Show("Nyertél");
                            ertekeles();
                        }
                    }
                    else
                    {
                        if (11 + osztás[0] < 21)
                        {
                            btn_1.Text = (1 + osztás[0]).ToString();
                            btn_1.Visible = true;
                            btn_11.Visible = true;
                            lbl_szoveg19.Visible = true;
                            btn_11.Text = (11 + osztás[0]).ToString();
                        }
                        else
                        {
                            userert = 1 + osztás[0];
                        }
                    }
                }
            }
            else if (osztás[0] == 1 && osztás[2] == 1)
            {
                btn_1.Text = 2.ToString();
                btn_11.Text = 12.ToString();
                btn_1.Visible = true;
                btn_11.Visible = true;
                lbl_szoveg19.Visible = true;
                felez = true;
                btn_min.Enabled = true;
            }
            else if (osztás[0] == osztás[2])
            {
                userert = osztás[0] + osztás[2];
                felez = true;
                btn_min.Enabled = true;
            }
            else
            {
                userert = osztás[0] + osztás[2];
                btn_min.Enabled = false;
            }

        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            string gombszöveg = btn_min.Text;
            if (gombszöveg == "Minimum")
            {
                if (zseton > 25)
                {
                    Osztás();
                    lbl_zsetonod.Text = (zseton - 25).ToString();
                    jatekban = 25;
                    btn_ismetles.Enabled = true;
                    lbl_playerert.Text = userert.ToString();
                    sb_egyeni.Visible = false;
                    btn_betesz.Visible = false;
                    elozo = 25;
                    btn_min.Enabled = false;
                    if (btn_1.Visible == true)
                    {
                        btn_min.Enabled = false;
                        btn_ismetles.Enabled = false;
                        btn_max.Enabled = false;
                        btn_egyeni.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Elfogyott a pénzed! \n Vegyél zsetont ha szeretnéd folytatni");
                }
            }
            if (gombszöveg == "Felezés")
            {
                lbl_lapert17.Text = lbl_lapert35.Text;
                lbl_lapert18.Text = lbl_lapert35.Text;
                pb_lapszin17.Image = pb_lapszin35.Image;
                pb_lapszin18.Image = pb_lapszin35.Image;
                Random felez = new Random();
                int lap1 = felez.Next(1, 14);
                int lapszin1 = felez.Next(1, 5);
                int lap2 = felez.Next(1, 14);
                int lapszin2 = felez.Next(1, 5);

                if (lap1 < 11 && lap1 > 1)
                {
                    lbl_lapert35.Text = lap1.ToString();
                    lbl_lapert36.Text = lap1.ToString();
                    userert = lap1 + osztás[2];
                }
                else if (lap1 > 10)
                {
                    switch (lap1)
                    {
                        case 11:
                            lbl_lapert35.Text = "J";
                            lbl_lapert36.Text = "J";
                            break;
                        case 12:
                            lbl_lapert35.Text = "Q";
                            lbl_lapert36.Text = "Q";
                            break;
                        case 13:
                            lbl_lapert35.Text = "K";
                            lbl_lapert36.Text = "K";
                            break;
                    }
                    lap1 = 10;
                    userert = 10 + osztás[2];
                }
                else
                {
                    lbl_lapert35.Text = "A";
                    lbl_lapert36.Text = "A";
                    if (osztás[2] != 11)
                    {
                        btn_1.Text = (osztás[2] + 1).ToString();
                        btn_11.Text = (osztás[2] + 11).ToString();
                    }
                    else
                    {
                        userert = osztás[2] + 1;
                    }
                    lbl_szoveg19.Visible = true;
                    btn_1.Visible = true;
                    btn_11.Visible = true;
                }
                switch (lapszin1)
                {
                    case 1:
                        pb_lapszin35.Image = Image.FromFile("pikk.jpg");
                        pb_lapszin36.Image = Image.FromFile("pikk.jpg");
                        break;
                    case 2:
                        pb_lapszin35.Image = Image.FromFile("kor.jpg");
                        pb_lapszin36.Image = Image.FromFile("kor.jpg");
                        break;
                    case 3:
                        pb_lapszin35.Image = Image.FromFile("treff.jpg");
                        pb_lapszin36.Image = Image.FromFile("treff.jpg");
                        break;
                    case 4:
                        pb_lapszin35.Image = Image.FromFile("karo.jpg");
                        pb_lapszin36.Image = Image.FromFile("karo.jpg");
                        break;
                }
            }
        }

        public void gombok()
        {
            btn_min.Text = "Felezés";
            btn_max.Text = "Megállok";
            btn_egyeni.Text = "Lapkérés";
            btn_ismetles.Text = "Duplázás";
        }

        public void kartyaurit()
        {
            lbl_lapert1.Text = "";
            lbl_lapert2.Text = "";
            lbl_lapert3.Text = "";
            lbl_lapert4.Text = "";
            lbl_lapert5.Text = "";
            lbl_lapert6.Text = "";
            lbl_lapert7.Text = "";
            lbl_lapert8.Text = "";
            lbl_lapert9.Text = "";
            lbl_lapert10.Text = "";
            lbl_lapert11.Text = "";
            lbl_lapert12.Text = "";
            lbl_lapert13.Text = "";
            lbl_lapert14.Text = "";
            lbl_lapert15.Text = "";
            lbl_lapert16.Text = "";
            lbl_lapert17.Text = "";
            lbl_lapert18.Text = "";
            lbl_lapert19.Text = "";
            lbl_lapert20.Text = "";
            lbl_lapert21.Text = "";
            lbl_lapert22.Text = "";
            lbl_lapert23.Text = "";
            lbl_lapert24.Text = "";
            lbl_lapert25.Text = "";
            lbl_lapert26.Text = "";
            lbl_lapert27.Text = "";
            lbl_lapert28.Text = "";
            lbl_lapert29.Text = "";
            lbl_lapert30.Text = "";
            lbl_lapert31.Text = "";
            lbl_lapert32.Text = "";
            lbl_lapert33.Text = "";
            lbl_lapert34.Text = "";
            lbl_lapert35.Text = "";
            lbl_lapert36.Text = "";
            lbl_lapert37.Text = "";
            lbl_lapert38.Text = "";
            lbl_lapert39.Text = "";
            lbl_lapert40.Text = "";
            lbl_lapert41.Text = "";
            lbl_lapert42.Text = "";
            lbl_lapert43.Text = "";
            lbl_lapert44.Text = "";
            lbl_lapert45.Text = "";
            lbl_lapert46.Text = "";
            lbl_lapert47.Text = "";
            lbl_lapert48.Text = "";
        }

        public void laptelit()
        {
            lbl_lapert1.Text = "T";
            lbl_lapert2.Text = "T";
            lbl_lapert3.Text = "T";
            lbl_lapert4.Text = "T";
            lbl_lapert5.Text = "T";
            lbl_lapert6.Text = "T";
            lbl_lapert7.Text = "T";
            lbl_lapert8.Text = "T";
            lbl_lapert9.Text = "T";
            lbl_lapert10.Text = "T";
            lbl_lapert11.Text = "T";
            lbl_lapert12.Text = "T";
            lbl_lapert13.Text = "T";
            lbl_lapert14.Text = "T";
            lbl_lapert15.Text = "T";
            lbl_lapert16.Text = "T";
            lbl_lapert17.Text = "T";
            lbl_lapert18.Text = "T";
            lbl_lapert19.Text = "T";
            lbl_lapert20.Text = "T";
            lbl_lapert21.Text = "T";
            lbl_lapert22.Text = "T";
            lbl_lapert23.Text = "T";
            lbl_lapert24.Text = "T";
            lbl_lapert25.Text = "T";
            lbl_lapert26.Text = "T";
            lbl_lapert27.Text = "T";
            lbl_lapert28.Text = "T";
            lbl_lapert29.Text = "T";
            lbl_lapert30.Text = "T";
            lbl_lapert31.Text = "T";
            lbl_lapert32.Text = "T";
            lbl_lapert33.Text = "T";
            lbl_lapert34.Text = "T";
            lbl_lapert35.Text = "T";
            lbl_lapert36.Text = "T";
            lbl_lapert37.Text = "T";
            lbl_lapert38.Text = "T";
            lbl_lapert39.Text = "T";
            lbl_lapert40.Text = "T";
            lbl_lapert41.Text = "T";
            lbl_lapert42.Text = "T";
            lbl_lapert43.Text = "T";
            lbl_lapert44.Text = "T";
            lbl_lapert45.Text = "T";
            lbl_lapert46.Text = "T";
            lbl_lapert47.Text = "T";
            lbl_lapert48.Text = "T";
        }

        public void betolt()
        {
            pnl_belepes.Location = new Point(699, 343);
            pnl_jatek.SendToBack();
        }

        public void bank()
        {
            //int db = 0;
            Random ker = new Random();
            int uj;
            int ujszin;
            if (osztás[1] == 1 || osztás[3] == 1)
            {
                if (osztás[3] == 1)
                {
                    osztoert = osztás[1] + 11;
                }
                else
                {
                    osztoert = osztás[3] + 11;
                }
            }
            else if (osztás[1] == 1 && osztás[3] == 1)
            {
                osztoert = 12;
            }
            else
            {
                osztoert = osztás[1] + osztás[3];
            }
            pnl_lap2.BackColor = Color.White;
            pb_lapszin3.Visible = true;
            pb_lapszin4.Visible = true;
            lbl_osztoert.Text = osztoert.ToString();
            if (osztoert < 17)
            {
                pnl_lap3.BackColor = Color.White;
                pnl_lap3.BorderStyle = BorderStyle.FixedSingle;
                uj = ker.Next(1, 14);
                ujszin = ker.Next(1, 5);
                switch (ujszin)
                {
                    case 1:
                        pb_lapszin5.Image = Image.FromFile("pikk.jpg");
                        pb_lapszin6.Image = Image.FromFile("pikk.jpg");
                        break;
                    case 2:
                        pb_lapszin5.Image = Image.FromFile("kor.jpg");
                        pb_lapszin6.Image = Image.FromFile("kor.jpg");
                        break;
                    case 3:
                        pb_lapszin5.Image = Image.FromFile("treff.jpg");
                        pb_lapszin6.Image = Image.FromFile("treff.jpg");
                        break;
                    case 4:
                        pb_lapszin5.Image = Image.FromFile("karo.jpg");
                        pb_lapszin6.Image = Image.FromFile("karo.jpg");
                        break;
                }
                if (uj > 10)
                {
                    switch (uj)
                    {

                        case 11:
                            lbl_lapert5.Text = "J";
                            lbl_lapert6.Text = "J";
                            break;
                        case 12:
                            lbl_lapert5.Text = "Q";
                            lbl_lapert6.Text = "Q";
                            break;
                        case 13:
                            lbl_lapert5.Text = "K";
                            lbl_lapert6.Text = "K";
                            break;
                    }
                    osztoert += 10;
                    if (osztoert > 21)
                    {
                        banksok = true;
                    }
                }
                else if (uj < 2)
                {
                    if (osztoert + 11 > 17)
                    {
                        osztoert += 1;
                        lbl_lapert5.Text = "A";
                        lbl_lapert6.Text = "A";
                    }
                    else
                    {
                        osztoert += 11;
                        lbl_lapert5.Text = "A";
                        lbl_lapert6.Text = "A";
                        if (osztoert > 21)
                        {
                            banksok = true;
                        }
                    }
                }
                else
                {
                    osztoert += uj;
                    lbl_lapert5.Text = uj.ToString();
                    lbl_lapert6.Text = uj.ToString();
                    if (osztoert > 21)
                    {
                        banksok = true;
                    }
                }
                if (osztoert < 17)
                {
                    pnl_lap4.BackColor = Color.White;
                    pnl_lap4.BorderStyle = BorderStyle.FixedSingle;
                    uj = ker.Next(1, 14);
                    ujszin = ker.Next(1, 5);
                    lbl_osztoert.Text = osztoert.ToString();
                    switch (ujszin)
                    {
                        case 1:
                            pb_lapszin7.Image = Image.FromFile("pikk.jpg");
                            pb_lapszin8.Image = Image.FromFile("pikk.jpg");
                            break;
                        case 2:
                            pb_lapszin7.Image = Image.FromFile("kor.jpg");
                            pb_lapszin8.Image = Image.FromFile("kor.jpg");
                            break;
                        case 3:
                            pb_lapszin7.Image = Image.FromFile("treff.jpg");
                            pb_lapszin8.Image = Image.FromFile("treff.jpg");
                            break;
                        case 4:
                            pb_lapszin7.Image = Image.FromFile("karo.jpg");
                            pb_lapszin8.Image = Image.FromFile("karo.jpg");
                            break;
                    }
                    if (uj > 10)
                    {
                        switch (uj)
                        {

                            case 11:
                                lbl_lapert7.Text = "J";
                                lbl_lapert8.Text = "J";
                                break;
                            case 12:
                                lbl_lapert7.Text = "Q";
                                lbl_lapert8.Text = "Q";
                                break;
                            case 13:
                                lbl_lapert7.Text = "K";
                                lbl_lapert8.Text = "K";
                                break;
                        }
                        osztoert += 10;
                        if (osztoert > 21)
                        {
                            banksok = true;
                        }
                    }
                    else if (uj < 2)
                    {
                        if (osztoert + 11 > 17)
                        {
                            osztoert += 1;
                            lbl_lapert7.Text = "A";
                            lbl_lapert8.Text = "A";
                        }
                        else
                        {
                            osztoert += 11;
                            lbl_lapert7.Text = "A";
                            lbl_lapert8.Text = "A";
                            if (osztoert > 21)
                            {
                                banksok = true;
                            }
                        }
                    }
                    else
                    {
                        osztoert += uj;
                        lbl_lapert7.Text = uj.ToString();
                        lbl_lapert8.Text = uj.ToString();
                        if (osztoert > 21)
                        {
                            banksok = true;
                        }
                    }
                    lbl_osztoert.Text = osztoert.ToString();
                    if (osztoert < 17)
                    {
                        pnl_lap5.BackColor = Color.White;
                        pnl_lap5.BorderStyle = BorderStyle.FixedSingle;
                        uj = ker.Next(1, 14);
                        ujszin = ker.Next(1, 5);
                        lbl_osztoert.Text = osztoert.ToString();
                        switch (ujszin)
                        {
                            case 1:
                                pb_lapszin9.Image = Image.FromFile("pikk.jpg");
                                pb_lapszin10.Image = Image.FromFile("pikk.jpg");
                                break;
                            case 2:
                                pb_lapszin9.Image = Image.FromFile("kor.jpg");
                                pb_lapszin10.Image = Image.FromFile("kor.jpg");
                                break;
                            case 3:
                                pb_lapszin9.Image = Image.FromFile("treff.jpg");
                                pb_lapszin10.Image = Image.FromFile("treff.jpg");
                                break;
                            case 4:
                                pb_lapszin9.Image = Image.FromFile("karo.jpg");
                                pb_lapszin10.Image = Image.FromFile("karo.jpg");
                                break;
                        }
                        if (uj > 10)
                        {
                            switch (uj)
                            {

                                case 11:
                                    lbl_lapert9.Text = "J";
                                    lbl_lapert10.Text = "J";
                                    break;
                                case 12:
                                    lbl_lapert9.Text = "Q";
                                    lbl_lapert10.Text = "Q";
                                    break;
                                case 13:
                                    lbl_lapert9.Text = "K";
                                    lbl_lapert10.Text = "K";
                                    break;
                            }
                            osztoert += 10;
                            if (osztoert > 21)
                            {
                                banksok = true;
                            }
                        }
                        else if (uj < 2)
                        {
                            if (osztoert + 11 > 17)
                            {
                                osztoert += 1;
                                lbl_lapert9.Text = "A";
                                lbl_lapert10.Text = "A";
                            }
                            else
                            {
                                osztoert += 11;
                                lbl_lapert9.Text = "A";
                                lbl_lapert10.Text = "A";
                                if (osztoert > 21)
                                {
                                    banksok = true;
                                }
                            }
                        }
                        else
                        {
                            osztoert += uj;
                            lbl_lapert9.Text = uj.ToString();
                            lbl_lapert10.Text = uj.ToString();
                            if (osztoert > 21)
                            {
                                banksok = true;
                            }
                        }
                        lbl_osztoert.Text = osztoert.ToString();
                        if (osztoert < 17)
                        {
                            pnl_lap6.BackColor = Color.White;
                            pnl_lap6.BorderStyle = BorderStyle.FixedSingle;
                            uj = ker.Next(1, 14);
                            ujszin = ker.Next(1, 5);
                            lbl_osztoert.Text = osztoert.ToString();
                            switch (ujszin)
                            {
                                case 1:
                                    pb_lapszin11.Image = Image.FromFile("pikk.jpg");
                                    pb_lapszin12.Image = Image.FromFile("pikk.jpg");
                                    break;
                                case 2:
                                    pb_lapszin11.Image = Image.FromFile("kor.jpg");
                                    pb_lapszin12.Image = Image.FromFile("kor.jpg");
                                    break;
                                case 3:
                                    pb_lapszin11.Image = Image.FromFile("treff.jpg");
                                    pb_lapszin12.Image = Image.FromFile("treff.jpg");
                                    break;
                                case 4:
                                    pb_lapszin11.Image = Image.FromFile("karo.jpg");
                                    pb_lapszin12.Image = Image.FromFile("karo.jpg");
                                    break;
                            }
                            if (uj > 10)
                            {
                                switch (uj)
                                {

                                    case 11:
                                        lbl_lapert11.Text = "J";
                                        lbl_lapert12.Text = "J";
                                        break;
                                    case 12:
                                        lbl_lapert11.Text = "Q";
                                        lbl_lapert12.Text = "Q";
                                        break;
                                    case 13:
                                        lbl_lapert11.Text = "K";
                                        lbl_lapert12.Text = "K";
                                        break;
                                }
                                osztoert += 10;
                                if (osztoert > 21)
                                {
                                    banksok = true;
                                }
                            }
                            else if (uj < 2)
                            {
                                if (osztoert + 11 > 17)
                                {
                                    osztoert += 1;
                                    lbl_lapert11.Text = "A";
                                    lbl_lapert12.Text = "A";
                                }
                                else
                                {
                                    osztoert += 11;
                                    lbl_lapert11.Text = "A";
                                    lbl_lapert12.Text = "A";
                                    if (osztoert > 21)
                                    {
                                        banksok = true;
                                    }
                                }
                            }
                            else
                            {
                                osztoert += uj;
                                lbl_lapert11.Text = uj.ToString();
                                lbl_lapert12.Text = uj.ToString();
                                if (osztoert > 21)
                                {
                                    banksok = true;
                                }
                            }
                            lbl_osztoert.Text = osztoert.ToString();
                            if (osztoert < 17)
                            {
                                pnl_lap7.BackColor = Color.White;
                                pnl_lap7.BorderStyle = BorderStyle.FixedSingle;
                                uj = ker.Next(1, 14);
                                ujszin = ker.Next(1, 5);
                                lbl_osztoert.Text = osztoert.ToString();
                                switch (ujszin)
                                {
                                    case 1:
                                        pb_lapszin13.Image = Image.FromFile("pikk.jpg");
                                        pb_lapszin14.Image = Image.FromFile("pikk.jpg");
                                        break;
                                    case 2:
                                        pb_lapszin13.Image = Image.FromFile("kor.jpg");
                                        pb_lapszin14.Image = Image.FromFile("kor.jpg");
                                        break;
                                    case 3:
                                        pb_lapszin13.Image = Image.FromFile("treff.jpg");
                                        pb_lapszin14.Image = Image.FromFile("treff.jpg");
                                        break;
                                    case 4:
                                        pb_lapszin13.Image = Image.FromFile("karo.jpg");
                                        pb_lapszin14.Image = Image.FromFile("karo.jpg");
                                        break;
                                }
                                if (uj > 10)
                                {
                                    switch (uj)
                                    {

                                        case 11:
                                            lbl_lapert13.Text = "J";
                                            lbl_lapert14.Text = "J";
                                            break;
                                        case 12:
                                            lbl_lapert13.Text = "Q";
                                            lbl_lapert14.Text = "Q";
                                            break;
                                        case 13:
                                            lbl_lapert13.Text = "K";
                                            lbl_lapert14.Text = "K";
                                            break;
                                    }
                                    osztoert += 10;
                                    if (osztoert > 21)
                                    {
                                        banksok = true;
                                    }
                                }
                                else if (uj < 2)
                                {
                                    if (osztoert + 11 > 17)
                                    {
                                        osztoert += 1;
                                        lbl_lapert13.Text = "A";
                                        lbl_lapert14.Text = "A";
                                    }
                                    else
                                    {
                                        osztoert += 11;
                                        lbl_lapert13.Text = "A";
                                        lbl_lapert14.Text = "A";
                                        if (osztoert > 21)
                                        {
                                            banksok = true;
                                        }
                                    }
                                }
                                else
                                {
                                    osztoert += uj;
                                    lbl_lapert13.Text = uj.ToString();
                                    lbl_lapert14.Text = uj.ToString();
                                    if (osztoert > 21)
                                    {
                                        banksok = true;
                                    }
                                }
                                lbl_osztoert.Text = osztoert.ToString();
                                if (osztoert < 17)
                                {
                                    pnl_lap8.BackColor = Color.White;
                                    pnl_lap8.BorderStyle = BorderStyle.FixedSingle;
                                    uj = ker.Next(1, 14);
                                    ujszin = ker.Next(1, 5);
                                    lbl_osztoert.Text = osztoert.ToString();
                                    switch (ujszin)
                                    {
                                        case 1:
                                            pb_lapszin15.Image = Image.FromFile("pikk.jpg");
                                            pb_lapszin16.Image = Image.FromFile("pikk.jpg");
                                            break;
                                        case 2:
                                            pb_lapszin15.Image = Image.FromFile("kor.jpg");
                                            pb_lapszin16.Image = Image.FromFile("kor.jpg");
                                            break;
                                        case 3:
                                            pb_lapszin15.Image = Image.FromFile("treff.jpg");
                                            pb_lapszin16.Image = Image.FromFile("treff.jpg");
                                            break;
                                        case 4:
                                            pb_lapszin15.Image = Image.FromFile("karo.jpg");
                                            pb_lapszin16.Image = Image.FromFile("karo.jpg");
                                            break;
                                    }
                                    if (uj > 10)
                                    {
                                        switch (uj)
                                        {

                                            case 11:
                                                lbl_lapert15.Text = "J";
                                                lbl_lapert16.Text = "J";
                                                break;
                                            case 12:
                                                lbl_lapert15.Text = "Q";
                                                lbl_lapert16.Text = "Q";
                                                break;
                                            case 13:
                                                lbl_lapert15.Text = "K";
                                                lbl_lapert16.Text = "K";
                                                break;
                                        }
                                        osztoert += 10;
                                        if (osztoert > 21)
                                        {
                                            banksok = true;
                                        }
                                    }
                                    else if (uj < 2)
                                    {
                                        if (osztoert + 11 > 17)
                                        {
                                            osztoert += 1;
                                            lbl_lapert15.Text = "A";
                                            lbl_lapert16.Text = "A";
                                        }
                                        else
                                        {
                                            osztoert += 11;
                                            lbl_lapert15.Text = "A";
                                            lbl_lapert16.Text = "A";
                                            if (osztoert > 21)
                                            {
                                                banksok = true;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        osztoert += uj;
                                        lbl_lapert15.Text = uj.ToString();
                                        lbl_lapert16.Text = uj.ToString();
                                        if (osztoert > 21)
                                        {
                                            banksok = true;
                                        }
                                    }
                                    lbl_osztoert.Text = osztoert.ToString();
                                }
                                else
                                {
                                    ertekeles();
                                }
                            }
                            else
                            {
                                ertekeles();
                            }
                        }
                        else
                        {
                            ertekeles();
                        }
                    }
                    else
                    {
                        ertekeles();
                    }
                }
                else
                {
                    ertekeles();
                }
            }
            else
            {
                ertekeles();
            }
        }

        public void ertekeles()
        {
            if (banksok != true)
            {
                if (osztoert > userert)
                {
                    MessageBox.Show("A bank nyert");
                    jatekban = 0;
                    alaphelyzet();
                }
                else if (osztoert < userert)
                {
                    MessageBox.Show("Te nyertél gratu");
                    zseton = zseton + (jatekban * 2);
                    lbl_zsetonod.Text = zseton.ToString();
                    alaphelyzet();
                }
                else
                {
                    MessageBox.Show("Döntetlen lett");
                    zseton = zseton + jatekban;
                    lbl_zsetonod.Text = zseton.ToString();
                    alaphelyzet();
                }
            }
            else
            {
                MessageBox.Show("Te nyertél gratu");
                zseton = zseton + (jatekban * 2);
                lbl_zsetonod.Text = zseton.ToString();
                alaphelyzet();
            }
        }

        public void alaphelyzet()
        {
            pnl_lap1.BackColor = Color.Beige;
            pnl_lap1.BorderStyle = BorderStyle.None;
            pnl_lap2.BackColor = Color.Beige;
            pnl_lap2.BorderStyle = BorderStyle.None;
            pnl_lap3.BackColor = Color.Beige;
            pnl_lap3.BorderStyle = BorderStyle.None;
            pnl_lap4.BackColor = Color.Beige;
            pnl_lap4.BorderStyle = BorderStyle.None;
            pnl_lap5.BackColor = Color.Beige;
            pnl_lap5.BorderStyle = BorderStyle.None;
            pnl_lap6.BackColor = Color.Beige;
            pnl_lap6.BorderStyle = BorderStyle.None;
            pnl_lap7.BackColor = Color.Beige;
            pnl_lap7.BorderStyle = BorderStyle.None;
            pnl_lap8.BackColor = Color.Beige;
            pnl_lap8.BorderStyle = BorderStyle.None;
            pnl_lap9.BackColor = Color.Beige;
            pnl_lap9.BorderStyle = BorderStyle.None;
            pnl_lap10.BackColor = Color.Beige;
            pnl_lap10.BorderStyle = BorderStyle.None;
            pnl_lap11.BackColor = Color.Beige;
            pnl_lap11.BorderStyle = BorderStyle.None;
            pnl_lap12.BackColor = Color.Beige;
            pnl_lap12.BorderStyle = BorderStyle.None;
            pnl_lap13.BackColor = Color.Beige;
            pnl_lap13.BorderStyle = BorderStyle.None;
            pnl_lap14.BackColor = Color.Beige;
            pnl_lap14.BorderStyle = BorderStyle.None;
            pnl_lap15.BackColor = Color.Beige;
            pnl_lap15.BorderStyle = BorderStyle.None;
            pnl_lap16.BackColor = Color.Beige;
            pnl_lap16.BorderStyle = BorderStyle.None;
            pnl_lap17.BackColor = Color.Beige;
            pnl_lap17.BorderStyle = BorderStyle.None;
            pnl_lap18.BackColor = Color.Beige;
            pnl_lap18.BorderStyle = BorderStyle.None;
            kartyaurit();
            pb_lapszin1.Image = null;
            pb_lapszin2.Image = null;
            pb_lapszin3.Image = null;
            pb_lapszin4.Image = null;
            pb_lapszin5.Image = null;
            pb_lapszin6.Image = null;
            pb_lapszin7.Image = null;
            pb_lapszin8.Image = null;
            pb_lapszin9.Image = null;
            pb_lapszin10.Image = null;
            pb_lapszin11.Image = null;
            pb_lapszin12.Image = null;
            pb_lapszin13.Image = null;
            pb_lapszin14.Image = null;
            pb_lapszin15.Image = null;
            pb_lapszin16.Image = null;
            pb_lapszin17.Image = null;
            pb_lapszin18.Image = null;
            pb_lapszin19.Image = null;
            pb_lapszin20.Image = null;
            pb_lapszin21.Image = null;
            pb_lapszin22.Image = null;
            pb_lapszin23.Image = null;
            pb_lapszin24.Image = null;
            pb_lapszin25.Image = null;
            pb_lapszin26.Image = null;
            pb_lapszin27.Image = null;
            pb_lapszin28.Image = null;
            pb_lapszin29.Image = null;
            pb_lapszin30.Image = null;
            pb_lapszin31.Image = null;
            pb_lapszin32.Image = null;
            pb_lapszin33.Image = null;
            pb_lapszin34.Image = null;
            pb_lapszin35.Image = null;
            pb_lapszin36.Image = null;
            pb_lapszin37.Image = null;
            pb_lapszin38.Image = null;
            pb_lapszin39.Image = null;
            pb_lapszin40.Image = null;
            pb_lapszin41.Image = null;
            pb_lapszin42.Image = null;
            pb_lapszin43.Image = null;
            pb_lapszin44.Image = null;
            pb_lapszin45.Image = null;
            pb_lapszin46.Image = null;
            pb_lapszin47.Image = null;
            pb_lapszin48.Image = null;
            btn_min.Text = "Minimum";
            btn_max.Text = "Maximum";
            btn_egyeni.Text = "Egyéni tét";
            btn_ismetles.Text = "Ismétlés";
            btn_min.Enabled = true;
            lbl_playerert.Text = "";
            lbl_osztoert.Text = "";
            veszítt = false;
            jatekban = 0;
            banksok = false;
        }

        private void btn_hozzaad_Click(object sender, EventArgs e)
        {
            if (uto == false)
            {
                pnl_bankkartya.Visible = false;
                pnl_bankkartya.Location = new Point(521, 12);
            }
            else if (uto == true)
            {
                foreach(var item in User)
                {
                    if (username == item.Felhasznalonev)
                    {
                        item.Kartyaszam = tb_kartyaszam.Text;
                        item.Lejarat = tb_lejarat.Text;
                        item.Cvc = int.Parse(tb_cvc.Text);
                    }
                }
                pnl_bankkartya.Visible = false;
                pnl_bankkartya.Location = new Point(521, 12);
            }
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            string gomb = btn_max.Text;
            if (gomb == "Maximum")
            {
                if (zseton != 0 && zseton >= 1000)
                {
                    zseton = zseton - 1000;
                    jatekban = 1000;
                    lbl_zsetonod.Text = zseton.ToString();
                    sb_egyeni.Visible = false;
                    btn_betesz.Visible = false;
                    btn_ismetles.Enabled = true;
                    Osztás();
                    elozo = 1000;
                    btn_min.Enabled = false;
                    lbl_playerert.Text = userert.ToString();
                    if (btn_1.Visible == true)
                    {
                        btn_min.Enabled = false;
                        btn_ismetles.Enabled = false;
                        btn_max.Enabled = false;
                        btn_egyeni.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Elfogyott a pénzed vagy nincs elég zsetonod");
                }
            }
            else if (gomb == "Megállok")
            {
                bank();
            }
        }

        private void btn_egyeni_Click(object sender, EventArgs e)
        {
            string gomb = btn_egyeni.Text;
            if (gomb=="Egyéni tét")
            {
                if (zseton > 17)
                {
                    sb_egyeni.Visible = true;
                    btn_betesz.Visible = true;
                }
                else
                {
                    MessageBox.Show("Sajnáljuk a zsetonjaid vagy elfogytak vagy nincs elegendőd");
                }
            }
            else if (gomb == "Lapkérés")
            {               
                int db = 0;
                if (db == 0)
                {
                    lapertek = rnd.Next(1, 14);
                    szin = rnd.Next(1, 5);
                    lapkeresert();
                    pnl_lap13.BackColor = Color.White;
                    pnl_lap13.BorderStyle = BorderStyle.FixedSingle;
                    lbl_playerert.Text = userert.ToString();
                    switch (szin)
                    {
                        case 1:
                            pb_lapszin37.Image = Image.FromFile("pikk.jpg");
                            pb_lapszin38.Image = Image.FromFile("pikk.jpg");
                            break;
                        case 2:
                            pb_lapszin37.Image = Image.FromFile("kor.jpg");
                            pb_lapszin38.Image = Image.FromFile("kor.jpg");
                            break;
                        case 3:
                            pb_lapszin37.Image = Image.FromFile("treff.jpg");
                            pb_lapszin38.Image = Image.FromFile("treff.jpg");
                            break;
                        case 4:
                            pb_lapszin37.Image = Image.FromFile("karo.jpg");
                            pb_lapszin38.Image = Image.FromFile("karo.jpg");
                            break;
                    }
                    if (lapertek > 10)
                    {
                        switch (lapertek)
                        {
                            case 11:
                                lbl_lapert37.Text = "J";
                                lbl_lapert38.Text = "J";
                                break;
                            case 12:
                                lbl_lapert37.Text = "Q";
                                lbl_lapert38.Text = "Q";
                                break;
                            case 13:
                                lbl_lapert37.Text = "K";
                                lbl_lapert38.Text = "K";
                                break;
                        }
                    }
                    else
                    {
                        if (lapertek == 1)
                        {
                            lbl_lapert37.Text = "A";
                            lbl_lapert38.Text = "A";
                        }
                        else
                        {
                            lbl_lapert37.Text = lapertek.ToString();
                            lbl_lapert38.Text = lapertek.ToString();
                        }
                    }
                    if (veszítt == true)
                    {
                        MessageBox.Show("Vesztettél");
                        alaphelyzet();
                    }
                    if (db == 1)
                    {
                        lapertek = rnd.Next(1, 14);
                        szin = rnd.Next(1, 5);
                        lapkeresert();
                        pnl_lap14.BackColor = Color.White;
                        pnl_lap14.BorderStyle = BorderStyle.FixedSingle;
                        lbl_playerert.Text = userert.ToString();
                        switch (szin)
                        {
                            case 1:
                                pb_lapszin39.Image = Image.FromFile("pikk.jpg");
                                pb_lapszin40.Image = Image.FromFile("pikk.jpg");
                                break;
                            case 2:
                                pb_lapszin39.Image = Image.FromFile("kor.jpg");
                                pb_lapszin40.Image = Image.FromFile("kor.jpg");
                                break;
                            case 3:
                                pb_lapszin39.Image = Image.FromFile("treff.jpg");
                                pb_lapszin40.Image = Image.FromFile("treff.jpg");
                                break;
                            case 4:
                                pb_lapszin39.Image = Image.FromFile("karo.jpg");
                                pb_lapszin40.Image = Image.FromFile("karo.jpg");
                                break;
                        }
                        if (lapertek > 10)
                        {
                            switch (lapertek)
                            {
                                case 11:
                                    lbl_lapert39.Text = "J";
                                    lbl_lapert40.Text = "J";
                                    break;
                                case 12:
                                    lbl_lapert39.Text = "Q";
                                    lbl_lapert40.Text = "Q";
                                    break;
                                case 13:
                                    lbl_lapert39.Text = "K";
                                    lbl_lapert40.Text = "K";
                                    break;
                            }
                        }
                        else
                        {
                            if (lapertek == 1)
                            {
                                lbl_lapert39.Text = "A";
                                lbl_lapert40.Text = "A";
                            }
                            else
                            {
                                lbl_lapert39.Text = lapertek.ToString();
                                lbl_lapert40.Text = lapertek.ToString();
                            }
                        }
                        if (veszítt == true)
                        {
                            MessageBox.Show("Vesztettél");
                            alaphelyzet();
                        }
                        if (db == 2)
                        {
                            lapertek = rnd.Next(1, 14);
                            szin = rnd.Next(1, 5);
                            lapkeresert();
                            pnl_lap15.BackColor = Color.White;
                            pnl_lap15.BorderStyle = BorderStyle.FixedSingle;
                            lbl_playerert.Text = userert.ToString();
                            switch (szin)
                            {
                                case 1:
                                    pb_lapszin41.Image = Image.FromFile("pikk.jpg");
                                    pb_lapszin42.Image = Image.FromFile("pikk.jpg");
                                    break;
                                case 2:
                                    pb_lapszin41.Image = Image.FromFile("kor.jpg");
                                    pb_lapszin42.Image = Image.FromFile("kor.jpg");
                                    break;
                                case 3:
                                    pb_lapszin41.Image = Image.FromFile("treff.jpg");
                                    pb_lapszin42.Image = Image.FromFile("treff.jpg");
                                    break;
                                case 4:
                                    pb_lapszin41.Image = Image.FromFile("karo.jpg");
                                    pb_lapszin42.Image = Image.FromFile("karo.jpg");
                                    break;
                            }
                            if (lapertek > 10)
                            {
                                switch (lapertek)
                                {
                                    case 11:
                                        lbl_lapert41.Text = "J";
                                        lbl_lapert42.Text = "J";
                                        break;
                                    case 12:
                                        lbl_lapert41.Text = "Q";
                                        lbl_lapert42.Text = "Q";
                                        break;
                                    case 13:
                                        lbl_lapert41.Text = "K";
                                        lbl_lapert42.Text = "K";
                                        break;
                                }
                            }
                            else
                            {
                                if (lapertek == 1)
                                {
                                    lbl_lapert41.Text = "A";
                                    lbl_lapert42.Text = "A";
                                }
                                else
                                {
                                    lbl_lapert41.Text = lapertek.ToString();
                                    lbl_lapert42.Text = lapertek.ToString();
                                }
                            }
                            if (veszítt == true)
                            {
                                MessageBox.Show("Vesztettél");
                                alaphelyzet();
                            }
                            if (db == 3)
                            {
                                lapertek = rnd.Next(1, 14);
                                szin = rnd.Next(1, 5);
                                lapkeresert();
                                pnl_lap16.BackColor = Color.White;
                                pnl_lap16.BorderStyle = BorderStyle.FixedSingle;
                                lbl_playerert.Text = userert.ToString();
                                switch (szin)
                                {
                                    case 1:
                                        pb_lapszin43.Image = Image.FromFile("pikk.jpg");
                                        pb_lapszin44.Image = Image.FromFile("pikk.jpg");
                                        break;
                                    case 2:
                                        pb_lapszin43.Image = Image.FromFile("kor.jpg");
                                        pb_lapszin44.Image = Image.FromFile("kor.jpg");
                                        break;
                                    case 3:
                                        pb_lapszin43.Image = Image.FromFile("treff.jpg");
                                        pb_lapszin44.Image = Image.FromFile("treff.jpg");
                                        break;
                                    case 4:
                                        pb_lapszin43.Image = Image.FromFile("karo.jpg");
                                        pb_lapszin44.Image = Image.FromFile("karo.jpg");
                                        break;
                                }
                                if (lapertek > 10)
                                {
                                    switch (lapertek)
                                    {
                                        case 11:
                                            lbl_lapert43.Text = "J";
                                            lbl_lapert44.Text = "J";
                                            break;
                                        case 12:
                                            lbl_lapert43.Text = "Q";
                                            lbl_lapert44.Text = "Q";
                                            break;
                                        case 13:
                                            lbl_lapert43.Text = "K";
                                            lbl_lapert44.Text = "K";
                                            break;
                                    }
                                }
                                else
                                {
                                    if (lapertek == 1)
                                    {
                                        lbl_lapert43.Text = "A";
                                        lbl_lapert44.Text = "A";
                                    }
                                    else
                                    {
                                        lbl_lapert43.Text = lapertek.ToString();
                                        lbl_lapert44.Text = lapertek.ToString();
                                    }
                                }
                                if (veszítt == true)
                                {
                                    MessageBox.Show("Vesztettél");
                                    alaphelyzet();
                                }
                                if (db == 4)
                                {
                                    lapertek = rnd.Next(1, 14);
                                    szin = rnd.Next(1, 5);
                                    lapkeresert();
                                    pnl_lap17.BackColor = Color.White;
                                    pnl_lap17.BorderStyle = BorderStyle.FixedSingle;
                                    lbl_playerert.Text = userert.ToString();
                                    switch (szin)
                                    {
                                        case 1:
                                            pb_lapszin45.Image = Image.FromFile("pikk.jpg");
                                            pb_lapszin46.Image = Image.FromFile("pikk.jpg");
                                            break;
                                        case 2:
                                            pb_lapszin45.Image = Image.FromFile("kor.jpg");
                                            pb_lapszin46.Image = Image.FromFile("kor.jpg");
                                            break;
                                        case 3:
                                            pb_lapszin45.Image = Image.FromFile("treff.jpg");
                                            pb_lapszin46.Image = Image.FromFile("treff.jpg");
                                            break;
                                        case 4:
                                            pb_lapszin45.Image = Image.FromFile("karo.jpg");
                                            pb_lapszin46.Image = Image.FromFile("karo.jpg");
                                            break;
                                    }
                                    if (lapertek > 10)
                                    {
                                        switch (lapertek)
                                        {
                                            case 11:
                                                lbl_lapert45.Text = "J";
                                                lbl_lapert46.Text = "J";
                                                break;
                                            case 12:
                                                lbl_lapert45.Text = "Q";
                                                lbl_lapert46.Text = "Q";
                                                break;
                                            case 13:
                                                lbl_lapert45.Text = "K";
                                                lbl_lapert46.Text = "K";
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        if (lapertek == 1)
                                        {
                                            lbl_lapert45.Text = "A";
                                            lbl_lapert46.Text = "A";
                                        }
                                        else
                                        {
                                            lbl_lapert45.Text = lapertek.ToString();
                                            lbl_lapert46.Text = lapertek.ToString();
                                        }
                                    }
                                    if (veszítt == true)
                                    {
                                        MessageBox.Show("Vesztettél");
                                        alaphelyzet();
                                    }
                                    if (db == 5)
                                    {
                                        lapertek = rnd.Next(1, 14);
                                        szin = rnd.Next(1, 5);
                                        lapkeresert();
                                        pnl_lap18.BackColor = Color.White;
                                        pnl_lap18.BorderStyle = BorderStyle.FixedSingle;
                                        lbl_playerert.Text = userert.ToString();
                                        switch (szin)
                                        {
                                            case 1:
                                                pb_lapszin47.Image = Image.FromFile("pikk.jpg");
                                                pb_lapszin48.Image = Image.FromFile("pikk.jpg");
                                                break;
                                            case 2:
                                                pb_lapszin47.Image = Image.FromFile("kor.jpg");
                                                pb_lapszin48.Image = Image.FromFile("kor.jpg");
                                                break;
                                            case 3:
                                                pb_lapszin47.Image = Image.FromFile("treff.jpg");
                                                pb_lapszin48.Image = Image.FromFile("treff.jpg");
                                                break;
                                            case 4:
                                                pb_lapszin47.Image = Image.FromFile("karo.jpg");
                                                pb_lapszin48.Image = Image.FromFile("karo.jpg");
                                                break;
                                        }
                                        if (lapertek > 10)
                                        {
                                            switch (lapertek)
                                            {
                                                case 11:
                                                    lbl_lapert47.Text = "J";
                                                    lbl_lapert48.Text = "J";
                                                    break;
                                                case 12:
                                                    lbl_lapert47.Text = "Q";
                                                    lbl_lapert48.Text = "Q";
                                                    break;
                                                case 13:
                                                    lbl_lapert47.Text = "K";
                                                    lbl_lapert48.Text = "K";
                                                    break;
                                            }
                                        }
                                        else
                                        {
                                            if (lapertek == 1)
                                            {
                                                lbl_lapert47.Text = "A";
                                                lbl_lapert48.Text = "A";
                                            }
                                            else
                                            {
                                                lbl_lapert47.Text = lapertek.ToString();
                                                lbl_lapert48.Text = lapertek.ToString();
                                            }
                                        }
                                        if (veszítt == true)
                                        {
                                            MessageBox.Show("Vesztettél");
                                            alaphelyzet();
                                        }
                                    }
                                    db++;
                                }
                                db++;
                            }
                            db++;
                        }
                        db++;
                    }
                    db++;
                }                
            }
        }

        private void btn_ismetles_Click(object sender, EventArgs e)
        {
            string gomb = btn_ismetles.Text;
            if (gomb == "Ismétlés")
            {
                if (zseton != 0 && zseton >= elozo)
                {
                    zseton = zseton - elozo;
                    jatekban = elozo;
                    lbl_zsetonod.Text = zseton.ToString();
                    sb_egyeni.Visible = false;
                    btn_betesz.Visible = false;
                    btn_ismetles.Enabled = true;
                    Osztás();                   
                    btn_min.Enabled = false;
                    lbl_playerert.Text = userert.ToString();
                    if (btn_1.Visible == true)
                    {
                        btn_min.Enabled = false;
                        btn_ismetles.Enabled = false;
                        btn_max.Enabled = false;
                        btn_egyeni.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Elfogyott a pénzed vagy nincs elég zsetonod");
                }
            }
            else if(gomb == "Duplázás")
            {
                zseton = zseton - jatekban;
                lbl_zsetonod.Text = zseton.ToString();
                jatekban = jatekban * 2;
                lapertek = rnd.Next(1, 14);
                szin = rnd.Next(1, 5);
                lapkeresert();
                pnl_lap13.BackColor = Color.White;
                pnl_lap13.BorderStyle = BorderStyle.FixedSingle;
                lbl_playerert.Text = userert.ToString();
                switch (szin)
                {
                    case 1:
                        pb_lapszin37.Image = Image.FromFile("pikk.jpg");
                        pb_lapszin38.Image = Image.FromFile("pikk.jpg");
                        break;
                    case 2:
                        pb_lapszin37.Image = Image.FromFile("kor.jpg");
                        pb_lapszin38.Image = Image.FromFile("kor.jpg");
                        break;
                    case 3:
                        pb_lapszin37.Image = Image.FromFile("treff.jpg");
                        pb_lapszin38.Image = Image.FromFile("treff.jpg");
                        break;
                    case 4:
                        pb_lapszin37.Image = Image.FromFile("karo.jpg");
                        pb_lapszin38.Image = Image.FromFile("karo.jpg");
                        break;
                }
                if (lapertek > 10)
                {
                    switch (lapertek)
                    {
                        case 11:
                            lbl_lapert37.Text = "J";
                            lbl_lapert38.Text = "J";
                            break;
                        case 12:
                            lbl_lapert37.Text = "Q";
                            lbl_lapert38.Text = "Q";
                            break;
                        case 13:
                            lbl_lapert37.Text = "K";
                            lbl_lapert38.Text = "K";
                            break;
                    }
                }
                else
                {
                    if (lapertek == 1)
                    {
                        lbl_lapert37.Text = "A";
                        lbl_lapert38.Text = "A";
                    }
                    else
                    {
                        lbl_lapert37.Text = lapertek.ToString();
                        lbl_lapert38.Text = lapertek.ToString();
                    }
                }
                if (veszítt == true)
                {
                    MessageBox.Show("Vesztettél");
                    alaphelyzet();
                }
                else
                {
                    bank();
                }               
            }
        }

        private void btn_csere_Click(object sender, EventArgs e)
        {
            int kod2 = int.Parse(tb_emailkod.Text);
            string jel = tb_csejelszo.Text;
            string jel2 = tb_csejelszoujra.Text;
            if (kod == kod2 && jel == jel2)
            {
                foreach (var item in User)
                {
                    if (tb_emailkod.Text == item.Email || tb_emailkod.Text == item.Felhasznalonev)
                    {
                        item.Jelszo = jel2;
                        string felhasznalokiir = "Felhasználó.txt";
                        if (File.Exists(felhasznalokiir) == true) File.Delete(felhasznalokiir);
                        StreamWriter stream = File.CreateText(felhasznalokiir);
                        foreach (var elem in User)
                        {
                            stream.WriteLine($"{elem.Felhasznalonev};{elem.Jelszo};{elem.Zseton};{elem.Kartyaszam};{elem.Lejarat};{elem.Cvc};{elem.Egyenleg};{elem.Email}");
                        }
                        stream.Close();
                        pnl_jelszocsere.Visible = false;
                        pnl_kapkod.Visible = false;
                        pnl_jelszocsere.Location = new Point(755, 12);
                        pnl_kapkod.Location = new Point(840, 303);
                        pnl_belepes.Location = new Point(699, 343);
                        pnl_belepes.Visible = true;
                    }
                }
            }
        }

        private void btn_zsetonvesz_Click(object sender, EventArgs e)
        {
            pnl_jatek.SendToBack();
            pnl_zsetonvesz.Visible = true;
            pnl_zsetonvesz.Location = new Point(421, 337);
            pnl_iranypult.Enabled = false;
            btn_kilepes.Enabled = false;
            btn_zsetonvesz.Enabled = false;
            btn_betesz.Enabled = false;
            sb_egyeni.Enabled = false;
        }

        private void rb_1000_CheckedChanged(object sender, EventArgs e)
        {
            int db = 1;
            if (db == 1)
            {
                btn_megvesz.Enabled = true;
                db = 0;
            }
            else if (db == 0)
            {
                btn_megvesz.Enabled = false;
                db = 1;
            }
                        
        }

        private void rb_5000_CheckedChanged(object sender, EventArgs e)
        {
            int db = 1;
            if (db == 1)
            {
                btn_megvesz.Enabled = true;
                db = 0;
            }
            else if (db == 0)
            {
                btn_megvesz.Enabled = false;
                db = 1;
            }
        }

        private void rb_10000_CheckedChanged(object sender, EventArgs e)
        {
            int db = 1;
            if (db == 1)
            {
                btn_megvesz.Enabled = true;
                db = 0;
            }
            else if (db == 0)
            {
                btn_megvesz.Enabled = false;
                db = 1;
            }
        }

        private void rb_100000_CheckedChanged(object sender, EventArgs e)
        {
            int db = 1;
            if (db == 1)
            {
                btn_megvesz.Enabled = true;
                db = 0;
            }
            else if (db == 0)
            {
                btn_megvesz.Enabled = false;
                db = 1;
            }
        }

        private void btn_megvesz_Click(object sender, EventArgs e)
        {
            if (rb_1000.Checked == true || rb_5000.Checked == true || rb_10000.Checked == true || rb_100000.Checked == true)
            {
                if (rb_1000.Checked == true)
                {
                    if (egyenleg >= 900 && zseton<1000000)
                    {
                        zseton = zseton + 1000;
                        egyenleg = egyenleg - 900;
                        lbl_egyenlegem.Text = egyenleg.ToString();
                        lbl_zsetonmennyiseg.Text = zseton.ToString();
                        lbl_zsetonod.Text = zseton.ToString();
                    }
                }
                else if (rb_5000.Checked == true)
                {
                    if (egyenleg >= 4400 && zseton < 1000000)
                    {
                        zseton = zseton + 5000;
                        egyenleg = egyenleg - 4400;
                        lbl_egyenlegem.Text = egyenleg.ToString();
                        lbl_zsetonmennyiseg.Text = zseton.ToString();
                        lbl_zsetonod.Text = zseton.ToString();
                    }
                }
                else if(rb_10000.Checked==true)
                {
                    if (egyenleg >= 8300 && zseton < 1000000)
                    {
                        zseton = zseton + 10000;
                        egyenleg = egyenleg - 8300;
                        lbl_egyenlegem.Text = egyenleg.ToString();
                        lbl_zsetonmennyiseg.Text = zseton.ToString();
                        lbl_zsetonod.Text = zseton.ToString();
                    }
                }
                else
                {
                    if (egyenleg >= 36000 && zseton < 1000000)
                    {
                        zseton = zseton + 100000;
                        egyenleg = egyenleg - 36000;
                        lbl_egyenlegem.Text = egyenleg.ToString();
                        lbl_zsetonmennyiseg.Text = zseton.ToString();
                        lbl_zsetonod.Text = zseton.ToString();
                    }
                }
                pnl_zsetonvesz.Visible = false;
                pnl_jatek.BringToFront();
                pnl_zsetonvesz.Location = new Point(14, 490);                
                pnl_iranypult.Enabled = true;
                btn_kilepes.Enabled = true;
                btn_zsetonvesz.Enabled = true;
                btn_betesz.Enabled = true;
                sb_egyeni.Enabled = true;
            }
        }

        private void btn_zsevissza_Click(object sender, EventArgs e)
        {
            pnl_zsetonvesz.Visible = false;
            pnl_jatek.BringToFront();
            pnl_zsetonvesz.Location = new Point(14, 490);
            pnl_iranypult.Enabled = true;
            btn_kilepes.Enabled = true;
            btn_zsetonvesz.Enabled = true;
            btn_betesz.Enabled = true;
            sb_egyeni.Enabled = true;
        }

        private void btn_egyenlegtolt_Click(object sender, EventArgs e)
        {
            pnl_egyenlegtolt.Location = new Point(699, 421);
            pnl_egyenlegtolt.BringToFront();
            pnl_egyenlegtolt.Visible = true;
            pnl_jatek.Enabled = false;
            pnl_zsetonvesz.Enabled = false;
        }

        private void btn_egyvissza_Click(object sender, EventArgs e)
        {
            pnl_egyenlegtolt.Location = new Point(12, 312);
            pnl_egyenlegtolt.SendToBack();
            pnl_egyenlegtolt.Visible = false;
            pnl_jatek.Enabled = true;
            pnl_zsetonvesz.Enabled = true;
        }

        private void btn_toltes_Click(object sender, EventArgs e)
        {
            string teszt = "0000-0000-0000-0000";
            string teszt2 = "00/00";
            int teszt3 = 000;
            foreach(var item in User)
            {
                if (egyenleg < 1000000 && username == item.Felhasznalonev && item.Kartyaszam != teszt && item.Lejarat != teszt2 && item.Cvc != teszt3) 
                {
                    
                }
                else
                {
                    MessageBox.Show("Túl sok zseotnja van \n vagy nincs megadva a kártyád");
                    pnl_bankkartya.Location = new Point(962, 254);
                    pnl_bankkartya.BringToFront();
                    pnl_bankkartya.Visible = true;
                    uto = true;
                }
            }
        }

        private void btn_kilepes_Click(object sender, EventArgs e)
        {
            pnl_jatek.Visible = false;
            pnl_jatek.SendToBack();
            pnl_belepes.Location = new Point(699, 343);
            pnl_belepes.Visible = true;
            string felhasznalokiir = "Felhasználó.txt";
            if (File.Exists(felhasznalokiir) == true) File.Delete(felhasznalokiir);
            StreamWriter stream = File.CreateText(felhasznalokiir);
            foreach (var elem in User)
            {
                stream.WriteLine($"{elem.Felhasznalonev};{elem.Jelszo};{elem.Zseton};{elem.Kartyaszam};{elem.Lejarat};{elem.Cvc};{elem.Egyenleg};{elem.Email}");
            }
            stream.Close();
        }

        private void rb_100000_CheckedChanged_1(object sender, EventArgs e)
        {
            int db = 1;
            if (db == 1)
            {
                btn_megvesz.Enabled = true;
                db = 0;
            }
            else if (db == 0)
            {
                btn_megvesz.Enabled = false;
                db = 1;
            }
        }

        private void rb_10000_CheckedChanged_1(object sender, EventArgs e)
        {
            int db = 1;
            if (db == 1)
            {
                btn_megvesz.Enabled = true;
                db = 0;
            }
            else if (db == 0)
            {
                btn_megvesz.Enabled = false;
                db = 1;
            }
        }

        private void rb_5000_CheckedChanged_1(object sender, EventArgs e)
        {
            int db = 1;
            if (db == 1)
            {
                btn_megvesz.Enabled = true;
                db = 0;
            }
            else if (db == 0)
            {
                btn_megvesz.Enabled = false;
                db = 1;
            }
        }
    }
}
