using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalomGame
{
    class Malmok
    {
        public List<Koordinatak> Malomok;

        public Malmok(int elso, int elsoke, int masodik,int masodikocska, int harmadik, int harmadikocska)
        {
            Malomok.Add(new Koordinatak(elso,elsoke));
            Malomok.Add(new Koordinatak(masodik,masodikocska));
            Malomok.Add(new Koordinatak(harmadik,harmadikocska));
        }
        public Malmok()
        {

        }
    }
}
