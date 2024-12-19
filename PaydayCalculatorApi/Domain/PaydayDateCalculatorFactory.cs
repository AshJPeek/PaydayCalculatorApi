using PaydayCalculatorApi.Domain.Models;
using PaydayCalculatorApi.Domain.PaydayDateCalculators;

namespace PaydayCalculatorApi.Domain;

public class PaydayDateCalculatorFactory
{
    public IPaydayDateCalculator Create(PaydayDateCalculationType paydayDateCalculationType)
    {
        return paydayDateCalculationType switch
        {
            PaydayDateCalculationType.FixedDate => new FixedDatePaydayCalculator(),
            PaydayDateCalculationType.EveryFourWeeks => new FourWeeksPaydayCalculator(),
            PaydayDateCalculationType.LastWorkingDayOfMonth => new LastBusinessDayPaydayCalculator(),
            PaydayDateCalculationType.LastFridayOfMonth => new LastFridayPaydayCalculator(),
            _ => new NullPaydayDateCalculator()
        };
    }
}