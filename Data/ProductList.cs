namespace InventoryBrowser.Maui.Data;

public class ProductList : IProductList
{
    public async Task<IEnumerable<Product>> LoadProductsAsync()
    {
        var products = new[]
        {
            new Product("Lover's Bane", "Potion", "Blood red & black potion with a gold spark for creating passion", 12, 4),
            new Product("Qilin", "Feat Charm", "Homebrew: +2 to AC, if dowmed HP drops to 1, not 0.", 10, 2),
            new Product("Hair of the Dog", "D&D Dice Set", "Dice set made with a little magic and werewolf hair", 18, 1)
        };

        await Task.Delay(50);

        return products;
    }
}
