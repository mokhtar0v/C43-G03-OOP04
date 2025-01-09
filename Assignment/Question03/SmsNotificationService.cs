using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Question03
{
    class SmsNotificationService : INotificationService
    {
        public void SendNotification(string? recipient, string? message)
        {
            Console.WriteLine($"SMS message: {message} sent to {recipient}");
        }
    }
}
