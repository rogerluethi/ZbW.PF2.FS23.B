using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Einheit13.InheritanceExample.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Dvd : Medium
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">the id </param>
        /// <param name="b"></param>
        public Dvd(int id, int b) : base(id)
        {
        }

        public string Actor { get; set; } 

        public string Print()
        {
            return "Dvd" + base.Print();
        }
    }
}
