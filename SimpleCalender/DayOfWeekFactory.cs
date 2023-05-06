using SimpleCalender.Globalization.DayOfWeek;
using SimpleCalender.Interop;

namespace SimpleCalender;

public abstract class DayOfWeekFactory
{
    public static IDayOfWeekProvider CreateDayOfWeek()
    {
        var currentCulture = System.Globalization.CultureInfo.CurrentCulture;

        return currentCulture.TwoLetterISOLanguageName switch
        {
            "ko" => new Korean(),
            "ja" or "zh" => new Asian(),
            _ => new Global()
        };
    }
}