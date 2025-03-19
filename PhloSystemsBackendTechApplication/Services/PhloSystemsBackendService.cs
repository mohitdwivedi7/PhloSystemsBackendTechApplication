using PhloSystemsBackendTechApplication.Models;
namespace PhloSystemsBackendTechApplication.Services;

public class PhloSystemsBackendService
{
    private readonly List<PhloSystemsBackendProduct> _products = new List<PhloSystemsBackendProduct>
    {
        new PhloSystemsBackendProduct { Title = "A Red Trouser", Price = 10, Sizes = new List<string> { "small", "medium", "large" }, Description = "This trouser perfectly pairs with a green shirt." },
        new PhloSystemsBackendProduct { Title = "A Green Trouser", Price = 11, Sizes = new List<string> { "small" }, Description = "This trouser perfectly pairs with a blue shirt." },
        new PhloSystemsBackendProduct { Title = "A Blue Trouser", Price = 12, Sizes = new List<string> { "medium" }, Description = "This trouser perfectly pairs with a red shirt." },
        new PhloSystemsBackendProduct { Title = "A Red Trouser", Price = 13, Sizes = new List<string> { "large" }, Description = "This trouser perfectly pairs with a green shirt." },
        new PhloSystemsBackendProduct { Title = "A Green Trouser", Price = 14, Sizes = new List<string> { "small", "medium" }, Description = "This trouser perfectly pairs with a blue shirt." },
        new PhloSystemsBackendProduct { Title = "A Blue Trouser", Price = 15, Sizes = new List<string> { "small", "large" }, Description = "This trouser perfectly pairs with a red shirt." },
        new PhloSystemsBackendProduct { Title = "A Red Trouser", Price = 16, Sizes = new List<string> { "small", "large" }, Description = "This trouser perfectly pairs with a green shirt." },
        new PhloSystemsBackendProduct { Title = "A Green Trouser", Price = 17, Sizes = new List<string> { }, Description = "This trouser perfectly pairs with a blue shirt." },
        new PhloSystemsBackendProduct { Title = "A Blue Trouser", Price = 18, Sizes = new List<string> { "small", "medium", "large" }, Description = "This trouser perfectly pairs with a red belt." },
        new PhloSystemsBackendProduct { Title = "A Red Trouser", Price = 19, Sizes = new List<string> { "small" }, Description = "This trouser perfectly pairs with a green belt." },
        new PhloSystemsBackendProduct { Title = "A Green Trouser", Price = 20, Sizes = new List<string> { "medium" }, Description = "This trouser perfectly pairs with a blue belt." },
        new PhloSystemsBackendProduct { Title = "A Blue Trouser", Price = 21, Sizes = new List<string> { "large" }, Description = "This trouser perfectly pairs with a red belt." },
        new PhloSystemsBackendProduct { Title = "A Red Trouser", Price = 22, Sizes = new List<string> { "small", "medium" }, Description = "This trouser perfectly pairs with a green belt." },
        new PhloSystemsBackendProduct { Title = "A Green Trouser", Price = 23, Sizes = new List<string> { "small", "large" }, Description = "This trouser perfectly pairs with a blue belt." },
        new PhloSystemsBackendProduct { Title = "A Blue Trouser", Price = 24, Sizes = new List<string> { "medium", "large" }, Description = "This trouser perfectly pairs with a red belt." },
        new PhloSystemsBackendProduct { Title = "A Green Trouser", Price = 25, Sizes = new List<string> { }, Description = "This trouser perfectly pairs with a green belt." },
        new PhloSystemsBackendProduct { Title = "A Green Shirt", Price = 10, Sizes = new List<string> { "small", "medium", "large" }, Description = "This shirt perfectly pairs with a blue hat." },
        new PhloSystemsBackendProduct { Title = "A Blue Shirt", Price = 11, Sizes = new List<string> { "small" }, Description = "This shirt perfectly pairs with a red hat."},
        new PhloSystemsBackendProduct { Title = "A Red Shirt", Price = 12, Sizes = new List<string> { "medium" }, Description = "This shirt perfectly pairs with a green hat." },
        new PhloSystemsBackendProduct { Title = "A Green Shirt", Price = 13, Sizes = new List<string> { "large" }, Description = "This shirt perfectly pairs with a blue hat." },
        new PhloSystemsBackendProduct { Title = "A Blue Shirt", Price = 14, Sizes = new List<string> { "small", "medium" }, Description = "This shirt perfectly pairs with a red hat." },
        new PhloSystemsBackendProduct { Title = "A Red Shirt", Price = 15, Sizes = new List<string> { "small", "large" }, Description = "This shirt perfectly pairs with a green hat." },
        new PhloSystemsBackendProduct { Title = "A Green Shirt", Price = 16, Sizes = new List<string> { "medium", "large" }, Description = "This shirt perfectly pairs with a blue hat." },
        new PhloSystemsBackendProduct { Title = "A Blue Shirt", Price = 17, Sizes = new List<string> {}, Description = "This shirt perfectly pairs with a red hat." },
        new PhloSystemsBackendProduct { Title = "A Red Shirt", Price = 18, Sizes = new List<string> { "small", "medium", "large" }, Description = "This shirt perfectly pairs with a green bag." },
        new PhloSystemsBackendProduct { Title = "A Green Shirt", Price = 19, Sizes = new List<string> { "small" }, Description = "This shirt perfectly pairs with a blue bag." },
        new PhloSystemsBackendProduct { Title = "A Blue Shirt", Price = 20, Sizes = new List<string> { "medium" }, Description = "This shirt perfectly pairs with a red bag." },
        new PhloSystemsBackendProduct { Title = "A Red Shirt", Price = 21, Sizes = new List<string> { "large" }, Description = "This shirt perfectly pairs with a green bag." },
        new PhloSystemsBackendProduct { Title = "A Green Shirt", Price = 22, Sizes = new List<string> { "small", "medium" }, Description = "This shirt perfectly pairs with a blue bag." },
        new PhloSystemsBackendProduct { Title = "A Blue Shirt", Price = 23, Sizes = new List<string> { "small", "large" }, Description = "This shirt perfectly pairs with a red bag." },
        new PhloSystemsBackendProduct { Title = "A Red Shirt", Price = 24, Sizes = new List<string> { "medium", "large" }, Description = "This shirt perfectly pairs with a green bag." },
        new PhloSystemsBackendProduct { Title = "A Green Shirt", Price = 25, Sizes = new List<string> {}, Description = "This shirt perfectly pairs with a blue bag." },
        new PhloSystemsBackendProduct { Title = "A Blue Hat", Price = 10, Sizes = new List<string> { "small", "medium", "large" }, Description = "This hat perfectly pairs with a red shoe." },
        new PhloSystemsBackendProduct { Title = "A Red Hat", Price = 11, Sizes = new List<string> { "small" }, Description = "This hat perfectly pairs with a green shoe." },
        new PhloSystemsBackendProduct { Title = "A Green Hat", Price = 12, Sizes = new List<string> { "medium" }, Description = "This hat perfectly pairs with a blue shoe." },
        new PhloSystemsBackendProduct { Title = "A Blue Hat", Price = 13, Sizes = new List<string> { "large" }, Description = "This hat perfectly pairs with a red shoe." },
        new PhloSystemsBackendProduct { Title = "A Red Hat", Price = 14, Sizes = new List<string> { "small", "medium" }, Description = "This hat perfectly pairs with a green shoe." },
        new PhloSystemsBackendProduct { Title = "A Green Hat", Price = 15, Sizes = new List<string> { "small", "large" }, Description = "This hat perfectly pairs with a blue shoe." },
        new PhloSystemsBackendProduct { Title = "A Blue Hat", Price = 16, Sizes = new List<string> { "medium", "large" }, Description = "This hat perfectly pairs with a red shoe." },
        new PhloSystemsBackendProduct { Title = "A Red Hat", Price = 17, Sizes = new List<string> {}, Description = "This hat perfectly pairs with a green shoe." },
        new PhloSystemsBackendProduct { Title = "A Green Hat", Price = 18, Sizes = new List<string> { "small", "medium", "large" }, Description = "This hat perfectly pairs with a blue tie." },
        new PhloSystemsBackendProduct { Title = "A Blue Hat", Price = 19, Sizes = new List<string> { "small" }, Description = "This hat perfectly pairs with a red tie." },
        new PhloSystemsBackendProduct { Title = "A Red Hat", Price = 20, Sizes = new List<string> { "medium" }, Description = "This hat perfectly pairs with a green tie." },
        new PhloSystemsBackendProduct { Title = "A Green Hat", Price = 21, Sizes = new List<string> { "large" }, Description = "This hat perfectly pairs with a blue tie." },
        new PhloSystemsBackendProduct { Title = "A Blue Hat", Price = 22, Sizes = new List<string> { "small", "medium" }, Description = "This hat perfectly pairs with a red tie." },
        new PhloSystemsBackendProduct { Title = "A Red Hat", Price = 23, Sizes = new List<string> { "small", "large" }, Description = "This hat perfectly pairs with a green tie." },
        new PhloSystemsBackendProduct { Title = "A Green Hat", Price = 24, Sizes = new List<string> { "medium", "large" }, Description = "This hat perfectly pairs with a blue tie." },
        new PhloSystemsBackendProduct { Title = "A Blue Hat", Price = 25, Sizes = new List<string> {}, Description = "This hat perfectly pairs with a red tie." }
    };

    // Method to get filtered products
    public IEnumerable<PhloSystemsBackendProduct> GetProductDetails(decimal? minprice, decimal? maxprice, string? size, string? highlight)
    {
        var productData = _products.AsEnumerable();

        if (minprice.HasValue)
            productData = productData.Where(p => p.Price >= minprice.Value);

        if (maxprice.HasValue)
            productData = productData.Where(p => p.Price <= maxprice.Value);

        if (!string.IsNullOrEmpty(size))
            productData = productData.Where(p => p.Sizes.Contains(size, StringComparer.OrdinalIgnoreCase));

        if (!string.IsNullOrEmpty(highlight))
        {
            var highlightWords = highlight.Split(',').Select(word => word.Trim()).ToList();
            productData = productData.Where(p => highlightWords.Any(word => p.Description.Contains(word, StringComparison.OrdinalIgnoreCase)));
        }

        return productData;
    }
}