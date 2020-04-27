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
        public Form1()
        {
            fegyok.Add(new Sheriff());
            InitializeComponent();
        }

        private void bt_indit_Click(object sender, EventArgs e)
        {
            foreach (var fegyo in fegyok)
            {
                listBox1.Items.Add(fegyo.ToString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var kivalasztottIndex = listBox1.SelectedIndex;  // ez megadja hányadik elemet választottuk = listában ugyanez az index!!!
            pictureBox1.ImageLocation = fegyok[kivalasztottIndex].KepPath;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
