namespace SimpleCalender.Interop;

internal interface ICalendarDisplay
{
    void Display(CalendarDateRange dateRange, string header);
}