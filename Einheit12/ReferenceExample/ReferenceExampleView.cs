namespace Einheit12.ReferenceExample
{
    public partial class ReferenceExampleView : Form
    {
        public ReferenceExampleView()
        {
            InitializeComponent();
            BtnCheck.BackColor = Color.Blue;
        }

        private void ClickOnBtnCheck(object sender, EventArgs e)
        {
            var personA = new Person(TxtPersonA.Text);
            var personB = new Person(TxtPersonB.Text);

            LblResponseEvenSign.Text = personA.CompareWithEvenSign(personB).ToString();

            var isEqual = personA.Equals(personB);
            LblResponseEquals.Text = isEqual.ToString();
            ChangeBtnColor(sender, isEqual);
        }

        private void ChangeBtnColor(object sender, bool isEqual)
        {
            Button button = (Button)sender;

            if (isEqual)
            {
                button.BackColor = Color.Green;
            }
            else
            {
                button.BackColor = Color.Red;
            }
        }
    }
}
