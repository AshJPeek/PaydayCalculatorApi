namespace PaydayCalculatorApi.Domain.Models;

public enum PaydayDateCalculationType
{
    FixedDate,
    EveryFourWeeks,
    LastWorkingDayOfMonth,
    LastFridayOfMonth
}