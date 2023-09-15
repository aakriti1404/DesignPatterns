using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoDesignPattern
{
    public class PhoneCaseSavedState
    {
        public PhoneCase _phoneCase { get; set; }
        public PhoneCaseSavedState(PhoneCase phoneCase) 
        {
            _phoneCase=phoneCase;
        }
        public string GetDetails()
        {
            return "PhoneCaseSavedState [PhoneCase=" + _phoneCase.GetDetails() + "]";
        }
    }
}
