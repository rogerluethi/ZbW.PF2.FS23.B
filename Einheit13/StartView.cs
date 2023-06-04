using Einheit13.CounterExample;
using Einheit13.InheritanceExample;
using Einheit13.Shopping.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Einheit13
{
    public partial class StartView : Form
    {
        public StartView()
        {
            InitializeComponent();
        }



        private void OnClickBtnStaticExample(object sender, EventArgs e)
        {
            var view = new CounterView();
            view.Show();
        }

        private void ClickOnBtnShopping(object sender, EventArgs e)
        {
            var view = new Shop();
            view.Show();
        }

        private void ClickOnBtnInheritance(object sender, EventArgs e)
        {
            var view = new DbView();
            view.Show();
        }
    }
}
