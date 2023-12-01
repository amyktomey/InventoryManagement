using InventoryLibrary.Maui;
using InventoryLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace InventoryLibrary.Data;
public class ProductContext : DbContext
{
    public DbSet<Product>? Products { get; set; }
    public DbSet<ItemPart> ItemParts { get; set; }
    public DbSet<Component> Components { get; set; }

    public string DbPath { get; private set; }

public ProductContext()
{
    var folder = Environment.SpecialFolder.Desktop;
    var path = Environment.GetFolderPath(folder);
    DbPath = Path.Join(path, "ProductInventory.db");
}
protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite($"Data Source=ProductInventorye.db");
    }
}
