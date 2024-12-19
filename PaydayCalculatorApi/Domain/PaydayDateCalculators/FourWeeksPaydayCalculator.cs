namespace PaydayCalculatorApi.Domain.PaydayDateCalculators;

public class FourWeeksPaydayCalculator : IPaydayDateCalculator
{
    public DateTime CalculatePaydayDate(DateTime startDate)
    {
            var currentDay = new DateTime(startDate.Year, startDate.Month, startDate.Day);

            currentDay = currentDay.AddDays(28);
            var payDay = currentDay;
            
            return payDay;
    }    
}