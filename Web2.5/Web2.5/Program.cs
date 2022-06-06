using Microsoft.EntityFrameworkCore;
using Web2._5.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<HospitalContext>( (options) => 
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DataBaseConnection")
    )
);

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
