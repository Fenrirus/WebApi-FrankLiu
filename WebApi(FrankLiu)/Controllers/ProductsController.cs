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
        [HttpGet]
        public string Get()
        {
            return "Lots of produtcs";
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return $"Lots of produtcs: {id}";
        }
    }
}