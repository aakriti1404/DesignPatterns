using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class ProxyFolder : IFolder
    {
        private IFolder _folder;
        private Employee _employee;
        public ProxyFolder(Employee employee)
        {
            _employee = employee;
        }
        public void PerformOperation()
        {
            if(_employee.Role.ToUpper()=="CEO"|| _employee.Role == "Manager")
            {
                _folder = new Folder();
                Console.WriteLine("Proxy folder makes call to the real folder 'PerformOperation' method.");
                _folder.PerformOperation();
            }
            else
            {
                Console.WriteLine("You don't have permission to access this folder.");
            }
        }
    }
}
