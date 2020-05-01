using Domain;
using System.Collections.Generic;

namespace Business
{
    public interface ICalendarRepository
    {
        IEnumerable<Calendar> GetAllCalendars();
        Calendar GetCalendar(int calendarId);
    }
}