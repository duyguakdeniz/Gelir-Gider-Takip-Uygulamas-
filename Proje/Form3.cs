using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Proje
{
    public partial class Form3 : Form
    {
        private System.Timers.Timer reminderTimer;
        private List<Reminder> reminders = new List<Reminder>();
        public Form3()
        {
            InitializeComponent();
            SetupReminderTimer();
        }

        private void btn_anasayfa_Click(object sender, EventArgs e)
        {
            Form1 yeni = new Form1();
            yeni.Show();
            this.Hide();
        }

        private void btn_istatistik_Click(object sender, EventArgs e)
        {
            Form2 yeni = new Form2();
            yeni.Show();
            this.Hide();
        }
        private void SetupReminderTimer()
        {
            reminderTimer = new System.Timers.Timer(30000);
            reminderTimer.Elapsed += CheckReminders;
            reminderTimer.AutoReset = true;
            reminderTimer.Enabled = true;
        }

        private void CheckReminders(object sender, ElapsedEventArgs e)
        {
            DateTime now = DateTime.Now;
            List<Reminder> remindersToRemove = new List<Reminder>();

            foreach (var reminder in reminders)
            {
                if (reminder.ReminderTime <= now)
                {
                    ShowNotification(reminder.Message);
                    remindersToRemove.Add(reminder);
                }
            }

            foreach (var reminder in remindersToRemove)
            {
                reminders.Remove(reminder);
            }
        }

        private void ShowNotification(string message)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(ShowNotification), new object[] { message });
                return;
            }
            MessageBox.Show(message, "Hatırlatıcı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAddReminder_Click(object sender, EventArgs e)
        {
            DateTime reminderTime = dateTimePickerReminder.Value;
            string message = txtReminderMessage.Text;

            reminders.Add(new Reminder(reminderTime, message));
            MessageBox.Show("Hatırlatıcı eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
