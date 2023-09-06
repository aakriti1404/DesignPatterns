using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class FolderProxy : IFolder
    {
        private IFolder _folder;
        private Employee _employee;
        public FolderProxy(Employee employee)
        {
            _employee = employee;
        }
        public void PerformOperation()
        {
            if (_employee.Role.ToUpper() == "CEO" || _employee.Role == "Manager")
            {
                _folder = new SecuredFolder();
                Console.WriteLine("Redirecting to Secured Folder.");
                _folder.PerformOperation();
            }
            else
            {
                Console.WriteLine("Sorry! You don't have permission to access Secured Folder.");
                _folder = new GeneralFolder();
                Console.WriteLine("Redirecting to General Folder.");
                _folder.PerformOperation();
            }
        }
    }
}
