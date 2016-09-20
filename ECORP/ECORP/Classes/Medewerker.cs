using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECORP
{
    class Medewerker
    {  
        public int ID { get; set; }
        public string Rol { get; private set; } 
        public DateTime Geboortedatum { get; private set; } 
        public decimal Salaris { get; private set; } 
        public string Naam { get; private set; } 
        public string Achternaam { get; private set; } 
        public string Email { get; private set; } 
        public int Telefoonnummer { get; private set; }
        public Address Adddres { get; private set; } 
        public Afdeling Afdeling { get; private set; } 

        

        public Medewerker(string rol,DateTime geboortedatum,decimal salaris,string naam, string achternaam,string email,int telfoonnummer,Afdeling afdeling,Address address)
        {
            this.Rol = rol;
            this.Geboortedatum = geboortedatum;
            this.Salaris = salaris;
            this.Naam = naam;
            this.Achternaam = achternaam;
            this.Email = email;
            this.Telefoonnummer = telfoonnummer;
            this.Adddres = address;
            this.Afdeling = afdeling; 
        }

        public Medewerker(int id, string rol, DateTime geboortedatum, decimal salaris, string naam, string achternaam, string email, int telfoonnummer, Afdeling afdeling, Address address)
        {
            this.Rol = rol;
            this.Geboortedatum = geboortedatum;
            this.Salaris = salaris;
            this.Naam = naam;
            this.Achternaam = achternaam;
            this.Email = email;
            this.Telefoonnummer = telfoonnummer;
            this.Adddres = address;
            this.Afdeling = afdeling;
            this.ID = id;
        }

        public override string ToString()
        {
            return $"{Naam}";
        }

    }
}
