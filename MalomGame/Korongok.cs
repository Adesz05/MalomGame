using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MalomGame
{
    class Korongok
    {
        public bool Igazi;
        public PictureBox Kep;
        public bool VaneRajta;
        public string MelyikSzin;

        public Korongok(PictureBox kep,bool igazi, bool vanerajta, string melyikszin)
        {
            Kep = kep;
            VaneRajta = false;
            MelyikSzin = melyikszin;
            Igazi = igazi;
        }
        public Korongok(bool igazi)
        {
            Igazi = igazi;
        }
        public void Nincsrajta()
        {
            if (!VaneRajta)
            {
                MelyikSzin = "üres";
            }
        }
    }
}
