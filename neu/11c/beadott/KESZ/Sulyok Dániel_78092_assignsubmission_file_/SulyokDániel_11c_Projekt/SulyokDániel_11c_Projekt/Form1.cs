﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SulyokDániel_11c_Projekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //INTEK
        int konyvekdarab = 0;
        int filmekdarab = 0;

        //FILM RADIO BUTTON

        private void RB_film_CheckedChanged(object sender, EventArgs e)
        {

            //HA KIVAN JELÖLVE JELENÍTSE MEG EZEKET

            if (RB_film.Checked)
            {
                GBfilm.Visible = true;
                GBfilmeskonyv.Visible = true;
                CBtitanic.Visible = true;
                CBgyurukura.Visible = true;
                CBhobbit.Visible = true;
                CBfrozen.Visible = true;
                CBjamesbond.Visible = true;
                CBalkonyat.Visible = true;
                CBehezokviadala.Visible = true;
                CBvasember.Visible = true;
            }
            else
            {
                //HA NINCS KIJELÖLVE, TÜNTESSE EL EZEKET

                GBfilm.Visible = false;
                GBfilmeskonyv.Visible = false;
                CBtitanic.Visible = false;
                CBgyurukura.Visible = false;
                CBhobbit.Visible = false;
                CBfrozen.Visible = false;
                CBjamesbond.Visible = false;
                CBalkonyat.Visible = false;
                CBehezokviadala.Visible = false;
                CBvasember.Visible = false;

                //HA NINCS KIJELÖLVE, AKKOR TÜNTESSE EL HOGY BEVANNAK JELÖLVE AZ ALÁBBI CHECKBOXOK

                CBtitanic.Checked = false;
                CBgyurukura.Checked = false;
                CBhobbit.Checked = false;
                CBalkonyat.Checked = false;
                CBjamesbond.Checked = false;
                CBehezokviadala.Checked = false;
                CBvasember.Checked = false;
                CBfrozen.Checked = false;
            }
        }

        //HASONLÓ  AZ  RB_FILM-HEZ ÍGY REJTVE VAN

        private void RB_konyv_CheckedChanged(object sender, EventArgs e)
        {
            //HA KIVAN JELÖLVE JELENÍTSE MEG EZEKET

            if (RB_konyv.Checked)
            {
                GBkonyv.Visible = true;
                GBfilmeskonyv.Visible = true;
                CBfrozen.Visible = true;
                CBharrypotter.Visible = true;
                CBjamesbond.Visible = true;
                CBpercyjackson.Visible = true;
                CBbeavatott.Visible = true;
                CBehezokviadala.Visible = true;
                CBvasember.Visible = true;
                CBszamkivetett.Visible = true;
            }
            else
            {
                //HA NINCS KIJELÖLVE, TÜNTESSE EL EZEKET

                GBkonyv.Visible = false;
                GBfilmeskonyv.Visible = false;
                CBfrozen.Visible = false;
                CBharrypotter.Visible = false;
                CBjamesbond.Visible = false;
                CBpercyjackson.Visible = false;
                CBbeavatott.Visible = false;
                CBehezokviadala.Visible = false;
                CBvasember.Visible = false;
                CBszamkivetett.Visible = false;

                //HA NINCS KIJELÖLVE, AKKOR TÜNTESSE EL HOGY BEVANNAK JELÖLVE AZ ALÁBBI CHECKBOXOK

                CBharrypotter.Checked = false;
                CBszamkivetett.Checked = false;
                CBpercyjackson.Checked = false;
                CBbeavatott.Checked = false;
                CBjamesbond.Checked = false;
                CBehezokviadala.Checked = false;
                CBvasember.Checked = false;
                CBfrozen.Checked = false;
            }
        }

        //FILMEK

        private void CBtitanic_CheckedChanged(object sender, EventArgs e)
        {
            //HA KIJELÖLVE VANNAK A CHECKBOXOK, AKKOR TÖRNÉNJENEK AZ ALÁBBIAK.

            if (CBtitanic.Checked)
            {
                listBox1.Items.Add(" 1 film : Titanic ; ár: " + Filmek.filmertek.ToString() + "ft");
                
                //A FILMEK CLASSBAN ELŐÁLÍTOTT INT-ET HASZNÁLTAM, HOGY NE MINDEN EGYES CHECKBOXNAK KELLJEN ÁTÍRNI AZ ÉRTÉKET EGYENKÉNT, HANEM ELÉG LEGYEN A CLASS-BAN TALÁLTAT CSAK, UGYAN EZ VAN A KÖNYVEKNÉL IS.
                
                filmekdarab++;

                //A PROGRAM MÁSODIK FELÉNEK A LÁTHATÓVÁ TEVÉSE

                LBvasarlasilista.Visible = true;
                listBox1.Visible = true;
                BTvasarlas.Visible = true;
            }
        }

        //HASONLÓAK A TÖBBIHEZ, ÍGY ELREJTETTEM HOGY ÁTLÁTHATOBB LEGYEN

        private void CBgyurukura_CheckedChanged(object sender, EventArgs e)
        {
            if (CBgyurukura.Checked)
            {
                listBox1.Items.Add(" 1 film : Gyűrűk ura ; ár: " + Filmek.filmertek.ToString() + "ft");
                filmekdarab++;

                //A PROGRAM MÁSODIK FELÉNEK A LÁTHATÓVÁ TEVÉSE

                LBvasarlasilista.Visible = true;
                listBox1.Visible = true;
                BTvasarlas.Visible = true;
            }
        }

        private void CBhobbit_CheckedChanged(object sender, EventArgs e)
        {
            if (CBhobbit.Checked)
            {
                listBox1.Items.Add(" 1 film : Hobbit ; ár: " + Filmek.filmertek.ToString() + "ft");
                filmekdarab++;

                //A PROGRAM MÁSODIK FELÉNEK A LÁTHATÓVÁ TEVÉSE

                LBvasarlasilista.Visible = true;
                listBox1.Visible = true;
                BTvasarlas.Visible = true;
            }
        }

        private void CBalkonyat_CheckedChanged(object sender, EventArgs e)
        {
            if (CBalkonyat.Checked)
            {
                listBox1.Items.Add(" 1 film : Alkonyat ; ár: " + Filmek.filmertek.ToString() + "ft");
                filmekdarab++;

                //A PROGRAM MÁSODIK FELÉNEK A LÁTHATÓVÁ TEVÉSE

                LBvasarlasilista.Visible = true;
                listBox1.Visible = true;
                BTvasarlas.Visible = true;
            }
        }

        //KÖNYVEK

        //EGYENLŐRE ITTIS A FILMEKNÉL HASZNÁLT MÓDSZER VAN
        private void CBharrypotter_CheckedChanged(object sender, EventArgs e)
        {
            if (CBharrypotter.Checked)
            {
                listBox1.Items.Add(" 1 Könyv : Harry Potter ; ár: " + Konyvek.konyvertek.ToString() + "ft");
                konyvekdarab++;

                //A PROGRAM MÁSODIK FELÉNEK A LÁTHATÓVÁ TEVÉSE

                LBvasarlasilista.Visible = true;
                listBox1.Visible = true;
                BTvasarlas.Visible = true;
            }
        }

        private void CBszamkivetett_CheckedChanged(object sender, EventArgs e)
        {
            if (CBszamkivetett.Checked)
            {
                listBox1.Items.Add(" 1 Könyv : Számkivetett ; ár: " + Konyvek.konyvertek.ToString() + "ft");
                konyvekdarab++;

                //A PROGRAM MÁSODIK FELÉNEK A LÁTHATÓVÁ TEVÉSE

                LBvasarlasilista.Visible = true;
                listBox1.Visible = true;
                BTvasarlas.Visible = true;
            }
        }

        private void CBpercyjackson_CheckedChanged(object sender, EventArgs e)
        {
            if (CBpercyjackson.Checked)
            {
                listBox1.Items.Add(" 1 Könyv : Percy Jackson ; ár: " + Konyvek.konyvertek.ToString() + "ft");
                konyvekdarab++;

                //A PROGRAM MÁSODIK FELÉNEK A LÁTHATÓVÁ TEVÉSE

                LBvasarlasilista.Visible = true;
                listBox1.Visible = true;
                BTvasarlas.Visible = true;
            }
        }

        private void CBbeavatott_CheckedChanged(object sender, EventArgs e)
        {
            if (CBbeavatott.Checked)
            {
                listBox1.Items.Add(" 1 Könyv : Beavatott ; ár: " + Konyvek.konyvertek.ToString() + "ft");
                konyvekdarab++;

                //A PROGRAM MÁSODIK FELÉNEK A LÁTHATÓVÁ TEVÉSE

                LBvasarlasilista.Visible = true;
                listBox1.Visible = true;
                BTvasarlas.Visible = true;
            }
        }

        //FILMEK ÉS KÖNYVEK

        //ITT, EGY FELTÉTELBEN MEGÍRTAM HHOGY AHHOZ AZ ÉRTÉKHEZ ADJA HOZZÁ A DARBOT, AMELYIK FAJTA RADIO BUTTON MEGVAN JELÖLVE, HOGY TUDJUK FILM, VAGY KÖNYVET SZERETNÉNK.

        private void CBjamesbond_CheckedChanged(object sender, EventArgs e)
        {
            if (CBjamesbond.Checked && RB_film.Checked)
            {
                if (CBjamesbond.Checked)
                {
                    listBox1.Items.Add(" 1 film : James Bond ; ár: " + Filmek.filmertek.ToString() + "ft");
                    filmekdarab++;

                    //A PROGRAM MÁSODIK FELÉNEK A LÁTHATÓVÁ TEVÉSE

                    LBvasarlasilista.Visible = true;
                    listBox1.Visible = true;
                    BTvasarlas.Visible = true;
                }
            }
            else if (CBjamesbond.Checked && RB_konyv.Checked)
            {
                listBox1.Items.Add(" 1 könyv : James Bond ; ár: " + Konyvek.konyvertek.ToString() + "ft");
                konyvekdarab++;

                LBvasarlasilista.Visible = true;
                listBox1.Visible = true;
                BTvasarlas.Visible = true;
            }
        }

        //AZ ALÁBBI SOROKBAN HASONLÓ AZ ELJÁRÁS, ÍGY ITT IS ELVANNAK REJTVE

        private void CBehezokviadala_CheckedChanged(object sender, EventArgs e)
        {
            if (CBehezokviadala.Checked && RB_film.Checked)
            {
                if (CBehezokviadala.Checked)
                {
                    listBox1.Items.Add(" 1 film : Éhezők viadala ; ár: " + Filmek.filmertek.ToString() + "ft");
                    filmekdarab++;

                    //A PROGRAM MÁSODIK FELÉNEK A LÁTHATÓVÁ TEVÉSE

                    LBvasarlasilista.Visible = true;
                    listBox1.Visible = true;
                    BTvasarlas.Visible = true;
                }
            }
            else if (CBehezokviadala.Checked && RB_konyv.Checked)
            {
                listBox1.Items.Add(" 1 könyv : Éhezők viadala ; ár: " + Konyvek.konyvertek.ToString() + "ft");
                konyvekdarab++;

                LBvasarlasilista.Visible = true;
                listBox1.Visible = true;
                BTvasarlas.Visible = true;
            }
        }

        private void CBvasember_CheckedChanged(object sender, EventArgs e)
        {
            if (CBvasember.Checked && RB_film.Checked)
            {
                if (CBvasember.Checked)
                {
                    listBox1.Items.Add(" 1 film : Vasember ; ár: " + Filmek.filmertek.ToString() + "ft");
                    filmekdarab++;

                    //A PROGRAM MÁSODIK FELÉNEK A LÁTHATÓVÁ TEVÉSE

                    LBvasarlasilista.Visible = true;
                    listBox1.Visible = true;
                    BTvasarlas.Visible = true;
                }
            }
            else if (CBvasember.Checked && RB_konyv.Checked)
            {
                listBox1.Items.Add(" 1 könyv : Vasember ; ár: " + Konyvek.konyvertek.ToString() + "ft");
                konyvekdarab++;

                LBvasarlasilista.Visible = true;
                listBox1.Visible = true;
                BTvasarlas.Visible = true;
            }
        }

        private void CBfrozen_CheckedChanged(object sender, EventArgs e)
        {
            if (CBfrozen.Checked && RB_film.Checked)
            {
                if (CBfrozen.Checked)
                {
                    listBox1.Items.Add(" 1 film : Éhezők viadala ; ár: " + Filmek.filmertek.ToString() + "ft");
                    filmekdarab++;

                    //A PROGRAM MÁSODIK FELÉNEK A LÁTHATÓVÁ TEVÉSE

                    LBvasarlasilista.Visible = true;
                    listBox1.Visible = true;
                    BTvasarlas.Visible = true;
                }
            }
            else if (CBfrozen.Checked && RB_konyv.Checked)
            {
                listBox1.Items.Add(" 1 könyv : Éhezők viadala ; ár: " + Konyvek.konyvertek.ToString() + "ft");
                konyvekdarab++;

                LBvasarlasilista.Visible = true;
                listBox1.Visible = true;
                BTvasarlas.Visible = true;
            }
        }

        //VÁSÁRLÁS GOMB


        private void BTvasarlas_Click(object sender, EventArgs e)
        {
            //INTEK

            int darab = konyvekdarab + filmekdarab;
            int osszesar = konyvekdarab * Konyvek.konyvertek + filmekdarab * Filmek.filmertek;


            //LÁTHATÓVÁ TEVÉS

            BTszamla.Visible = true;
            LBszamla.Visible = true;
            LBszamlakiiras.Visible = true;
            LBosszesertek.Visible = true;
            LBszamlaosszesitettertek.Visible = true;
            LBosszesaru.Visible = true;

            //LABEL-EK ÁTÍRÁSA
            LBosszesaru.Text = "Termékek darabszáma: " + darab.ToString();
            LBszamlaosszesitettertek.Text = osszesar.ToString() + " ft";

            //LISTBOX-BA ÍRÁS

            DateTime ido = DateTime.Now;
            listBox1.Items.Add("");
            listBox1.Items.Add("############################");
            listBox1.Items.Add("");
            listBox1.Items.Add("Számla: ");
            listBox1.Items.Add("");
            listBox1.Items.Add(ido.ToString());
            listBox1.Items.Add(LBosszesaru.Text = "Termékek darabszáma: " + darab.ToString());
            listBox1.Items.Add(LBszamlaosszesitettertek.Text = "Összeg: " + osszesar.ToString() + " ft");
            LBszamlakiiras.Text = ido.ToString();
            listBox1.Items.Add("");
            listBox1.Items.Add("############################");
        }

        //KIÍRÁS EGY MAGUNK ÁLLTAL MEGADOTT KÖNYVTÁRBA, EGYSZERÜBB SZERINTEM MINTHOGYHAMINDIG A BIN-BE MENTENÉ LE, AHOGY RÉGEBBEN TANULTUK

        private void BTszamla_Click(object sender, EventArgs e)
        {
            //KIÍRÁS
            SaveFileDialog szamla = new SaveFileDialog();
            if (szamla.ShowDialog() == DialogResult.OK)
            {
                StreamWriter kiiras = new StreamWriter(szamla.FileName);
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    kiiras.WriteLine((string)listBox1.Items[i]);
                }
                kiiras.Close();
            }
            szamla.Dispose();
        }
    }
}

       

