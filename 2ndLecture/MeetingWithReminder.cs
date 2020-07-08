namespace FirstHW
{
    using System;
    using System.Timers;

    /// <summary>
    /// Program class
    /// </summary>
    public class MeetingWithReminder : Meeting, IRemind
    {
        /// <summary>
        /// Announcement Timer for chek RemindDate
        /// </summary>
        private Timer check;

        /// <summary>
        /// Initializes a new instance of the MeetingWithReminder class.
        /// </summary>
        /// <param name="interval">interval of timer in ms</param>
        public MeetingWithReminder(int interval = 60000)
        {
            this.check = new Timer(interval);
            this.check.Elapsed += this.CheckDate;
            this.check.Enabled = true; 
            this.Remind += this.TurnOffCheck;
        }
        
        /// <summary>
        /// Private delegate for events in instance of MeetingWithReminder class.
        /// </summary>
        private delegate void ResultCheck();

        /// <summary>
        /// Private event. 
        /// </summary>
        private event ResultCheck Remind;

        /// <summary>
        /// Gets or sets ReminderDate
        /// </summary>
        public DateTime ReminderDate { get; set; }  // Было бы не плохо проверить, что напоминание устанавливается до окончания события.

        /// <summary>
        /// dsdsds sdsdsd // Что?
        /// </summary>
        /// <param name="source">The sourse</param>
        /// <param name="e">The 2ns argument</param>
        public void CheckDate(object source, ElapsedEventArgs e)
        {
            
            string now = DateTime.Now.ToString("g");  
            if (now == this.ReminderDate.ToString("g"))
            {
                this.Remind?.Invoke(); 
            }
        }

        /// <summary>
        /// Turn off check timer
        /// </summary>
        public void TurnOffCheck()
        {
            Console.WriteLine($"{this.StartDate} у вас встреча, напоминание отключенно");
            this.check.Enabled = false; // Лучше использовать метод Stop().
        }
    }
}
