using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECORP
{
    interface IMedewerkerRepository
    {
       Medewerker getMedewerkerById(int id);

       List<Medewerker> getAllMedewerkers();

       void InsertMedewerker(Medewerker m);

       void DeleteMedewerker(Medewerker m);

       void UPdateMedewerker(Medewerker newMedewerker, Medewerker medewerker);

    }
}
