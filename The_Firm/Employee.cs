using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Firm
{
    internal abstract class Employee
    {
        // valueables
        protected internal string firstName;
        protected internal string lastName;
        protected internal string crnNr;

        // properties
        private string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        private string CrnNr
        {
            get { return crnNr; }
            set { crnNr = value; }
        }
        

        // Constructor
        protected internal Employee(string firstname, string lastname, string cprnum)
        {
            this.firstName = firstname;
            this.lastName = lastname;
            this.crnNr = cprnum;

        }

        // Abstract Method
        protected internal abstract void GetProps();
    }
}
