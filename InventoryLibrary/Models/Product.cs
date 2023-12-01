namespace InventoryLibrary.Maui;

public class Product
{
    public int ProductID { get; set; }
    public string? Name { get; set; }
    public string? Type { get; set; }
    public decimal Price { get; set; }
    public string? Description { get; set; }
    public int Quantity { get; set; }
}