using Domain;
using System.Collections.Generic;
using System.Linq;

namespace Business
{
    public class CalendarRepository : ICalendarRepository
    {
        public IEnumerable<Calendar> GetAllCalendars()
        {
            return new[] { new Calendar { CalendarId = 1, Owner = "John Doe" }, new Calendar { CalendarId = 2, Owner = "Jane Doe" } };
        }

        public Calendar GetCalendar(int calendarId)
        {
            return GetAllCalendars().FirstOrDefault(calendar => calendar.CalendarId == calendarId);
        }
    }
}
