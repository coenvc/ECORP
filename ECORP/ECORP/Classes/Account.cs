using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECORP
{
    class Account
    { 
        public int AccountId { get; private set; }
        public string Gebruikersnaam { get; private set; } 
        public string Wachtwoord { get; private set; }

        public Account(int accountId,string gebruikersnaam, string wachtwoord)
        {
            this.AccountId = accountId; 
            this.Gebruikersnaam = gebruikersnaam;
            this.Wachtwoord = wachtwoord;
        }
    }
}
