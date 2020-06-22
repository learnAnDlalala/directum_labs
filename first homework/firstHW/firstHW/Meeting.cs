using System.Threading.Channels;

namespace FirstHW
{
    using System;

    /// <summary>
    /// Meeting class includes Start, End and Duration of meeting
    /// </summary>
    public class Meeting
    {
        /// <summary>
        /// Gets or sets the date of beginning meeting in format yyyy,mm,dd,hh,mm,ss
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets the date of ending meeting in format yyyy,mm,dd,hh,mm,ss
        /// </summary>
        public virtual DateTime EndDate { get; set; }

        /// <summary>
        /// format yyyy,mm,dd,hh,mm,ss (calculated automatically)
        /// </summary>
        public virtual TimeSpan Duration => this.EndDate.Subtract(this.StartDate);
    }

    public class MeetingWithOutEnd : Meeting
    {
        public new DateTime? EndDate { get; set; }
        public new TimeSpan? Duration => this.EndDate == null ? null : this.EndDate - this.StartDate;
    }
}