using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace InventoryBrowser.Maui.Data;
    public class ProductContext : DbContext
    {
    protected readonly IConfiguration Configuration;
    public ProductContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(Configuration.GetConnectionString("ProductInventory"));
    }
    public DbSet<Product> Inventory { get; set; }
}
