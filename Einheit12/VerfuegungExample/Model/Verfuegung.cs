namespace Einheit12.VerfuegungExample.Model
{
    using iTextSharp.text;
    using iTextSharp.text.pdf;

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

        public void Print()
        {
            Document document = new Document();
            string filePath = $"C:\\Users\\Larissa\\Documents\\Temp\\Verfuegung-{Guid.NewGuid()}.pdf";

            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
            document.Open();

            var adresseEmpfaenger = HinzufuegenAdresse(Empfaenger.Vorname, Empfaenger.Nachname, Empfaenger.Adresse.Strasse, Empfaenger.Adresse.Plz, Empfaenger.Adresse.Ort);
            document.Add(adresseEmpfaenger);

            var adresseAbsender = HinzufuegenAdresse(Abesender.Vorname, Abesender.Nachname, Abesender.Adresse.Strasse, Abesender.Adresse.Plz, Abesender.Adresse.Ort);
            document.Add(adresseAbsender);

            var erwaegung = HinzufugenErwaegung();
            document.Add(erwaegung);

            document.Close();
        }

        private Paragraph GibParagraph(int alignment)
        {
            Paragraph p = new Paragraph();
            p.Alignment = alignment;
            return p;
        }

        private Paragraph HinzufugenErwaegung()
        {
            var p = GibParagraph(Element.ALIGN_LEFT);
            Chunk erwaegung = new Chunk($"{Erwaegung}", GibStandardSchrift());

            p.Add(erwaegung);
            p.Add(Chunk.NEWLINE);

            return p;
        }

        private Font GibStandardSchrift()
        {
            return new Font(Font.FontFamily.HELVETICA, 12);
        }

        private Paragraph HinzufuegenAdresse(string vorname, string nachname, string strasse, decimal plz, string ort)
        {
            Paragraph p = GibParagraph(Element.ALIGN_LEFT);

            Chunk name = new Chunk($"{vorname} {nachname}", GibStandardSchrift());
            Chunk street = new Chunk($"{strasse}", GibStandardSchrift());
            Chunk city = new Chunk($"{plz} {ort}", GibStandardSchrift());

            p.Add(name);
            p.Add(Chunk.NEWLINE);
            p.Add(street);
            p.Add(Chunk.NEWLINE);
            p.Add(city);
            p.Add(Chunk.NEWLINE);
            p.Add(Chunk.NEWLINE);

            return p;
        }

    }
}
