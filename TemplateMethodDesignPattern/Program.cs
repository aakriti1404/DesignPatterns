// See https://aka.ms/new-console-template for more information
using System;
namespace TemplateMethodDesignPattern
{
    public class Program
    {
        public static void Main(string[] agrs)
        {
            Console.WriteLine("Using Gpay payment gateway for checking out from online shopping.\n");
            OnlineShoppingCheckoutTemplate onlineShopping = new GpayPaymentGateway();
            onlineShopping.OnlineShoppingCheckout();

            Console.WriteLine();

            Console.WriteLine("Using credit card for making payment to check out from online shopping.\n");
            onlineShopping = new CreditCardPaymentGateway();
            onlineShopping.OnlineShoppingCheckout();

            Console.Read();
        }
    }
}   
