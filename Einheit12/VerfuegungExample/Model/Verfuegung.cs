namespace Einheit12.VerfuegungExample.Model
{
    public class Verfuegung
    {
        public const string rechtsmittelbelehrung = "Gegen diesen Beschluss kann, " +
            "von der Veröffentlichung an gerechnet, beim Bezirksrat XY" +
            " innert 30 Tagen schriftlich Rekurs erhoben werden ";

        public Verfuegung(Person empfaenger, Person absender)
        {
            Empfaenger = empfaenger;
            Abesender = absender;
            Datum = DateTime.Now;
        }

        public string Erwaegung { get; set; }

        public DateTime Datum { get; private set; }

        public Person Empfaenger { get; set; }

        public Person Abesender { get; set; }
    }
}
