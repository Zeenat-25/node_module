using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SecurityApp.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

using (var scope = app.Services.CreateScope())
{
    var roles = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

    if (!await roles.RoleExistsAsync("Admin"))
        await roles.CreateAsync(new IdentityRole("Admin"));

    if (!await roles.RoleExistsAsync("User"))
        await roles.CreateAsync(new IdentityRole("User"));
}

app.Run();