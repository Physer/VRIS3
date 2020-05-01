using System.Collections.Generic;

namespace Domain
{
    public class Calendar
    {
        public int CalendarId { get; set; }
        public string Owner { get; set; }
        public IEnumerable<Appointment> Appointments { get; set; } = new List<Appointment>();
    }
}
