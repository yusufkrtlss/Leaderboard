
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer;
using DataAccessLayer.Abstarct;
using DataAccessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework.Context;

using EntityLayer.Concrete;
using Leaderboard.Controllers;
using Serilog;


var builder = WebApplication.CreateBuilder(args);

// Serilog
Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .WriteTo.File("log.txt")
    .WriteTo.Seq("http://localhost:5341/")
    .CreateLogger();
builder.Host.UseSerilog();

// Add scoped service in Program.cs
builder.Services.AddDbContext<LeaderboardDb>();
builder.Services.AddTransient<IUnitofWork, UnitofWork>();
builder.Services.AddTransient<IUserService, UserManager>();
builder.Services.AddTransient<ILeaderboardService, LeaderboardManager>();


// Add services to the container.
builder.Services.AddControllersWithViews();

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
