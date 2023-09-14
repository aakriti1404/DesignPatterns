// See https://aka.ms/new-console-template for more information
using System;
namespace StrategyDesignPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IPayment paymentGateway = new CreditCardPayment();
            SelectPaymentGateway selectPaymentGateway = new SelectPaymentGateway(paymentGateway);
            selectPaymentGateway.PayNCheckout("Credit Card");

            selectPaymentGateway.SetPaymentGateway(new PayPalPayment());
            selectPaymentGateway.PayNCheckout("PayPal");

            selectPaymentGateway.SetPaymentGateway(new SodexoPayment());
            selectPaymentGateway.PayNCheckout("Sodexo");

        }
    }
}
