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
        public DateTime EndDate { get; set; }

        /// <summary>
        /// format yyyy,mm,dd,hh,mm,ss (calculated automatically)
        /// </summary>
        public TimeSpan Duration => this.EndDate.Subtract(this.StartDate);
    }
}
