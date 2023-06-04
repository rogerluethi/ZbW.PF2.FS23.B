using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Einheit13.CounterExample
{
    public class Person
    {
        public static int CountStatic;
        public  int Count;

        public Person(string name)
        {
            Name = name;
            Count++;
            CountStatic++;
        }

        public string Name { get; set; }

    }
}
