using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern
{
    public class Leaf : IEmployee
    {
        public string _designation { get; set; }

        public Leaf(string designation)
        {
            this._designation = designation;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"The designation of employee is: {_designation}");
        }
    }
}
