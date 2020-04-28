using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schvorczi_Gergő_Projekt
{
    public partial class Form1 : Form
    {
        int win = 0;
        int mac = 0;
        int lin = 0;
        Oprendszer gep;

        public Form1()
        {
            InitializeComponent();
        }
        private void bt_telepit_Click(object sender, EventArgs e)
        {
            if (tb_cpu.Text == "")
            { MessageBox.Show("Adjon meg egy processzorfajtát!(Intel vagy AMD)"); }
            else
            {
                string cpu = tb_cpu.Text;
                if (nud_ram.Text == "")
                { MessageBox.Show("Adjon meg egy memóriamennyiséget!(Olyan szám, ami nagyobb, mint 0)"); }
                else
                {
                    int ram = int.Parse(nud_ram.Text);
                    if (tb_gpu.Text == "")
                    { MessageBox.Show("Adjon meg egy videókártyát!(Nincs vagy Nvidia vagy AMD)"); }
                    else
                    {
                        string gpu = tb_gpu.Text;
                        if (tb_bit.Text == "")
                        { MessageBox.Show("Adjon meg egy bitmennyiséget!"); }
                        else
                        {
                            string bit = tb_bit.Text;

                            if (cpu == "Intel" || cpu == "AMD")
                            {
                                if (ram > 0)
                                {
                                    if (gpu == "Nincs" || gpu == "Nvidia" || gpu == "AMD")
                                    {
                                        if (bit == "64" || bit == "32")
                                        {
                                            if (rb_win.Checked)
                                            {
                                                gep = new Windows(ram, cpu, gpu, bit, "Windows");
                                                win = 1;
                                                bt_torles.Enabled = true;
                                                bt_adatok.Enabled = true;
                                                bt_kikapcs.Enabled = true;
                                                bt_progszam.Enabled = true;
                                                bt_uzenet.Enabled = true;
                                                bt_telepit.Enabled = false;
                                                nud_progszam.Enabled = true;
                                                tb_cpu.Enabled = false;
                                                tb_gpu.Enabled = false;
                                                tb_bit.Enabled = false;
                                                nud_ram.Enabled = false;
                                            }
                                            else if (rb_mac.Checked)
                                            {
                                                gep = new MacOS(ram, cpu, gpu, bit, "MacOS");
                                                mac = 1;
                                                bt_torles.Enabled = true;
                                                bt_adatok.Enabled = true;
                                                bt_kikapcs.Enabled = true;
                                                bt_progszam.Enabled = true;
                                                bt_uzenet.Enabled = true;
                                                bt_telepit.Enabled = false;
                                                nud_progszam.Enabled = true;
                                                tb_cpu.Enabled = false;
                                                tb_gpu.Enabled = false;
                                                tb_bit.Enabled = false;
                                                nud_ram.Enabled = false;
                                            }

                                            else if (rb_lin.Checked)
                                            {
                                                gep = new Linux(ram, cpu, gpu, bit, "Linux");
                                                lin = 1;
                                                bt_torles.Enabled = true;
                                                bt_adatok.Enabled = true;
                                                bt_kikapcs.Enabled = true;
                                                bt_progszam.Enabled = true;
                                                bt_uzenet.Enabled = true;
                                                bt_telepit.Enabled = false;
                                                nud_progszam.Enabled = true;
                                                tb_cpu.Enabled = false;
                                                tb_gpu.Enabled = false;
                                                tb_bit.Enabled = false;
                                                nud_ram.Enabled = false;
                                            }
                                        }
                                        else
                                        { MessageBox.Show("Nem megfelelő videókártya adat(Nincs vagy Nvidia vagy AMD)!"); }
                                    }
                                    else
                                    { MessageBox.Show("Nem megfelelő memóriamennyiség(Olyan szám, ami nagyobb, mint 0)!"); }
                                }
                                else
                                { MessageBox.Show("Nem megfelelő processzor adat(Intel vagy AMD)!"); }

                            }
                            else
                            { MessageBox.Show("Nem megfelelő bitmennyiség(32 vagy 64)!"); }
                        }
                    }
                }
            }
        }

        private void bt_uzenet_Click(object sender, EventArgs e)
        {
            lbx_eredmeny.Items.Clear();
            lbx_eredmeny.Items.Add(gep.Uzenet());
        }

        private void bt_kikapcs_Click(object sender, EventArgs e)
        {
            lbx_eredmeny.Items.Clear();
            lbx_eredmeny.Items.Add(gep.Kikapcsolas());
        }

        private void bt_progszam_Click(object sender, EventArgs e)
        {
            lbx_eredmeny.Items.Clear();
            if (nud_progszam.Text == "")
            { MessageBox.Show("Adjon meg egy egész, pozitív programszámot!"); }
            else
            {
                double progszam = double.Parse(nud_progszam.Text);
                if (progszam > 0)
                {
                    lbx_eredmeny.Items.Add($"A telepített programok száma: {gep.ProgramokSzama(progszam)}");
                }
                else
                { MessageBox.Show("Adjon meg egy egész, pozitív programszámot!"); }
            }
        }

        private void bt_adatok_Click(object sender, EventArgs e)
        {
            lbx_eredmeny.Items.Clear();

                lbx_eredmeny.Items.Add($"Az operációs rendszer: {gep.Rendszer}");
                lbx_eredmeny.Items.Add($"Processzor: {gep.Cpu}");
                lbx_eredmeny.Items.Add($"Memória mérete: {gep.Ram} GB");
                lbx_eredmeny.Items.Add($"Videókártya: {gep.Gpu}");
                lbx_eredmeny.Items.Add($"Rendszer bitszám: {gep.Bit}");
          
        }

        private void bt_torles_Click(object sender, EventArgs e)
        {
            lbx_eredmeny.Items.Clear();

            
            win = win - 1;
            lbx_eredmeny.Items.Add($"A {gep.Rendszer}-(o)t sikeresen eltávolította!");
   
            bt_torles.Enabled = false;
            bt_adatok.Enabled = false;
            bt_kikapcs.Enabled = false;
            bt_progszam.Enabled = false;
            bt_uzenet.Enabled = false;
            nud_progszam.Enabled = false;
            bt_ellen.Enabled = true;
            rb_win.Enabled = true;
            rb_mac.Enabled = true;
            rb_lin.Enabled = true;
        }

        private void bt_ellen_Click(object sender, EventArgs e)
        {
            lbx_eredmeny.Items.Clear();
            if (rb_win.Checked)
            {
                bt_telepit.Enabled = true;
                tb_cpu.Enabled = true;
                tb_gpu.Enabled = true;
                tb_bit.Enabled = true;
                nud_ram.Enabled = true;
                bt_ellen.Enabled = false;
                rb_win.Enabled = false;
                rb_mac.Enabled = false;
                rb_lin.Enabled = false;
            }
            else if (rb_mac.Checked)
            {
                bt_telepit.Enabled = true;
                tb_cpu.Enabled = true;
                tb_gpu.Enabled = true;
                tb_bit.Enabled = true;
                nud_ram.Enabled = true;
                bt_ellen.Enabled = false;
                rb_win.Enabled = false;
                rb_mac.Enabled = false;
                rb_lin.Enabled = false;
            }
            else if (rb_lin.Checked)
            {
                bt_telepit.Enabled = true;
                tb_cpu.Enabled = true;
                tb_gpu.Enabled = true;
                tb_bit.Enabled = true;
                nud_ram.Enabled = true;
                bt_ellen.Enabled = false;
                rb_win.Enabled = false;
                rb_mac.Enabled = false;
                rb_lin.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Ez egy operációs rendszer telepítő-szimulátor! Kérem adja meg a kért adatokat! A segítség gombbal instrukciókat kaphat az elfogadott adatokról!");
        }

        private void bt_segit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A processzor vagy Intel vagy AMD! A memória egy 0-nál nagyobb egész szám! Videókártya Nincs vagy Nvidia vagy AMD! A bitszám az 32 vagy 64! A programszám egy pozitív egész szám, amiből a gép kiszámolja a rendszeren található programok számát!");
        }
    }
}
