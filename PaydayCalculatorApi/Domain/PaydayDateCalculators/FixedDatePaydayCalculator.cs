namespace PaydayCalculatorApi.Domain.PaydayDateCalculators;

public class FixedDatePaydayCalculator : IPaydayDateCalculator
{
    public DateTime CalculatePaydayDate(DateTime startDate)
    {
        var fixedDatePayday = new DateTime();
        var year = startDate.Year;
        var month = startDate.Month;
        var monthDays = DateTime.DaysInMonth(year, month);
        const int chosenDate = 26;
        var dateFound = false;
        
        while (dateFound == false)
        {
            var currentDate = new DateTime(year, month, monthDays);

            if (currentDate.Day == chosenDate)
            {
                if (currentDate.DayOfWeek != DayOfWeek.Saturday && currentDate.DayOfWeek != DayOfWeek.Sunday)
                {
                    fixedDatePayday = currentDate;
                    dateFound = true;
                }
                else if (currentDate.DayOfWeek == DayOfWeek.Saturday)
                {
                    fixedDatePayday = currentDate.AddDays(-1);
                    dateFound = true;

                }
                else if (currentDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    fixedDatePayday = currentDate.AddDays(-2);
                    dateFound = true;

                }
            }
            else
            {
                monthDays--;
            }
        }

        return fixedDatePayday;
    }
}