using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramozásProjeckt
{
    public partial class f_munkás : Form
    {
        public f_munkás()
        {
            InitializeComponent();
        }
        List<Munkások> munkahely = new List<Munkások>();
        List<Munkások> újak = new List<Munkások>();
       

        private void btn_egy_Click(object sender, EventArgs e)
        {
            //Fizikai munkás hozzáadása          
            if (rb_fizikai.Checked)
            {
                újak.Clear();
                for (int i = 0; i < nud.Value; i++)
                {
                    munkahely.Add(new FizikaiMunkás());
                    újak.Add(new FizikaiMunkás());
                    lb_valami.Items.Add(újak[i].fizikum() + " " + újak[i].iq());   
                }
            }
            //Szellemi munkás hozzáadása
            else if (rb_szellemi.Checked)
            {
                újak.Clear();
                for (int i = 0; i < nud.Value; i++)
                {
                    munkahely.Add(new SzellemiMunkás());
                    újak.Add(new SzellemiMunkás());
                    lb_valami.Items.Add(újak[i].fizikum() + " " + újak[i].iq());
                }
            }    
        }

        private void btn_egesz_Click(object sender, EventArgs e)
        {
            lb_összes.Items.Clear();
            foreach (var item in munkahely)
            {
                /* switch (item)
                 {
                     case ProgramozásProjeckt.FizikaiMunkás:
                         lb_összes.Items.Add("Fizikai munkás");

                     case ProgramozásProjeckt.SzellemiMunkás:
                         lb_összes.Items.Add("Szellemi munkás");
                 }*/
                lb_összes.Items.Add(item);
            }
        }

        //Törlés
        private void btn_töröl_Click(object sender, EventArgs e)
        {
            lb_összes.Items.Clear();
            lb_valami.Items.Clear();
            újak.Clear();
            munkahely.Clear();
        }
        //Bezárás
        private void btn_bezár_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            rb_fizikai.Checked = true;
        }

    }
}
