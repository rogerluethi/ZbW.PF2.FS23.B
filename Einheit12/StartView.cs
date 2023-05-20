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
        }
    }
}
