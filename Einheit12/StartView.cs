using Einheit12.ReferenceExample;
using Einheit12.VerfuegungExample.View;

namespace Einheit12
{
    public partial class StartView : Form
    {
        public StartView()
        {
            InitializeComponent();
        }

        private void ClickOnBtnVerfuegungExample(object sender, EventArgs e)
        {
            var view = new VerfuegungFenster();
            view.Show();
            this.Visible = false;
        }

        private void ClickOnBtnRefExample(object sender, EventArgs e)
        {
            var view = new ReferenceExampleView();
            view.Show();
            this.Visible = false;
        }
    }
}
