using Einheit12.VerfuegungExample.Model;

namespace Einheit12.VerfuegungExample.View
{
    public partial class VerfuegungFenster : Form
    {
        public VerfuegungFenster()
        {
            InitializeComponent();
        }


        private void ClickOnBtnDrucken(object sender, EventArgs e)
        {
            var adresseAbsender = new Adresse(TxtAdresseA.Text, NupNrA.Value,
                NupPlzA.Value, TxtOrtA.Text);
            var adresseEmpfaenger = new Adresse(TxtAdresseE.Text, NupNrE.Value,
              NupPlzE.Value, TxtOrtE.Text);

            var personAbsender = new Person(TxtVornameA.Text, TxtNachnameA.Text, adresseAbsender);
            var personEmpfaenger = new Person(TxtVornameE.Text, TxtNachnameE.Text, adresseEmpfaenger);

            var verfuegung = ErstelleVerfuegung(personAbsender, personEmpfaenger);
           // verfuegung.Drucken();
        }


        private Verfuegung ErstelleVerfuegung(Person personAbsender, Person personEmpfaenger)
        {
            var v = new Verfuegung(personEmpfaenger, personAbsender);
            v.Erwaegung = TxtErwaegung.Text;
            return v;
        }
    }
}
