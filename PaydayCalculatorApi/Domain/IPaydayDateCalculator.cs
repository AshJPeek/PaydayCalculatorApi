namespace PaydayCalculatorApi.Domain;

public interface IPaydayDateCalculator
{
    DateTime CalculatePaydayDate(DateTime startDate);
}