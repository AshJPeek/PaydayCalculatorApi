using NUnit.Framework;
using PaydayCalculatorApi.Domain.PaydayDateCalculators;

namespace PaydayCalculatorApi.Domain.Tests;

[TestFixture]

public class FixedDatePaydayCalculatorTests
{
    [Test]
    public void CalculatePaydayDate()
    {
        var fixedDatePaydayCalculator = new FixedDatePaydayCalculator();
        var result = fixedDatePaydayCalculator.CalculatePaydayDate(DateTime.Now);
        var expectedResult = new DateTime (2024, 12, 26);
        
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}