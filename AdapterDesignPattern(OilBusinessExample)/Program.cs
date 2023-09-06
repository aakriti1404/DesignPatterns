// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern_OilBusinessExample_
{
    public class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the quantity of oil in gallons you want to purchase: ");
            if (double.TryParse(Console.ReadLine(), out double gallons))
            {
                // Create an instance of OilInGallonAdapter
                IOilInGallon oilInGallon = new OilInGallonAdapter();

                // Calculate the cost using the adapter
                double totalPrice = oilInGallon.BuyOilInGallon(gallons);

                Console.WriteLine($"The total cost of {gallons} gallons of oil is: "+totalPrice+" dollars.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid numeric value.");
            }

        }
    }

}