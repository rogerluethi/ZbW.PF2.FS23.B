using Einheit13.InheritanceExample.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Einheit13.InheritanceExample
{
    public partial class DbView : Form
    {
        private DatabaseController controller;
        public DbView()
        {
            InitializeComponent();
            controller = new DatabaseController();
        }

        private void ClickOnCmdCreateCd(object sender, EventArgs e)
        {
            var cd = new Cd();
            cd.Name = TxtName.Text;
            cd.Interpreter = TxtInterpreter.Text;
            controller.Add(cd);
        }

        private void ClickOnCmdCreateDvd(object sender, EventArgs e)
        {
            var dvd = new Dvd();
            dvd.Name = TxtName.Text;
            dvd.Actor = TxtActor.Text;
            controller.Add(dvd);
        }

        private void CmdShowMedium_Click(object sender, EventArgs e)
        {
            LbShowAllMediums.Items.Clear();
            var dvds = controller.GetAllDvds();
            foreach (var d in dvds)
            {
                LbShowAllMediums.Items.Add($"Name: {d.Name} Actor: {d.Actor}");
            }
            var cds = controller.GetAllCds();
            foreach (var c in cds)
            {
                LbShowAllMediums.Items.Add($"Name: {c.Name} Interpreter: {c.Interpreter}");
            }
        }
    }
}
