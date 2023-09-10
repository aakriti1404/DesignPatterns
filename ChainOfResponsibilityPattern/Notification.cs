using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    public class Notification
    {
        public string Message { get; }
        public Priority _priority { get; }
        public Notification(string message, Priority priority)
        {
            Message = message;
            _priority = priority;
        }
    }
}
