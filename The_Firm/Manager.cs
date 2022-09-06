using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Firm
{
    internal class Manager : Employee
    {
        // Valueables

        protected internal string phoneNumber;

        // Property
        private string PhonenNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        // Constructor with inherited parameters
        protected internal Manager(string firstname, string lastname, string cprnum, string phoneNumber) : base(firstname, lastname, cprnum)
        {
            this.phoneNumber = phoneNumber;
        }

        // Method overrite writing out properties
        protected internal override void GetProps()
        {
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(crnNr);
            Console.WriteLine(phoneNumber);
        }

        // Virtual Method
        protected internal virtual void GetProps1()
        {

        }
    }
}
