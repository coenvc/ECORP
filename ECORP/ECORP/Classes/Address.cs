using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECORP
{
    public class Address
    { 
        public string Straatnaam { get; private set; } 
        public string Woonplaats { get; private set; } 
        public string Postcode { get; private set; } 
        public int Huisnummer { get; private set; }
        public Address(string straatnaam, string woonplaats, string postcode, int huisnummer)
        {
            this.Straatnaam = straatnaam;
            this.Woonplaats = woonplaats;
            this.Postcode = postcode;
            this.Huisnummer = huisnummer;
        }

        public override string ToString()
        {
            return $"{Straatnaam} {Huisnummer.ToString()} {Postcode} {Woonplaats}";
        }
    }
}
