using PaydayCalculatorApi.Startup;
using PaydayCalculatorApi.Startup.Endpoints;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSwagger();
builder.Services.AddServices();
builder.Services.AddJsonOptions();

var app = builder.Build();

app.UseOptionedSwagger();
app.UseHttpsRedirection();
app.MapPaydayCalculatorEndpoints();
app.Run();
