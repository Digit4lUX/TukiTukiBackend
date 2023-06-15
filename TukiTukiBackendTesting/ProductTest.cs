using Microsoft.AspNetCore.Mvc;
using TukiTukiBackend.Controllers;
using TukiTukiBackend.Models;
using TukiTukiBackend.Services;

namespace TukiTukiBackendTesting;

public class ProductTest
{
    private readonly ProductController _productController;
    private readonly ProductService _productService;
    
    public ProductTest()
    {
        _productController = new ProductController(_productService);
        _productService = new ProductService();
    }
    
    [Fact]
    public void RegisterProductTest()
    {
        Product product = new Product("prueba", "70", "prueba");
        
        var result = _productController.create(product);
        Assert.NotNull(result);
        Assert.IsType<ActionResult<User>>(result);
    }
}