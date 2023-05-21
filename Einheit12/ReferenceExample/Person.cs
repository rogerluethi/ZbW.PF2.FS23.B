using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Einheit12.ReferenceExample
{
    public class Person
    {
        public Person(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public bool CompareWithEvenSign(Person b)
        {
            var isEven = this == b;
            return isEven;
        }

        public bool Equals(Person other)
        {
            if (other == null)
            {
                return false;
            }
            if (Name == other.Name)
            {
                return true;
            }
            return false;
        }

    }
}
