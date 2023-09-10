// See https://aka.ms/new-console-template for more information
using System;
namespace ChainOfResponsibilityPattern
{
    public class Program 
    {
        public static void Main(string[] args)
        {
            var emailHandler = new EmailNotificationHandler();
            var smsHandler = new SMSNotificationHandler();
            var webHandler = new WebNotificationHandler();  

            emailHandler.SetNextHandler(smsHandler);
            smsHandler.SetNextHandler(webHandler);

            var notification1 = new Notification("Low-priority notification", Priority.Low);
            var notification2 = new Notification("Normal-priority notification", Priority.Normal);
            var notification3 = new Notification("High-priority notification", Priority.High);

            emailHandler.HandleNotification(notification1);
            emailHandler.HandleNotification(notification2);
            emailHandler.HandleNotification(notification3);
        }
    }
}

