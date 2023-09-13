using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodDesignPattern
{
    public abstract class OnlineShoppingCheckoutTemplate
    {
        public void OnlineShoppingCheckout() 
        {
            AddItemToCart();
            SetShippingDetails();
            MakePayment();
            PlaceOrder();
        }
        protected abstract void AddItemToCart();
        protected abstract void SetShippingDetails();
        protected abstract void MakePayment();
        protected abstract void PlaceOrder();
    }
}
