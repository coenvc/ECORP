using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECORP
{
    class Bericht
    { 
        public string Inhoud { get; private set; } 
        public DateTime Geplaatst { get; private set; }

        public Bericht(string inhoud, DateTime geplaatst)
        {
            this.Inhoud = inhoud;
            this.Geplaatst = geplaatst;
        }
    }
}
