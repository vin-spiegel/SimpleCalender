using SimpleCalender.Interop;

namespace SimpleCalender.Globalization.DayOfWeek;

public class Asian : IDayOfWeekProvider
{
    public string GetStrings()
    {
        return "日 月 火 水 木 金 土";
    }
}