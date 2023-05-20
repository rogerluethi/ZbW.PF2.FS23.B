namespace Einheit12.VerfuegungExample.Model
{
    public class Adresse
    {
        public Adresse(string strassenname,
            decimal strassennr,
            decimal plz,
            string ort)
        {
            Plz = plz;
            Ort = ort;
            SetzeStrasse(strassenname, strassennr);
        }

        public string Ort { get; set; }

        public decimal Plz { get; set; }

        public string Strasse { get; private set; }

        public void SetzeStrasse(string strassenname, decimal strassennr)
        {
            Strasse = $"{strassenname} {strassennr}";
        }
    }
}
