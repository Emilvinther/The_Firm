using System;

namespace The_Firm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Polymorf versions of instances
            Employee m = new Manager("Emil\n", "Lorentzen\n", "12432\n", "423423\n");
            Employee e = new ProjectManager("dsfsdf\n","dfgdfgd\n","4234324\n","32432423\n","43243242\n");
            Employee s = new Sweeper("Frederik\n", "Jegveddetikke\n", "23432423\n");
            
            // Casting of instances
            Manager m2 = (Manager)m;
            ProjectManager e2 = (ProjectManager)e;
            Sweeper s2 = (Sweeper)s;

            // Print instances

            Console.WriteLine(e2.firstName);
            Console.WriteLine(e2.lastName);
            Console.WriteLine(e2.crnNr);
            Console.WriteLine(e2.phoneNumber);
            Console.WriteLine(e2.email);

            Console.WriteLine(s2.firstName);
            Console.WriteLine(s2.lastName);
            Console.WriteLine(s2.crnNr);

            Console.ReadLine();
        }
    }
}
