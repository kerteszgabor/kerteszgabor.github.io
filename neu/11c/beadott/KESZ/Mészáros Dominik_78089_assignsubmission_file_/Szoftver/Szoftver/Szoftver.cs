using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace Szoftver
{
    abstract class Szoftver
    {
        protected string sznev;
        protected int szkiadaseve;
        protected string szkiado;
        protected string szinfo; 
        
        protected Szoftver(string nev, int kiadaseve, string kiado, string info){}

        //tulajdonságok
        public string Nev
        {
            get
            {
                string help = $"Szoftver neve: {sznev}";
                return help;
            }
        }
        public string Kiadaseve
        {
            get
            {
                string help = $"Kiadás éve: {szkiadaseve}";
                return help;
            }
        }
        public string Kiado
        {
            get
            {
                string help = $"Kiadó: {szkiado}";
                return help;
            }
        }
        public string Info
        {
            get
            {
                string help = $"Kis érdekesség: {szinfo}";
                return help;
            }
        }
    }

    class Word : Szoftver
    {
        public Word(string nev, int kiadaseve, string kiado, string info) 
            : base (nev, kiadaseve, kiado, info)
        {
            sznev = nev;
            szkiadaseve = kiadaseve;
            szkiado = kiado;
            szinfo = info;
        }
    }

    class Paint : Szoftver
    {
        public Paint(string nev, int kiadaseve, string kiado, string info) 
            : base (nev, kiadaseve, kiado, info)
        {
            sznev = nev;
            szkiadaseve = kiadaseve;
            szkiado = kiado;
            szinfo = info;
        }

        //metódusok
        public Image Kep(Image image)
        {
            return image;
        }
        public int Width(Image image)
        {
            int width = image.Width;
            return width;
        }
        public int Height(Image image)
        {
            int height = image.Height;
            return height;
        }
    }
}
