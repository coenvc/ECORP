using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECORP.Classes
{
    public class Product
    {
       public int Id { get; set; }
       public string Naam { get; private set; }
       public decimal Prijs { get; private set; } 
       public int Serienummer { get; private set; } 
       public int Stock { get; set; }

        public Product(string naam, decimal prijs,int serienummer, int stock)
        {
            this.Serienummer = serienummer;
            this.Naam = naam;
            this.Prijs = prijs;
            this.Stock = stock;

        }
        public Product(string naam, decimal prijs, int serienummer, int id, int stock)
        {
            this.Serienummer = serienummer;
            this.Naam = naam;
            this.Prijs = prijs;
            this.Id = id;
            this.Stock = stock;
        }

        public override string ToString()
        {
            return $"Naam: {Naam} Prijs: {Prijs} Aantal: {Stock}";
        }
    }
}
