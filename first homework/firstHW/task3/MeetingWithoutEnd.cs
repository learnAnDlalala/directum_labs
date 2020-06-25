namespace Task3
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using FirstHW;

    /// <summary>
    /// Встреча без окончания
    /// </summary>
    public class MeetingWithoutEnd : Meeting
    {
        /// <summary>
        /// Get or Set EndDate
        /// </summary>
        public new DateTime? EndDate { get; set; }

        /// <summary>
        /// Get or Set Duration
        /// </summary>
        public new TimeSpan? Duration => this.EndDate.HasValue ? null : (TimeSpan?)this.EndDate.Value.Subtract(this.StartDate);
    }
}
