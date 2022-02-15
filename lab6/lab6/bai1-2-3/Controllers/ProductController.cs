
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

public class ProductController : Controller
{
    public ProductService _products;
    public ProductController(ProductService products)
    {
        _products = products;
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(ProductModel product)
    {
        if(product.Price != 0 || product.Quantity != 0)
            _products.Add(product);
        return RedirectToAction("Index");
    }

    public IActionResult Index()
    {
        return View(_products);
    }

}