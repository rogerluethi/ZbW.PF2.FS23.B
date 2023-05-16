using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Einheit11
{
    public class Person
    {
        private string firstName = "Standard Name";

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value != null ? value : "not define"; }
        }

        public string LastName { get; set; }

    }
}
