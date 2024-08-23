using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje
{
    internal class Reminder
    {
        public DateTime ReminderTime { get; set; }
        public string Message { get; set; }

        public Reminder(DateTime reminderTime, string message)
        {
            ReminderTime = reminderTime;
            Message = message;
        }
    }
}
