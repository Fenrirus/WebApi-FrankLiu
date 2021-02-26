using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_FrankLiu_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        /*[HttpGet]
        public string Get()
        {
            return "Lots of produtcs";
        }*/

        [HttpGet("{id}")]
        public string GetById(int id, [FromQuery] bool isActive)
        {
            return $"Lots of produtcs: {id}, status: {isActive}";
        }

        [HttpGet]
        public string GetByObject([FromQuery] ProductDTO productDTO)
        {
            return $"Product id {productDTO.Id} has name: {productDTO.Name}";
        }

        [HttpPost]
        public IActionResult PostObject([FromBody] ProductDTO productDTO)
        {
            return Ok($"Product id {productDTO.Id} has name: {productDTO.Name}");
        }
    }

    public class ProductDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}