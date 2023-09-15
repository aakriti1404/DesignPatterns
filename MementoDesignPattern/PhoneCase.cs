using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoDesignPattern
{
    public class PhoneCase
    {
        public string price {  get; set; }
        public string color { get; set; }

        public PhoneCase(string price, string color)
        {
            this.price = price;
            this.color = color;
        }
        public string GetDetails()
        {
            return "Phone case [Price= " + price + " , Color= " + color + "]";
        }
    }
}
