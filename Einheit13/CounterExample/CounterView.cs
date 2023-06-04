using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Einheit13.CounterExample
{
    public partial class CounterView : Form
    {
        public CounterView()
        {
            InitializeComponent();
        }

        private void BtnCreatePerson_Click(object sender, EventArgs e)
        {
            var persons = new List<Person>();
            for(int i = 0; i < NudNumerToCreate.Value; i++)
            {
                persons.Add(new Person("name"));
            }
            var lastPerson = persons[persons.Count-1];
            LblShowCounter.Text = lastPerson.Count.ToString();
            LblShowStaticCounter.Text = Person.CountStatic.ToString();
        }
    }
}
