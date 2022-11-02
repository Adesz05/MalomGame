using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalomGame
{
    class Player
    {
        public string Nev,MelyikSzin;
        public int Pontszam,TablanLevoKorongokSzama, NemTablanLevoKorongokSzama;

        public Player(string nev, string melyikszin, int pontszam, int tablanlevo, int nemtablanlevo)
        {
            Nev = nev;
            MelyikSzin = melyikszin;
            Pontszam = pontszam;
            TablanLevoKorongokSzama = tablanlevo;
            NemTablanLevoKorongokSzama = nemtablanlevo;
        }
       
    }
}
