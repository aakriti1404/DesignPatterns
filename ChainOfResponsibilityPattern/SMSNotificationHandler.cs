using ChainOfResponsibilityPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SMSNotificationHandler : INotificationHandler
{
    private INotificationHandler NextHandler;
    public void SetNextHandler(INotificationHandler handler)
    {
        NextHandler = handler;
    }
    public void HandleNotification(Notification notification)
    {
        if (notification._priority == Priority.High)
        {
            Console.WriteLine("Sending SMS for high-priority notification: " + notification.Message);
        }
        else if (NextHandler != null)
        {
            NextHandler.HandleNotification(notification);
        }
    }
}
