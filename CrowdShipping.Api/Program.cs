using ClassLibrary1.core.Entities;
using ClassLibrary1.core.IRepository;
using ClassLibrary1.core.IService;
using Crowdshipping.Data;
using Crowdshipping.Data.Repository;
using Crowdshipping.Service.services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IShipmentService,ShipmentService>();
builder.Services.AddScoped<ICourierService,CourierService>();
builder.Services.AddScoped<IPackageOrdererService,PackageOrdererService>();
builder.Services.AddScoped<IPaymentService,PaymentService>();
builder.Services.AddScoped<IGenericRepository<Shipment>,ShipmentRepository>();
builder.Services.AddScoped<IGenericRepository<Courier>,CourierRepository > ();
builder.Services.AddScoped<IGenericRepository<PackageOrderer>, PackageOrdererRepository > ();
builder.Services.AddScoped<IGenericRepository<Payment> ,PaymentRepository > ();



builder.Services.AddDbContext<DataContext>(option =>
{
    option.UseSqlServer("Data Source=DESKTOP-SSNMLFD;Initial Catalog=CrowdshippingDB;Integrated Security=true;");
}
       );

//builder.Services.AddSingleton<DataContext>();
//builder.Services.AddSingleton<DataContext>();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
