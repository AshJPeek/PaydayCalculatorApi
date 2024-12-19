using NUnit.Framework;
using PaydayCalculatorApi.Domain.PaydayDateCalculators;

namespace PaydayCalculatorApi.Domain.Tests;

[TestFixture]

public class FourWeeksPaydayCalculatorTests
{
    [Test]
    public void CalculatePaydayDate()
    {
        var fourWeeksPaydayCalculator = new FourWeeksPaydayCalculator();
        var result = fourWeeksPaydayCalculator.CalculatePaydayDate(DateTime.Now);
        var expectedResult = new DateTime (2024, 12, 30);
        
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}
