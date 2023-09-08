// See https://aka.ms/new-console-template for more information
using System;

namespace CompositeDesignPattern
{
    class Program
    {
        public static void Main(string[] args) 
        {
            //Creating leaf object
            IEmployee employee1 = new Leaf("Employee1");
            IEmployee employee2 = new Leaf("Employee2");
            IEmployee employee3 = new Leaf("Employee3");
            IEmployee intern1   = new Leaf("Intern1");

            //Creating composite object
            Composite manager1  = new Composite("Manager1");
            Composite manager2  = new Composite("Manager2");
            Composite manager3  = new Composite("Manager3");
            Composite director1 = new Composite("Director1");
            Composite director2 = new Composite("Director2");
            Composite employee4 = new Composite("Employee4");
            Composite ceo       = new Composite("CEO");

            //Adding leaf element in Composite
            manager1.AddEmployee(employee1);

            director1.AddEmployee(manager1);

            manager2.AddEmployee(employee2);
            manager2.AddEmployee(employee3);

            employee4.AddEmployee(intern1);
            manager3.AddEmployee(employee4);

            director2.AddEmployee(manager2); 
            director2.AddEmployee(manager3);

            ceo.AddEmployee(director1);
            ceo.AddEmployee(director2);

            Console.WriteLine("Employees under CEO");
            ceo.DisplayDetails();

            Console.WriteLine("Employees under director1");
            director1.DisplayDetails();

            Console.WriteLine("Employees under manager1");
            manager1.DisplayDetails();

            Console.WriteLine("Employees under director2");
            director2.DisplayDetails();

            Console.WriteLine("Employees under manager2");
            manager2.DisplayDetails();

            Console.WriteLine("Employees under manager3");
            manager3.DisplayDetails();

            Console.WriteLine("Employees under employee4");
            employee4.DisplayDetails();

            Console.ReadLine();
        }
    }
}
