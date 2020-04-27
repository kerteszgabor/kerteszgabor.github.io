using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Torpedo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Button> lables = new List<Button>();
        int m = 23;
        Random r = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < 100; i++)
            {
                Button b = new Button();
                
                if (i % 10 == 0)
                {
                    m += 23;
                }
                b.Parent = this;
                b.Location = new Point((i % 10) * 30, m);
                b.Width = 30;
                b.BackColor = Color.LightBlue;
                lables.Add(b);
            }
        }
    }
}
