using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoDesignPattern
{
    public class PhoneCaseUser
    {
        public PhoneCase _phoneCase;
        public PhoneCaseSavedState StorePhoneCase()
        {
            return new PhoneCaseSavedState(_phoneCase);
        }

        public void UseOldPhoneCase(PhoneCaseSavedState phoneCaseSavedState)
        {
            _phoneCase = phoneCaseSavedState._phoneCase;
        }

        public string GetDetails()
        {
            return "Current [Phone Case = " + _phoneCase.GetDetails() + "]";
        }
    }
}
