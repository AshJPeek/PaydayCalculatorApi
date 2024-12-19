namespace PaydayCalculatorApi.Domain.PaydayDateCalculators;

public class LastFridayPaydayCalculator : IPaydayDateCalculator
{
    public DateTime CalculatePaydayDate(DateTime startDate)
    {
        var year = startDate.Year;
        var month = startDate.Month;
        var monthDays = DateTime.DaysInMonth(year, month);
        var fridayPayday = new DateTime();
        var dateFound = false;

        while (dateFound == false)
        {
            var currentDate = new DateTime(year, month, monthDays);

            if (currentDate.DayOfWeek == DayOfWeek.Friday)
            {
                fridayPayday = currentDate;
                dateFound = true;
            }
            else
            {
                monthDays--;
            }

        }

        return fridayPayday;
    }
}