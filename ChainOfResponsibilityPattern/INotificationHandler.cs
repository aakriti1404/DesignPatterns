using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    public interface INotificationHandler
    {
        void SetNextHandler(INotificationHandler handler);
        void HandleNotification(Notification notification);
    }
}
