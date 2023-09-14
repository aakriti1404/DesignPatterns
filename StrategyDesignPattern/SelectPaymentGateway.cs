using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    public class SelectPaymentGateway
    {
        private IPayment payment;
        public SelectPaymentGateway(IPayment payment)
        {
            this.payment = payment;
        }
        public void SetPaymentGateway(IPayment payment)
        {
            this.payment = payment;
        }
        public void PayNCheckout(string paymentMethodName)
        {
            payment.MakePayment(paymentMethodName);
        }
    }
}
