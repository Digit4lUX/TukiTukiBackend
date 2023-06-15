using System.Collections.Immutable;
using TukiTukiBackend.Models;

namespace TukiTukiBackend.Services;

public class ProductService : ICRUDService<Product>
{
    private List<Product> _products = new List<Product>()
    {
        new Product("prueba", "70", "prueba")
    };

    public IEnumerable<Product> getAll()
    {
        return _products.ToList();
    }

    public Product? getById(int id)
    {
        throw new NotImplementedException();
    }

    public Product create(Product product)
    {
        product.id = _products.Count + 1;
        _products.Add(product);
        return product;

    }

    public void delete(int id)
    {
        throw new NotImplementedException();
    }
}