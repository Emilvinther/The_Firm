using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Firm
{
    internal sealed class Sweeper : Employee
    {

        // Inhertied Constructor
        internal Sweeper(string firstname, string lastname, string cprnum) : base(firstname, lastname, cprnum)
        {
        }

        // Getprop Method from Super Class
        protected internal override void GetProps()
        {
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(crnNr);
        }
    }
}
