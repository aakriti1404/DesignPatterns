using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace CompositeDesignPattern
{
    public class Composite : IEmployee
    {
        public string _designation { get; set; }

        List<IEmployee> employee = new List<IEmployee>();

        public Composite(string designation)
        {
            _designation = designation;
        }
        public void AddEmployee(IEmployee child)
        {
            employee.Add(child);
        }
        public void DisplayDetails()
        {
            foreach(var child in employee)
            {
                child.DisplayDetails();
            }
        }

    }
}
