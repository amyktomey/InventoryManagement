namespace InventoryBrowser.Maui.Data;

//public record Product(string Name, string Type, string Description, decimal Price, int Quantity);
public class Product
{
    public int Id { get; set; }
    public string?Name { get; set; }
    public string? Type { get; set; }
    public string?Description{ get; set; }
    public decimal? Price{ get; set; }
    public int? Quantity { get; set; }
}
