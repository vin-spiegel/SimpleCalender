namespace SimpleCalender;

/// <summary xml:lang="ko">
/// 현재 월의 날짜 범위와 첫 주의 일요일 및 마지막 주의 토요일을 설정합니다.
/// </summary>
public struct CalendarDateRange
{
    public DateTime FirstDayOfMonth { get; }
    public DateTime LastDayOfMonth { get; }
    public DateTime FirstSunday { get; }
    public DateTime LastSaturday { get; }

    public CalendarDateRange()
    {
        var currentDate = DateTime.Now;
        FirstDayOfMonth = new DateTime(currentDate.Year, currentDate.Month, 1);
        LastDayOfMonth = FirstDayOfMonth.AddMonths(1).AddDays(-1);
        FirstSunday = FirstDayOfMonth.AddDays(-(int)FirstDayOfMonth.DayOfWeek);
        LastSaturday = LastDayOfMonth.AddDays(6 - (int)LastDayOfMonth.DayOfWeek);
    }
}