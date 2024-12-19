using System.Text.Json.Serialization;

namespace PaydayCalculatorApi.Startup;

public static class JsonExtensions
{
    public static IServiceCollection AddJsonOptions(this IServiceCollection services)
    {
        services.Configure<Microsoft.AspNetCore.Mvc.JsonOptions>(options =>
        {
            options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
        });

        services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>(options =>
        {
            options.SerializerOptions.Converters.Add(new JsonStringEnumConverter());
        });
        
        return services;
    }
}