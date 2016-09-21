using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace ECORP
{
     class MedewerkerRepository: IMedewerkerRepository
    { 
        
        private int Id = 0; 

         public static List<Medewerker> medewerkers = new List<Medewerker>();

        

        public Medewerker getMedewerkerById(int id)
        {
            Medewerker mw = null;
            foreach (Medewerker m in medewerkers)
            {
                if (m.ID == id)
                {
                     mw = m;
                }
                else
                {
                    mw = null;
                }
             
            }
            return mw;
        }

         public void Log()
         {
            string fileName = "test.txt";
            FileStream fs = null;
            try
            {
                JsonSerializer serializer = new JsonSerializer();
                using (StreamWriter sw = new StreamWriter(@"D:\json.txy"))
                using (JsonWriter writer = new JsonTextWriter(sw))
                { 
                    foreach(Medewerker m in medewerkers)
                    {
                        serializer.Serialize(writer, m);
                    }
                }
            }
            finally
            {
                if (fs != null)
                    fs.Dispose();
            }
        }

        public List<Medewerker> getAllMedewerkers()
        {
            return medewerkers;
        }

        public void InsertMedewerker(Medewerker m)
        {
            Id++;
            m.ID = Id;
            medewerkers.Add(m);

        }

        public void DeleteMedewerker(Medewerker m)
        {
            try
            {
                foreach (Medewerker mw in medewerkers)
                {
                    if (m.ID == mw.ID)
                    {
                        medewerkers.Remove(mw);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message); 
            }
        }

        public void UPdateMedewerker(Medewerker newMedewerker, Medewerker medewerker)
        {
            foreach (Medewerker m in medewerkers)
            {
                if (m.ID == medewerker.ID)
                {
                    newMedewerker.ID = m.ID;
                    medewerkers.Remove(m);
                    medewerkers.Add(newMedewerker);
                }
            }
        }
    }
}
