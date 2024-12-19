using Microsoft.OpenApi.Models;

namespace PaydayCalculatorApi.Startup;

public static class OpenApiExtensions
{
    public static IServiceCollection AddSwagger(this IServiceCollection services)
    {
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen(options =>
        {
            options.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "Payday date calculator",
                Description = "Calculates payday dates given a payday date calculation type are stores in a local database",
                Version = "1.0"
            });
        });
        
        return services;
    }

    public static WebApplication UseOptionedSwagger(this WebApplication app)
    {
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.DocumentTitle = "Payday date calculator API";   
            } );
        }
        
        return app;
    }
}