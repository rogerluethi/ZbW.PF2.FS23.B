namespace Einheit12.VerfuegungExample.Model
{
    public class Adresse
    {
        public Adresse(string strassenname,
            int strassennr,
            int plz,
            string ort)
        {
            Plz = plz;
            Ort = ort;
            SetzeStrasse(strassenname, strassennr);
        }

        public string Ort { get; set; }

        public int Plz { get; set; }

        public string Strasse { get; private set; }

        public void SetzeStrasse(string strassenname, int strassennr)
        {
            Strasse = $"{strassenname} {strassennr}";
        }
    }
}
