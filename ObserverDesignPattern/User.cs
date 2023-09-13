using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
    public class User : IUser
    {
        public string UserName { get; set; }
        public User(string userName)
        {
            UserName = userName;
        }

        //Registering the Observer with the Subject
        public void AddUser(IMovieCatalog movieCatalog)
        {
            movieCatalog.RegisterUser(this);
        }
        public void RemoveUser(IMovieCatalog movieCatalog)
        {
            movieCatalog.RemoveUser(this);
        }
        public void ReceiveNotification(string newRelease)
        {
            Console.WriteLine("Hello " + UserName + ", a new Movie is " + newRelease + " on Netflix. Now you can enjoy watching it.");
        }
    }
}
