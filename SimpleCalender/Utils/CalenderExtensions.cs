namespace SimpleCalender.Utils;

public static class CalenderExtensions
{
    public static bool IsDayOfMonth(this DateTime date, CalendarDateRange dateRange)
    {
        return date >= dateRange.FirstDayOfMonth && date <= dateRange.LastDayOfMonth;
    }

    public static bool IsCurrentDate(this DateTime date)
    {
        return date.Date == DateTime.Now.Date;
    }

    public static bool IsEndOfWeek(this DateTime date)
    {
        return date.DayOfWeek == DayOfWeek.Saturday;
    }
    
    public static IEnumerable<DateTime> GetDaysInRange(this CalendarDateRange dateRange)
    {
        for (var date = dateRange.FirstSunday; date <= dateRange.LastSaturday; date = date.AddDays(1))
        {
            yield return date;
        }
    }
}