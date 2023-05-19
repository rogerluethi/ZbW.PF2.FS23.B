namespace Einheit12.VerfuegungExample.Model
{
    public class Person
    {
        public Person(string vorname, string nachname, Adresse adresse)
        {
            Vorname = vorname;
            Nachname = nachname;
            Adresse = adresse;
        }

        public string Vorname { get; set; }

        public string Nachname { get; set; }

        public Adresse Adresse { get; set; }

    }
}
