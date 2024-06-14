using Dapper;
using Microsoft.AspNetCore.Mvc;
using Npgsql;
using Task3.Entity;
using Task3.Services;
using Task3.Services.ServicesInterfaces;

namespace Task3.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    public class CategoryController : Controller

    {
        //private readonly NpgsqlConnection _connection;
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
            // _connection = connection;
        }


        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var response = _categoryService.GetById(id);

            if (response.IsSuccess)
                return Ok(response);
            else
                return NotFound(response);

        }

        [HttpGet]
        public IActionResult GetAll() {

            var response = _categoryService.GetAll();


            if (response.IsSuccess)
                return Ok(response);
            else
                return NotFound(response);

        }


        [HttpDelete("{id}")]

        public IActionResult Delete(int id)
        {
            var response = _categoryService.Delete(id);

            if (response.IsSuccess)
                return Ok(response);
            else
                return NotFound(response);
        }


        [HttpPost]
        public IActionResult Add(CategoryRequestDto categoryRequestDto) {
            var response = _categoryService.Add(categoryRequestDto);
            if (response.IsSuccess)
                return Ok(response);
            else
                return NotFound(response);

        }
        [HttpPut("{id}")]
        public IActionResult Update(int id, CategoryRequestDto categoryRequestDto)
        {

            var response = _categoryService.Update(id, categoryRequestDto);

            if (response.IsSuccess)
                return Ok(response);
            else
                return NotFound(response);

        }

        



    }


}
