namespace FirstHW
{
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    public partial class Program
    {
        public enum Type
        {
            [Description("встреча")] meeting,
            [Description("поручение")] commission,
            [Description("звонок")] call,
            [Description("день рождения")] birthDay
        }



        public class MeetingV2 : Meeting
        {

            public Type DateType { get; set; }
            public string GetTypeDescription() { return DateType.GetDescriprion(); }
        }
        public class MeetingBlankEndDate : Meeting
        {
            private string enddate;

            public new DateTime? EndDate { get { return DateTime.Now; } set { if (value == null) { enddate = "Неизвестно"; return; } enddate = EndDate.ToString(); } }
            public new DateTime? Duration { get; }

        }
    }
}
