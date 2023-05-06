using SimpleCalender.Interop;

namespace SimpleCalender.Globalization.DayOfWeek;

public class Korean : IDayOfWeekProvider
{
    public string GetStrings()
    {
        return "일 월 화 수 목 금 토";
    }
}