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
        public PictureBox Kep;
        public bool VaneRajta;
        public string MelyikSzin;

        public Korongok(PictureBox kep, bool vanerajta, string melyikszin)
        {
            Kep = kep;
            VaneRajta = false;
            MelyikSzin = melyikszin;
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
