// See https://aka.ms/new-console-template for more information
using System;
namespace MementoDesignPattern
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            PhoneCaseUser user = new PhoneCaseUser
            {
                _phoneCase = new PhoneCase("150 rupees", "white")
            };
            PhoneCaseStorage storage = new PhoneCaseStorage();
            PhoneCaseSavedState phoneCaseSavedState = user.StorePhoneCase();
            storage.AddPhoneCase(phoneCaseSavedState);

            user._phoneCase = new PhoneCase("100 rupees", "blue");
            Console.WriteLine("\nCurrent phone case: " + user.GetDetails());

            Console.WriteLine("\nPhone Case restored to 150 rupees white case");
            user.UseOldPhoneCase(storage.GetPhoneCaseSavedState(0));
            Console.WriteLine("\nCurrent phone case: "+user.GetDetails());
            Console.Read();
        }
    }
}