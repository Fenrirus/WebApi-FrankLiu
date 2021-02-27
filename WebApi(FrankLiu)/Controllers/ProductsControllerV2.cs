using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiFrankLiu.Filters;
using WebApiFrankLiu.Models;

namespace WebApiFrankLiu.Controllers
{
    [Route("api/v2/products")]
    [ApiController]
    // Dodałem w startup więc działa globalnie
    [DebugResourceFilter1]
    [DebugActionFilter]
    public class ProductsControllerV2 : ControllerBase
    {
        /*[HttpGet]
        public string Get()
        {
            return "Lots of produtcs";
        }*/

        [HttpGet("{id}")]
        [DebugResourceFilter2]
        public string GetById(int id, [FromQuery] bool isActive)
        {
            return $"Lots of produtcs: {id}, status: {isActive}";
        }

        [HttpGet]
        public string GetByObject([FromQuery] Product productDTO)
        {
            return $"Product id {productDTO.Id} has name: {productDTO.Name}";
        }

        [HttpGet("daterange")]
        [CheckDateRangeFilter]
        public string GetByDate(DateTime startDate, DateTime endDate)
        {
            return "This is list of products";
        }

        [HttpPost]
        public IActionResult PostObject([FromBody] Product productDTO)
        {
            return Ok($"Product id {productDTO.Id} has name: {productDTO.Name}");
        }
    }
}