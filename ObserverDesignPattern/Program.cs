// See https://aka.ms/new-console-template for more information
using System;
namespace ObserverDesignPattern
{
    public class Program 
    {
        public static void Main(string[] args)
        {
            MovieCatalog movieCatalog = new MovieCatalog("Comedy","Rohit Shetty", "Shah Rukh Khan", "Deepika Padukone", "No New Release");
            
            User aakriti = new User("Aakriti");
            aakriti.AddUser(movieCatalog);

            User manaswini = new User("Manaswini");
            manaswini.AddUser(movieCatalog);

            User sandhya = new User("Sandhya");
            sandhya.AddUser(movieCatalog);

            Console.WriteLine("Movie Catalog current state : " + movieCatalog.GetNewReleaseNotification());
            Console.WriteLine();

            sandhya.RemoveUser(movieCatalog);

            movieCatalog.SetNewReleaseState("released");
            
            Console.Read();
        }
    }

}
