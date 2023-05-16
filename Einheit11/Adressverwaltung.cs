namespace Einheit11
{
  public partial class Adressverwaltung : Form
  {
    public Adressverwaltung()
    {
      InitializeComponent();
    }

    private void CmdCreatePerson_Click(object sender, EventArgs e)
    {
            var person1 = new Person();
            //person1.FirstName = "Larissa";
            person1.FirstName =null;
            var person2 = new Person();
            person2.LastName = "Fitze";
            var firstNamePerson2 = person2.FirstName;
    }

  }
}
