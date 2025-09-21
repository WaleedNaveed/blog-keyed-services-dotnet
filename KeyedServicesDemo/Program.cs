using KeyedServicesDemo.Interfaces;
using KeyedServicesDemo.Services;
using KeyedServicesDemo;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// OLD WAY
builder.Services.AddScoped<IPaymentService, StripePaymentService>();
builder.Services.AddScoped<IPaymentService, PaypalPaymentService>();
builder.Services.AddScoped<OldWayPaymentFactory>();

// NEW WAY (KEYED SERVICES)
builder.Services.AddKeyedScoped<IPaymentService, StripePaymentService>("Stripe");
builder.Services.AddKeyedScoped<IPaymentService, PaypalPaymentService>("PayPal");

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
