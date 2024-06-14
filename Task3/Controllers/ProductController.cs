using Microsoft.AspNetCore.Mvc;
using System;
using System.Runtime.CompilerServices;
using Task3.Services;
using Task3.Services.ServicesInterfaces;

[ApiController]
[Route("/[controller]")]
public class ProductController : Controller
{

    private readonly IProductService _productService;

    public ProductController(IProductService productService) {
        _productService = productService;
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var response =  _productService.GetById(id);

        if (response.Result.IsSuccess)
            return Ok(response.Result);
        else
            return NotFound(response);

    }

    [HttpGet]
    public IActionResult GetAll()
    {

        var response = _productService.GetAll();


        if (response.IsSuccess)
            return Ok(response);
        else
            return NotFound(response);

    }

    [HttpDelete("{id}")]

    public IActionResult Delete(int id)
    {
        var response = _productService.Delete(id);

        if (response.IsSuccess)
            return Ok(response);
        else
            return NotFound(response);
    }

    [HttpPost]
    public IActionResult Add([FromForm]ProductRequestDto productRequestDto)
    {
        var response = _productService.Add(productRequestDto);
        if (response.IsSuccess)
            return Ok(response);
        else
            return NotFound(response);

    }
    [HttpPut("{id}")]
    public IActionResult Update(int id, ProductRequestDto productRequestDto)
    {

        var response = _productService.Update(id, productRequestDto);

        if (response.Result.IsSuccess)
            return Ok(response);
        else
            return NotFound(response);

    }








}
