using SimpleCalender.Interop;

namespace SimpleCalender;

internal class Calendar
{
    private readonly CalendarDateRange _dateRange;
    
    public Calendar()
    {
        _dateRange = new CalendarDateRange();
    }

    public void DisplayCalendar(ICalendarDisplay calendarDisplay)
    {
        calendarDisplay.Display(_dateRange, GetDayOfWeekHeader());
    }

    private string GetDayOfWeekHeader()
    {
        var dayOfWeekProvider = DayOfWeekFactory.CreateDayOfWeek();
        return dayOfWeekProvider.GetStrings();
    }
}