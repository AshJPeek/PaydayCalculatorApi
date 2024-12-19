using PaydayCalculatorApi.Domain;
using PaydayCalculatorApi.Domain.PaydayDateCalculators;

namespace PaydayCalculatorApi.Startup;

public static class ServiceExtensions
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<PaydayDateCalculatorFactory>();
        services.AddScoped<NullPaydayDateCalculator>();

        return services;
    }
}