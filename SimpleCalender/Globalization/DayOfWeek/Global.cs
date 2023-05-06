using SimpleCalender.Interop;

namespace SimpleCalender.Globalization.DayOfWeek;

public class Global : IDayOfWeekProvider
{
    public string GetStrings()
    {
        return "Su Mo Tu We Th Fr Sa";
    }
}