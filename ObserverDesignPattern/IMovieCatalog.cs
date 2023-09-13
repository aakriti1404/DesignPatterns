using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
    public interface IMovieCatalog
    {
        void RegisterUser(IUser user);
        void RemoveUser(IUser user);
        void NotifyUser();
    }
}
