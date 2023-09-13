﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodDesignPattern
{
    public class GpayPaymentGateway : OnlineShoppingCheckoutTemplate
    {
        protected override void AddItemToCart()
        {
            Console.WriteLine("Adding items to your cart.");
        }
        protected override void SetShippingDetails()
        {
            Console.WriteLine("Setting the shipping details.");
        }
        protected override void MakePayment()
        {
            Console.WriteLine("Making payment through Gpay payment gateway.");
        }
        protected override void PlaceOrder()
        {
            Console.WriteLine("Confirming the order by clicking on order button.");
        }
    }
}
