using SimpleCalender.Interop;
using SimpleCalender.Utils;

// ReSharper disable SimplifyStringInterpolation

namespace SimpleCalender;

internal class CalendarDisplay : ICalendarDisplay
{
    public void Display(CalendarDateRange dateRange, string header)
    {
        Console.WriteLine(header);

        foreach (var day in dateRange.GetDaysInRange())
        {
            if (!day.IsDayOfMonth(dateRange))
            {
                Console.Write("   ");
            }
            else if (day.IsCurrentDate())
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{day.Day.ToString().PadLeft(2)} ");
                Console.ResetColor();
            }
            else
            {
                Console.Write($"{day.Day.ToString().PadLeft(2)} ");
            }

            if (day.IsEndOfWeek())
            {
                Console.WriteLine();
            }
        }
    }
}