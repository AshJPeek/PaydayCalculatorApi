using NUnit.Framework;
using PaydayCalculatorApi.Domain.PaydayDateCalculators;

namespace PaydayCalculatorApi.Domain.Tests;

[TestFixture]

public class LastBusinessDayPaydayCalculatorTests
{
    [Test]
    public void CalculatePaydayDate()
    {
        var lastBusinessDayPaydayCalculator = new LastBusinessDayPaydayCalculator();
        var result = lastBusinessDayPaydayCalculator.CalculatePaydayDate(DateTime.Now);
        var expectedResult = new DateTime (2024, 12, 31);
        
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}
