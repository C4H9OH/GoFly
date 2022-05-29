using GoFly_web.Managers;
using GoFly_web.Managers.GoFlys;
using GoFly_web.Storage;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

// Add services to the container.
builder.Services.AddControllersWithViews();
//builder.Services.AddSingleton<GOflyContext>();
builder.Services.AddScoped<IItineraryManager, ItineraryManager>();

builder.Services.AddScoped<IArrivalCountryManager, ArrivalCountryManager>();

builder.Services.AddScoped<IDepartureCountryManager, DepartureCountryManager>();

builder.Services.AddScoped<IArrivalCityManager, ArrivalCityManager>();

builder.Services.AddScoped<IDepartureCityManager, DepartureCityManager>();

builder.Services.AddScoped<IHotelManager, HotelManager>();

// Add Database Context
//var connectionString = builder.Configuration.GetConnectionString("DbConnection");
var connectionString = builder.Configuration.GetConnectionString("DbConnection");

services.AddDbContext<GOflyContext>(param => param.UseSqlServer(connectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Plane}/{action=Plane}/{id?}");

app.Run();
