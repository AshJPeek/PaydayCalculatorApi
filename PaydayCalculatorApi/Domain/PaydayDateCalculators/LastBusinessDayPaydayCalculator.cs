namespace PaydayCalculatorApi.Domain.PaydayDateCalculators;

public class LastBusinessDayPaydayCalculator : IPaydayDateCalculator
{
    public DateTime CalculatePaydayDate(DateTime startDate)
    {
        var year = startDate.Year;
        var month = startDate.Month;
        
        var finalBusinessPayday = new DateTime();                              
        var monthDays = DateTime.DaysInMonth(year, month);
        var dateFound = false;


        while (dateFound == false)
        {
            var currentDate = new DateTime(year, month, monthDays);
            if (currentDate.DayOfWeek < DayOfWeek.Saturday && currentDate.DayOfWeek > DayOfWeek.Sunday)
            {
                finalBusinessPayday = currentDate;
                dateFound = true;
            }
            else
            {
                monthDays--;
            }
        }
        return finalBusinessPayday;
    }    
}