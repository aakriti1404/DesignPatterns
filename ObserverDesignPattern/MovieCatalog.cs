using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
    public class MovieCatalog : IMovieCatalog
    {
        private List<IUser> _user = new List<IUser>();

        private string _genres { get; set; }
        private string _directorName { get; set; }
        private string _actorName { get; set; }
        private string _actressName { get; set; }
        private string _newRelease { get; set; }

        public MovieCatalog(string genres, string directorName, string actorName, string actressName, string newRelease) 
        {
            _genres = genres;
            _directorName = directorName;
            _actorName = actorName;
            _actressName = actressName;
            _newRelease = newRelease;
        }

        //The following Method is going to return the State of the Product
        public string GetNewReleaseNotification()
        {
            return _newRelease;
        }
        //The following Method is going to set the State of the Product
        public void SetNewReleaseState(string newRelease)
        {
            this._newRelease = newRelease;
            Console.WriteLine("New release state changed from No New Release to New Release");
            NotifyUser();
        }
        public void RegisterUser(IUser user)
        {
            Console.WriteLine("Observer Added : " + ((User)user).UserName);
            _user.Add(user);
        }
        public void RemoveUser(IUser user)
        {
            Console.WriteLine("User Removed : " + ((User)user).UserName);
            _user.Remove(user);
        }
        public void NotifyUser()
        {
            Console.WriteLine("A new movie from of :"
                            + _directorName + ", "
                            + _actorName + ", "
                            + _actressName + " belonging to "+ _genres +" genre is now available on Netflix.");
            Console.WriteLine();
            foreach (IUser user in _user)
            {
                //By Calling the RecieveNotification method, we are sending notifications to observers
                user.ReceiveNotification(_newRelease);
            }
        }
    }
}
