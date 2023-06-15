using System.Collections.Immutable;
using TukiTukiBackend.Models;

namespace TukiTukiBackend.Services;

public class ProductService : ICRUDService<Product>
{
    private List<Product> _products = new List<Product>()
    {
        new Product(){id=1, title = "prueba", price = "70", details = "prueba1"}
    };

    public IEnumerable<Product> getAll()
    {
        return _products;
    }

    public Product? getById(int id)
    {
        throw new NotImplementedException();
    }

    public Product create(Product product)
    {
        _products.Add(product);
        return product;

    }

    public void delete(int id)
    {
        throw new NotImplementedException();
    }
    public Product? findById(int id)
    {
        return _products.Find(item => item.id == id);
    }
}