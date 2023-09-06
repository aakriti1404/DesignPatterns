using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class SecuredFolder : IFolder
    {
        public void PerformOperation()
        {
            Console.WriteLine("Performing read-write operation on the secured folder.");
            Console.WriteLine("It can be accessed by only CEO and Manager.");
        }
    }
}
