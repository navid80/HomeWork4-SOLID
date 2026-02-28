using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3
{
    public class EmailService : INotification
    {
        public void SendMessage(string message, string to)
        {
            Console.WriteLine($"Email sent to {to} => {message}");
        }
    }
}
