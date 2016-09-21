using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECORP.Classes
{
    class Magazijn
    {

        public List<Product> Producten = new List<Product>();
        public List<Medewerker> Medewerkers = new List<Medewerker>();
        public Address Address { get; private set; }
        public string Naam {get; private set;}
        public int Id {get; set;}

        public Magazijn(string naam, int id,Address address)
        {
            this.Naam = naam;
            this.Id = id;
            this.Address = address;
        }

        public Magazijn(string naam, Address address)
        {
            this.Naam = naam;
        }
    }
}
