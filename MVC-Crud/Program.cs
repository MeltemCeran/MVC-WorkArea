using Microsoft.EntityFrameworkCore;
using MVC_Crud.Models.Context;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MyDbContext>(opt=>opt.UseSqlServer
(builder.Configuration.GetConnectionString("conn")));

// Add services to the container.
builder.Services.AddControllersWithViews();

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
