using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECORP
{
    class MedewerkerLogic
    {
     
        private IMedewerkerRepository mwr;

        public MedewerkerLogic(IMedewerkerRepository mr)
        {
            this.mwr = mr;
        }

        public void InsertMedewerker(Medewerker m)
        {
            mwr.InsertMedewerker(m);
        }

        public List<Medewerker> GetAllMedewerkers()
        {
           return mwr.getAllMedewerkers();
        }

        public void RemoveMedewerker(Medewerker m)
        {
            mwr.DeleteMedewerker(m);
        }


    }
}
