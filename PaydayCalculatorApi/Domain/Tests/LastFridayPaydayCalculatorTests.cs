using NUnit.Framework;
using PaydayCalculatorApi.Domain.PaydayDateCalculators;

namespace PaydayCalculatorApi.Domain.Tests;

[TestFixture]

public class LastFridayPaydayCalculatorTests()
{
    [Test]
    public void CalculatePaydayDate()
    {
        var lastFridayPaydayCalculator = new LastFridayPaydayCalculator();
        var result = lastFridayPaydayCalculator.CalculatePaydayDate(DateTime.Now);
        var expectedResult = new DateTime (2024, 12, 27);
        
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}