using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    public class WebNotificationHandler : INotificationHandler
    {
        private INotificationHandler NextHandler;
        public void SetNextHandler(INotificationHandler handler)
        {
            NextHandler = handler;
        }
        public void HandleNotification(Notification notification)
        {
            if (notification._priority == Priority.Low)
            {
                Console.WriteLine("Sending web-notification for low-priority notification: " + notification.Message);
            }
            else if (NextHandler != null)
            {
                NextHandler.HandleNotification(notification);
            }
        }
    }
}
