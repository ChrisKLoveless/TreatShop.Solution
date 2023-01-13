using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TreatShop.Models;
using Microsoft.AspNetCore.Identity;

namespace TreatShop
{
  class Program
  {
    static void Main(string[] args)
    {

      WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

      builder.Services.AddControllersWithViews();

      builder.Services.AddDbContext<TreatShopContext>(
                        dbContextOptions => dbContextOptions
                          .UseMySql(
                            builder.Configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(builder.Configuration["ConnectionStrings:DefaultConnection"]
                          )
                        )
                      );

      builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
			.AddRoles<IdentityRole>()
			.AddEntityFrameworkStores<TreatShopContext>()
			.AddDefaultTokenProviders();

      builder.Services.Configure<IdentityOptions>(options =>
      {
        options.Password.RequireDigit = false;
        options.Password.RequireLowercase = false;
        options.Password.RequireNonAlphanumeric = false;
        options.Password.RequireUppercase = false;
        options.Password.RequiredLength = 0;
        options.Password.RequiredUniqueChars = 0;
        // Default Password settings.
        // options.Password.RequireDigit = true;
        // options.Password.RequireLowercase = true;
        // options.Password.RequireNonAlphanumeric = true;
        // options.Password.RequireUppercase = true;
        // options.Password.RequiredLength = 6;
        // options.Password.RequiredUniqueChars = 1;F
      });

      WebApplication app = builder.Build();

      // app.UseDeveloperExceptionPage();
      app.UseHttpsRedirection();
      app.UseStaticFiles();

      app.UseRouting();

      app.UseAuthentication();
      app.UseAuthorization();

      app.MapControllerRoute(
          name: "default",
          pattern: "{controller=Home}/{action=Index}/{id?}");

      app.Run();
    }
  }
}