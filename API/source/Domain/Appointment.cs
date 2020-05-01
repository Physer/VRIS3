using System;
using System.Collections.Generic;

namespace Domain
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Owner { get; set; }
        public IEnumerable<string> Attendees { get; set; }
    }
}
