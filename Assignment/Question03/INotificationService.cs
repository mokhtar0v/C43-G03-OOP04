using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Question03
{
    interface INotificationService
    {
        void SendNotification(string? recipient, string? message);
    }
}
