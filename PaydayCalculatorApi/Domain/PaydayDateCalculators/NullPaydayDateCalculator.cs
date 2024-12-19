namespace PaydayCalculatorApi.Domain.PaydayDateCalculators;

public class NullPaydayDateCalculator : IPaydayDateCalculator
{
    public DateTime CalculatePaydayDate(DateTime startDate)
    {
        return startDate;
    }
}