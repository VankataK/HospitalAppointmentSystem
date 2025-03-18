using HospitalAppointmentSystem.Data;
using HospitalAppointmentSystem.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<HospitalDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services
     .AddIdentity<ApplicationUser, IdentityRole<Guid>>(options =>
     {
         options.User.RequireUniqueEmail = true;
         options.SignIn.RequireConfirmedAccount = false;
         options.Password.RequireNonAlphanumeric = false;
         options.Password.RequireDigit = false;
         options.Password.RequireLowercase = false;
         options.Password.RequireUppercase = false;
     })
    .AddRoles<IdentityRole<Guid>>()
    .AddEntityFrameworkStores<HospitalDbContext>()
    .AddDefaultUI();

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var dbContext = services.GetRequiredService<HospitalDbContext>();
}

app.Run();
