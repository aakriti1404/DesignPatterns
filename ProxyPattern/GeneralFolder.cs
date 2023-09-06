using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class GeneralFolder : IFolder
    {
        public void PerformOperation()
        {
            Console.WriteLine("Performing read-write operation on the general folder.");
            Console.WriteLine("It can be accessed by any employee.");
        }
    }
}
