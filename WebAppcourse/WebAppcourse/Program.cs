using Microsoft.EntityFrameworkCore;
using WebAppcourse.Models;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext <Course>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("PlayersConStr")));

// Add services to the container.
builder.Services.AddControllersWithViews();
//
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
