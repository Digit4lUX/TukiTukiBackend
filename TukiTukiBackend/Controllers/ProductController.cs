﻿using Microsoft.AspNetCore.Mvc;
using TukiTukiBackend.Models;
using TukiTukiBackend.Services;

namespace TukiTukiBackend.Controllers;
[Route("api/[controller]")]
[ApiController]

public class ProductController : ControllerBase
{
    private readonly ProductService _productService;

    public ProductController(ProductService productService)
    {
        _productService = productService;
    }


    [HttpGet]
    public ActionResult<Product> getAll()
    {
        var result = _productService.getAll();
        return Ok(result);
    }
    
    [HttpPost]
    public ActionResult<Product> create(Product product)
    {
        var result = _productService.create(product);
        return Created("api/products", result);
    }
    
}