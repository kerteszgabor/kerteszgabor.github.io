using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VorosCsanad_projekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl_focim.Visible = false;
            btn_belepes.Visible = false;
            btn_emlos.Visible = true;
            btn_hullok.Visible = true;
            lbl_kerd.Visible = true;
            gb_emlos.Visible = true;
            gb_hullo.Visible = true;
        }

        private void btn_emlos_Click(object sender, EventArgs e)
        {
            gb_emlos.Enabled = true;
            gb_hullo.Enabled = false;
        }

        private void btn_hullok_Click(object sender, EventArgs e)
        {
            gb_emlos.Enabled = false;
            gb_hullo.Enabled = true;
        }

        private void rdbtn_panda_CheckedChanged(object sender, EventArgs e)
        {
            Allatok panda = new Allatok("Emlős", "Panda", "Kína", 1864);
            lbl_szoveg.Text = ($"A {panda.nev} egy {panda.osztaly} állat, amely {panda.elohely} területén él, 2014-ben ismert példányszáma {panda.peldany} volt, ezért védett állatfaj.");
            pb_kep.Visible = true;
            lbl_szoveg.Visible = true;
            pb_kep.Image = Image.FromFile("../Debug/panda.jpg");
        }

        private void rdbtn_tigris_CheckedChanged(object sender, EventArgs e)
        {
            Allatok tigris = new Allatok("Emlős", "Tigris", "Kína, India", 4000);
            lbl_szoveg.Text = ($"A {tigris.nev} egy {tigris.osztaly} állat, amely legfőként {tigris.elohely} területén él, mára már kevesebb mint {tigris.peldany} van a vadonban.");
            pb_kep.Visible = true;
            lbl_szoveg.Visible = true;
            pb_kep.Image = Image.FromFile("../Debug/tigris.jpg");
        }

        private void rdbtn_oroszlan_CheckedChanged(object sender, EventArgs e)
        {
            Allatok oroszlan = new Allatok("Emlős", "Oroszlán", "Fekete-Afrika", 20000);
            lbl_szoveg.Text = ($"Az {oroszlan.nev} egy {oroszlan.osztaly} állat, amely legfőként {oroszlan.elohely}-ban él, napjainkban körülbelül {oroszlan.peldany} van a vadonban.");
            pb_kep.Visible = true;
            lbl_szoveg.Visible = true;
            pb_kep.Image = Image.FromFile("../Debug/oroszlan.jpg");
        }

        private void rdbtn_kecske_CheckedChanged(object sender, EventArgs e)
        {

            Allatok kecske = new Allatok("Emlős", "Kecske", "a világ bármely részén", 914000000);
            lbl_szoveg.Text = ($"A {kecske.nev} egy {kecske.osztaly} állat, amely {kecske.elohely} megtalálható, 2011-ben több mint {kecske.peldany} volt a világon.");
            pb_kep.Visible = true;
            lbl_szoveg.Visible = true;
            pb_kep.Image = Image.FromFile("../Debug/kecske.jpg");
        }

        private void rdbtn_nyul_CheckedChanged(object sender, EventArgs e)
        {

            Allatok nyul = new Allatok("Emlős", "Nyúl", "a világ bármely részén", 14000000);
            lbl_szoveg.Text = ($"A {nyul.nev} egy {nyul.osztaly} állat, amely {nyul.elohely} látható, napjainkban körülbelül {nyul.peldany} van a világon.");
            pb_kep.Visible = true;
            lbl_szoveg.Visible = true;
            pb_kep.Image = Image.FromFile("../Debug/nyul.jpg");
        }

        private void rdbtn_zsiraf_CheckedChanged(object sender, EventArgs e)
        {

            Allatok zsiraf = new Allatok("Emlős", "Zsiráf", "Afrika", 35000);
            lbl_szoveg.Text = ($"A {zsiraf.nev} egy {zsiraf.osztaly} állat, amely legfőként {zsiraf.elohely} területén él, napjainkban körülbelül {zsiraf.peldany} van a vadonban.");
            pb_kep.Visible = true;
            lbl_szoveg.Visible = true;
            pb_kep.Image = Image.FromFile("../Debug/zsiraf.jpg");
        }

        private void rdbtn_orrszarvu_CheckedChanged(object sender, EventArgs e)
        {

            Allatok orrszarvu = new Allatok("Emlős", "Orrszarvú", "Afrika vagy Ázsia", 3600);
            lbl_szoveg.Text = ($"Az {orrszarvu.nev} egy {orrszarvu.osztaly} állat, amely legfőként {orrszarvu.elohely} területén lelhető fel, napjainkban körülbelül{orrszarvu.peldany} van a vadonban.");
            pb_kep.Visible = true;
            lbl_szoveg.Visible = true;
            pb_kep.Image = Image.FromFile("../Debug/orrszarvu.jpg");
        }

        private void rdbtn_majom_CheckedChanged(object sender, EventArgs e)
        {
            Allatok majom = new Allatok("Emlős", "Majom", "Afrika, Közép-Amerika", 1000);
            lbl_szoveg.Text = ($"A {majom.nev} egy {majom.osztaly} állat, amely {majom.elohely} területén él, napjainkban körülbelül {majom.peldany} van a vadonban.");
            pb_kep.Visible = true;
            lbl_szoveg.Visible = true;
            pb_kep.Image = Image.FromFile("../Debug/majom.jpg");
        }

        private void rdbtn_gorilla_CheckedChanged(object sender, EventArgs e)
        {

            Allatok gorilla = new Allatok("Emlős", "Gorilla", "Rwanda, Uganda", 300);
            lbl_szoveg.Text = ($"A {gorilla.nev} egy {gorilla.osztaly} állat, amely legfőként {gorilla.elohely} területén él, napjainkban csupán {gorilla.peldany} van a vadonban.");
            pb_kep.Visible = true;
            lbl_szoveg.Visible = true;
            pb_kep.Image = Image.FromFile("../Debug/gorilla.jpg");
        }

        private void rdbtn_jegesmedve_CheckedChanged(object sender, EventArgs e)
        {

            Allatok jegesmedve = new Allatok("Emlős", "Jegesmedve", "Kanada, Alaszka, Oroszország, Norvégia", 31000);
            lbl_szoveg.Text = ($"A {jegesmedve.nev} egy {jegesmedve.osztaly} állat, amely {jegesmedve.elohely} területén él, napjainkban körülbelül {jegesmedve.peldany} van a világon.");
            pb_kep.Visible = true;
            lbl_szoveg.Visible = true;
            pb_kep.Image = Image.FromFile("../Debug/jegesmedve.jpg");
        }

        private void rdbtn_kigyo_CheckedChanged(object sender, EventArgs e)
        {
            Allatok kigyo = new Allatok("Hüllő", "Kígyó", "bárhol megtalálható kivéve néhány országot", 3000);
            lbl_szoveg.Text = ($"A {kigyo.nev} egy {kigyo.osztaly} állat, amely {kigyo.elohely}, napjainkban körülbelül{kigyo.peldany} fajta van a vadonban.");
            pb_kep.Visible = true;
            lbl_szoveg.Visible = true;
            pb_kep.Image = Image.FromFile("../Debug/kigyo.jpg");
        }

        private void rdbtn_kameleon_CheckedChanged(object sender, EventArgs e)
        {
            Allatok kameleon = new Allatok("Hüllő", "Kaméleon", "Afrika szaharában", 171);
            lbl_szoveg.Text = ($"A {kameleon.nev} egy {kameleon.osztaly} állat, amely {kameleon.elohely} él, napjainkban {kameleon.peldany} fajta van a vadonban.");
            pb_kep.Visible = true;
            lbl_szoveg.Visible = true;
            pb_kep.Image = Image.FromFile("../Debug/kameleon.jpg");
        }

        private void rdbtn_kroki_CheckedChanged(object sender, EventArgs e)
        {
            Allatok krokodil = new Allatok("Hüllő", "Krokodil", "Afrika, Ázsia, Ausztrália", 13);
            lbl_szoveg.Text = ($"A {krokodil.nev} egy {krokodil.osztaly} állat, amely {krokodil.elohely} területén található meg, napjainkban {krokodil.peldany} fajta van a vadonban.");
            pb_kep.Visible = true;
            lbl_szoveg.Visible = true;
            pb_kep.Image = Image.FromFile("../Debug/krokodil.jpg");
        }

        private void rdbtn_teknos_CheckedChanged(object sender, EventArgs e)
        {
            Allatok teknos = new Allatok("Hüllő", "Teknős", "mindenhol megtalálható kivéve az Antarktiszon", 356);
            lbl_szoveg.Text = ($"A {teknos.nev} egy {teknos.osztaly} állat, amely {teknos.elohely}, napjainkban {teknos.peldany} fajta van a vadonban.");
            pb_kep.Visible = true;
            lbl_szoveg.Visible = true;
            pb_kep.Image = Image.FromFile("../Debug/teknos.jpg");
        }

        private void rdbtn_gekko_CheckedChanged(object sender, EventArgs e)
        {
            Allatok gekko = new Allatok("Hüllő", "Gekkó", "mindenhol megtalálható kivéve az Antarktiszon", 1500);
            lbl_szoveg.Text = ($"A {gekko.nev} egy {gekko.osztaly} állat, amely {gekko.elohely}, napjainkban körülbelül{gekko.peldany} fajta van a vadonban.");
            pb_kep.Visible = true;
            lbl_szoveg.Visible = true;
            pb_kep.Image = Image.FromFile("../Debug/gekko.jpg");
        }
    }
}
