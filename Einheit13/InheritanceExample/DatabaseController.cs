using Einheit13.InheritanceExample.Model;

namespace Einheit13.InheritanceExample
{
    public class DatabaseController
    {
        private int medienCounter;
        private Medium[] medien;

        public DatabaseController()
        {
            medien = new Medium[100];
            medienCounter = 0;
        }


        public bool Add(Medium medium)
        {
            if (medienCounter < medien.Length)
            {
                medien[medienCounter++] = medium;
            }
            return false;
        }

        public List<Cd> GetAllCds()
        {
            var cds = new List<Cd>();
            foreach (var cd in medien)
            {
                if (cd is Cd)
                {
                    cds.Add((Cd)cd);
                }
            }
            return cds;
        }

        public List<Dvd> GetAllDvds()
        {
            var dvds = new List<Dvd>();
            foreach (var dvd in medien)
            {
                if (dvd is Dvd)
                {
                    dvds.Add((Dvd)dvd);
                }
            }
            return dvds;
        }

    }
}
