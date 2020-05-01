using Business;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalendarsController : ControllerBase
    {
        private readonly ICalendarRepository _calendarRepository;

        public CalendarsController(ICalendarRepository calendarRepository)
        {
            _calendarRepository = calendarRepository;
        }

        [HttpGet]
        public IActionResult GetCalendars() => Ok(_calendarRepository.GetAllCalendars());

        [HttpGet("{calendarId}")]
        public IActionResult GetAppointments(int calendarId) => Ok(_calendarRepository.GetCalendar(calendarId));
    }
}
