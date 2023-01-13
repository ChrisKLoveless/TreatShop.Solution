using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace TreatShop.Models 
{
  public class TreatShopContext : IdentityDbContext<ApplicationUser> 
  {
    public DbSet<Treat> Treats { get; set; } 
    public DbSet<Flavor> Flavors { get; set; } 
    public DbSet<TreatFlavor> TreatFlavors { get; set; } 
    public TreatShopContext(DbContextOptions options) : base(options) { } 
  }
}