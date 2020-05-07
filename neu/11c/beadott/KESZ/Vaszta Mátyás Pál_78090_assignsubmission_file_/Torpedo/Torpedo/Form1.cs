using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace Torpedo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int fugoleges=0;

        List<Label> lables = new List<Label>();
        int m = 150;
        int n = 30;
        int naszad = 4;
        int rombolo = 3;
        int sub = 2;
        int carrier = 1;
        List<Label> lables2 = new List<Label>();


        int[,] koordinatak2 = new int[10, 10];
        int[,] koordinatak = new int[10, 10];
        Random r = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < 100; i++)
            {
                Label l = new Label();
                
                if (i % 10 == 0)
                {
                    m += 23;
                }
                l.Parent = this;
                l.Location = new Point((i % 10) * n, m);
                l.Width = 30;
                
                l.BackColor = Color.LightBlue;
                lables.Add(l);
            }
            for(int i=0;i<10;i++)
            {
                for(int f=0;f<10;f++)
                {
                    koordinatak[i, f] = 0;
                }
            }
            lb_carrier.Text = carrier.ToString();
            lb_naszad.Text = naszad.ToString();
            lb_sub.Text = sub.ToString();
            lb_rombolo.Text = rombolo.ToString();
            
        }



        private void btn_fekves_Click(object sender, EventArgs e)
        {
            switch(fugoleges)
            {
                case 0: fugoleges = 1; lb_1.Text = "Balra néz"; break;
                case 1: fugoleges = 2; lb_1.Text = "Lefele néz"; break;
                case 2: fugoleges = 3; lb_1.Text = "Jobbra néz"; break;
                case 3: fugoleges = 0; lb_1.Text = "Felfele néz"; break;
            }
        }

        private void btn_elhelyez_Click(object sender, EventArgs e)
        {
            int x = 0;
            do { x = int.Parse(Interaction.InputBox("Add meg a hajó közepének az X koordinátáját", "Add meg a hajó közepének az X koordinátáját", "0", 50, 50)); }
            while (x < -1 || x > 10);
            int y = 0;
            do { y = int.Parse(Interaction.InputBox("Add meg a hajó közepének az Y koordinátáját", "Add meg a hajó közepének az Y koordinátáját", "0", 50, 50)); }
            while (y < -1 || y > 10);
            if (rb_naszad.Checked == true && naszad>0)
            {
                Hajo.Factory("Naszád",x,y, fugoleges);
                if (fugoleges == 0 && x != 0 && koordinatak[x, y] != 1 && koordinatak[x - 1, y] != 1)
                { koordinatak[x, y] = 1; koordinatak[x - 1, y] = 1; lables[(x * 10) + y].BackColor = Color.Green; lables[((x-1) * 10) + y].BackColor = Color.Green; }
                else if (fugoleges == 1 && y != 0 && koordinatak[x, y] != 1 && koordinatak[x, y - 1] != 1)
                { koordinatak[x, y] = 1; koordinatak[x, y - 1] = 1; lables[(x * 10) + y].BackColor = Color.Green; lables[(x * 10) + (y-1)].BackColor = Color.Green; }
                else if (fugoleges == 2 && x != 9 && koordinatak[x, y] != 1 && koordinatak[x + 1, y] != 1)
                { koordinatak[x, y] = 1; koordinatak[x + 1, y] = 1; lables[(x * 10) + y].BackColor = Color.Green; lables[((x + 1) * 10) + y].BackColor = Color.Green; }
                else if (fugoleges == 3 && y != 9 && koordinatak[x, y] != 1 && koordinatak[x, y + 1] != 1)
                { koordinatak[x, y]=1; koordinatak[x,y+1]=1; lables[(x * 10) + y].BackColor = Color.Green; lables[(x * 10) + (y - 1)].BackColor = Color.Green; }
                naszad--;
                lb_naszad.Text = naszad.ToString();
            }
            else if (rB_rombolo.Checked == true&& rombolo>0)
            {
                Hajo.Factory("Romboló",x,y, fugoleges);
                if (fugoleges == 0 || fugoleges == 2 && x != 0 || x != 9 && koordinatak[x+1,y]!=1&& koordinatak[x,y]!=1&& koordinatak[x-1,y]!=1)
                { koordinatak[x+1,y]=1;koordinatak[x,y]=1;koordinatak[x-1,y]=1; lables[((x + 1) * 10) + y].BackColor = Color.Green; lables[(x * 10) + y].BackColor = Color.Green; lables[((x - 1) * 10) + y].BackColor = Color.Green; }
                else if (fugoleges == 1 || fugoleges == 3 && y != 0 || y != 9 && koordinatak[x, y+1] != 1 && koordinatak[x, y] != 1 && koordinatak[x, y-1] != 1)
                { koordinatak[x, y+1] = 1; koordinatak[x, y] = 1; koordinatak[x, y-1] = 1; lables[(x * 10) + (y+1)].BackColor = Color.Green; lables[(x * 10) + y].BackColor = Color.Green; lables[(x * 10) + (y-1)].BackColor = Color.Green; }
                rombolo--;
                lb_rombolo.Text = rombolo.ToString();
            }
            else if (rb_submarine.Checked == true && sub>0)
            {
                Hajo.Factory("Submarine",x,y, fugoleges);
                if (fugoleges == 0 || fugoleges == 2 && x != 0 || x != 9 && koordinatak[x + 1, y] != 1 && koordinatak[x, y] != 1 && koordinatak[x - 1, y] != 1)
                { koordinatak[x + 1, y] = 1; koordinatak[x, y] = 1; koordinatak[x - 1, y] = 1; lables[((x + 1) * 10) + y].BackColor = Color.Green; lables[(x * 10) + y].BackColor = Color.Green; lables[((x - 1) * 10) + y].BackColor = Color.Green; }
                else if (fugoleges == 1 || fugoleges == 3 && y != 0 || y != 9 && koordinatak[x, y + 1] != 1 && koordinatak[x, y] != 1 && koordinatak[x, y - 1] != 1)
                { koordinatak[x, y + 1] = 1; koordinatak[x, y] = 1; koordinatak[x, y - 1] = 1; lables[(x * 10) + (y + 1)].BackColor = Color.Green; lables[(x * 10) + y].BackColor = Color.Green; lables[(x * 10) + (y - 1)].BackColor = Color.Green; }
                sub--;
                lb_sub.Text = sub.ToString();
            }
            else if (rB_horbozó.Checked == true && carrier>0)
            {
                Hajo.Factory("Hordozó",x,y, fugoleges);
                if (fugoleges == 0 && x != 0 && x != 1 || x != 9 && koordinatak[x-2,y]!=1 && koordinatak[x + 1, y] != 1 && koordinatak[x, y] != 1 && koordinatak[x - 1, y] != 1)
                { koordinatak[x + 1, y] = 1; koordinatak[x, y] = 1; koordinatak[x - 1, y] = 1;koordinatak[x - 2, y] = 1; lables[((x - 2) * 10)+ y].BackColor = Color.Green; lables[((x + 1) * 10) + y].BackColor = Color.Green; lables[(x * 10) + y].BackColor = Color.Green; lables[((x - 1) * 10) + y].BackColor = Color.Green; }
                else if (fugoleges == 1 && y != 0 && y != 1 || y != 9 && koordinatak[x, y+1] != 1 && koordinatak[x, y] != 1 && koordinatak[x, y-1] != 1 && koordinatak[x , y-2] != 1)
                { koordinatak[x, y+1] = 1; koordinatak[x, y] = 1; koordinatak[x, y-1] = 1; koordinatak[x, y-2] = 1; lables[(x * 10) + (y - 2)].BackColor = Color.Green; lables[(x * 10) + (y + 1)].BackColor = Color.Green; lables[(x * 10) + y].BackColor = Color.Green; lables[(x * 10) + (y - 1)].BackColor = Color.Green; }
                else if (fugoleges == 2 && x != 9 && x != 8 || x != 0 && koordinatak[x + 2, y] != 1 && koordinatak[x + 1, y] != 1 && koordinatak[x, y] != 1 && koordinatak[x - 1, y] != 1)
                { koordinatak[x + 1, y] = 1; koordinatak[x, y] = 1; koordinatak[x - 1, y] = 1; koordinatak[x + 2, y] = 1; lables[((x + 2) * 10) + y].BackColor = Color.Green; lables[((x + 1) * 10) + y].BackColor = Color.Green; lables[(x * 10) + y].BackColor = Color.Green; lables[((x - 1) * 10) + y].BackColor = Color.Green; }
                else if (fugoleges == 3 && y != 9 && y != 8 || y != 0 && koordinatak[x, y + 1] != 1 && koordinatak[x, y] != 1 && koordinatak[x, y - 1] != 1 && koordinatak[x, y + 2] != 1)
                { koordinatak[x, y + 1] = 1; koordinatak[x, y] = 1; koordinatak[x, y - 1] = 1; koordinatak[x, y + 2] = 1; lables[(x * 10) + (y + 2)].BackColor = Color.Green; lables[(x * 10) + (y + 1)].BackColor = Color.Green; lables[(x * 10) + y].BackColor = Color.Green; lables[(x * 10) + (y - 1)].BackColor = Color.Green; }
                carrier--;
                lb_carrier.Text = carrier.ToString();
            }
            
        }

        private void btn_elhelyezesbef_Click(object sender, EventArgs e)
        {
            if (naszad == 0 && rombolo == 0 && sub == 0 && carrier == 0)
            {
                gB_1.Visible = false;
                n = 500;
                int x = r.Next(0, 10);
                int y = r.Next(0, 10);
                m = 150;
                for (int i = 0; i < 100; i++)
                {
                    Label l = new Label();

                    if (i % 10 == 0)
                    {
                        m += 23;
                        n = 500;

                    }
                    l.Parent = this;
                    l.Location = new Point(n, m);
                    l.Width = 30;

                    l.BackColor = Color.LightBlue;

                    lables2.Add(l);
                    if (i % 10 != 0)
                    {
                        n += 30;

                    }
                }
                for (int i = 0; i < 10; i++)
                {
                    for (int f = 0; f < 10; f++)
                    {
                        koordinatak2[i, f] = 0;
                    }
                }
                for (int i = 0; i < 5; i++)
                {
                    while (x != 0 && koordinatak2[x, y] != 1 && koordinatak2[x + 1, y] != 1)
                    {
                        if (koordinatak2[x, y] != 1 && koordinatak2[x + 1, y] != 1)
                        { koordinatak2[x, y] = 1; koordinatak2[x + 1, y] = 1; }
                        y = r.Next(0, 10);
                        x = r.Next(0, 10);
                    }

                }
                for (int i = 0; i < 4; i++)
                {
                    while (y != 0 && y != 9 && koordinatak2[x, y] != 1 && koordinatak2[x, y - 1] != 1 && koordinatak2[x, y + 1] != 1)
                    {
                        if (koordinatak2[x, y] != 1 && koordinatak2[x, y - 1] != 1 && koordinatak2[x, y + 1] != 1)
                        { koordinatak2[x, y] = 1; koordinatak2[x, y - 1] = 1; koordinatak2[x, y + 1] = 1; }
                        y = r.Next(0, 10);
                        x = r.Next(0, 10);
                    }
                }
                for (int i = 0; i < 3; i++)
                {
                    while (y != 0 && y != 9 && koordinatak2[x, y] != 1 && koordinatak2[x, y - 1] != 1 && koordinatak2[x, y + 1] != 1)
                    {
                        if (koordinatak2[x, y] != 1 && koordinatak2[x, y - 1] != 1 && koordinatak2[x, y + 1] != 1)
                        { koordinatak2[x, y] = 1; koordinatak2[x, y - 1] = 1; koordinatak2[x, y + 1] = 1; }
                        y = r.Next(0, 10);
                        x = r.Next(0, 10);
                    }
                }
                while (x != 9 && x != 8 && x != 0 && koordinatak2[x - 1, y] != 1 && koordinatak2[x, y] != 1 && koordinatak2[x + 1, y] != 1 && koordinatak2[x + 2, y] != 1)
                {
                    if (koordinatak2[x - 1, y] != 1 && koordinatak2[x, y] != 1 && koordinatak2[x + 1, y] != 1 && koordinatak2[x + 2, y] != 1)
                    { koordinatak2[x - 1, y] = 1; koordinatak2[x, y] = 1; koordinatak2[x + 1, y] = 1; koordinatak2[x + 2, y] = 1; }
                    x = r.Next(0, 10);
                    y = r.Next(0, 10);
                }
                btn_loves.Visible = true;
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            for(int i=0;i<10;i++)
            { for(int f=0;f<10;f++)
                {
                    koordinatak[i, f] = 0;
                }
            }
            for(int i=0;i<100;i++)
            {
                lables[i].BackColor = Color.LightBlue;
            }
            carrier = 1;
            sub = 2;
            rombolo=3;
            naszad = 4;
            lb_carrier.Text = carrier.ToString();
            lb_naszad.Text = naszad.ToString();
            lb_sub.Text = sub.ToString();
            lb_rombolo.Text = rombolo.ToString();
        }

        private void btn_loves_Click(object sender, EventArgs e)
        {
            int enemy = 0;
            int sajat = 0;
            int x = 0;
            do { x = int.Parse(Interaction.InputBox("Add meg a lövésednek az X koordinátáját", "Add meg a lövésednek az X koordinátáját", "0", 50, 50)); }
            while (x < -1 || x > 10);
            int y = 0;
            do { y = int.Parse(Interaction.InputBox("Add meg a lövésednek az Y koordinátáját", "Add meg a lövésednek az Y koordinátáját", "0", 50, 50)); }
            while (y < -1 || y > 10);
            if(koordinatak2[x,y]==0)
            {
                koordinatak2[x,y] = 2;
                lables2[(x * 10) + y].BackColor = Color.Salmon;
            }
            else
            {
                koordinatak2[x, y] = 3;
                lables2[(x * 10) + y].BackColor = Color.Red;
            }
            for (int i = 0; i < 10; i++)
            {
                for (int f = 0; f < 10; f++)
                {
                    if(koordinatak2[i, f] ==1)
                    { enemy++; }
                }
            }
            if(enemy==0)
            { MessageBox.Show("Győzelem"); }
            x = r.Next(0, 10);
            y = r.Next(0, 10);
            if (koordinatak[x, y] == 0)
            {
                koordinatak[x, y] = 2;
                lables[(x * 10) + y].BackColor = Color.Salmon;
            }
            else
            {
                koordinatak[x, y] = 3;
                lables[(x * 10) + y].BackColor = Color.Red;
            }
            for (int i = 0; i < 10; i++)
            {
                for (int f = 0; f < 10; f++)
                {
                    if (koordinatak[i, f] == 1)
                    { sajat++; }
                }
            }
            if (enemy == 0)
            { MessageBox.Show("Vereség"); }
        }
    }
}
