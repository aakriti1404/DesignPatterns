using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoDesignPattern
{
    public class PhoneCaseStorage
    {
        private List<PhoneCaseSavedState> _phoneCasesList = new List<PhoneCaseSavedState>();
        public void AddPhoneCase(PhoneCaseSavedState phoneCaseSavedState)
        {
            _phoneCasesList.Add(phoneCaseSavedState);
            Console.WriteLine("Older phone case is stored in storage room");
        }
        public PhoneCaseSavedState GetPhoneCaseSavedState(int index)
        {
            return _phoneCasesList[index];
        }
    }
}
