using System.Net.Http.Json;

namespace InventoryBrowser.Maui.Data;

public class ProductList : IProductList
{
    private readonly HttpClient _httpClient = new ();
    public async Task<IEnumerable<Product>> LoadProductsAsync()
    {
        var products = await _httpClient.GetFromJsonAsync<IEnumerable<Product>>(
            "InventoryList.json");

        if (products == null)
        {
            return new List<Product>();
        }

        return products;
    }
}
