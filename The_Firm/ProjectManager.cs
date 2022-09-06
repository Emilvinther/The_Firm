using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Firm
{
    internal sealed class ProjectManager : Manager
    {
        // Valuable

        internal string email;

        // Property
        private string Email
        {
            get { return email; }
            set { email = value; }
        }

        // Constructor with inherited parameters

        internal ProjectManager(string firstname, string lastname, string cprnum, string phoneNumber, string email) : base(firstname, lastname, cprnum, phoneNumber)
        {
            this.email = email;
        }

        // Method using GetProps for data and adding 1 more valuable

        protected internal override void GetProps1()
        {
            base.GetProps();
            Console.WriteLine(email);
        }



    }
}
