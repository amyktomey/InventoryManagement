namespace InventoryBrowser.Maui.Data;

public interface IProductList
{
    Task<IEnumerable<Product>?> LoadProductsAsync();
}
