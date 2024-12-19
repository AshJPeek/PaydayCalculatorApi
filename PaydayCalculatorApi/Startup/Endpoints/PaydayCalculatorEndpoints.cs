using Microsoft.AspNetCore.Http.HttpResults;
using PaydayCalculatorApi.Domain;
using PaydayCalculatorApi.Domain.Models;

namespace PaydayCalculatorApi.Startup.Endpoints;

public static class PaydayCalculatorEndpoints
{
    public static void MapPaydayCalculatorEndpoints(this IEndpointRouteBuilder endpointRouteBuilder)
    {
        var paydayCalculatorGroup = endpointRouteBuilder.MapGroup("/payday-dates")
            .WithOpenApi()
            .WithTags("Payday dates");

        paydayCalculatorGroup.MapPost("/", async Task<Results<Ok<DateTime>, BadRequest>> (CreatePaydayDateRequest request, PaydayDateCalculatorFactory factory) =>
        {
            var paydayDateCalculator = factory.Create(request.PaydayDateCalculationType);
            var paydayDate = paydayDateCalculator.CalculatePaydayDate(DateTime.UtcNow);
            return TypedResults.Ok(paydayDate);
        }).WithName("CreatePaydayDate").WithSummary("Given a payment schedule, creates a payday date and stores it in the database");
    }
}

public record CreatePaydayDateRequest
{
    public required PaydayDateCalculationType PaydayDateCalculationType { get; init; }
}