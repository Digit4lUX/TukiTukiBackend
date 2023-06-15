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
        
        _productService = new ProductService();
        _productController = new ProductController(_productService);
    }
    
    [Fact]
    public void RegisterProductTest()
    {
        Product product = new Product();
        product.id = 1;
        product.title = "prueba";
        product.price = "50";
        product.details = "prueba";
        var result = _productController.create(product);
        Assert.IsType<CreatedResult>(result.Result);
    }
}