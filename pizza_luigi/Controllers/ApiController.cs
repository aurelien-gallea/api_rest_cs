﻿using Microsoft.AspNetCore.Mvc;
using pizza_luigi.Data;
using pizza_luigi.Models;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace pizza_luigi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ApiController : Controller
    {
        private readonly DataContext dataContext;

        public ApiController(DataContext context)
        {
            this.dataContext = context;
        }

        //public IList<Pizza> Pizza { get; set; }

        // GET: api/<ApiController>
        [HttpGet]
        [Route("test")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet]
        [Route("GetPizzas")]
        public IActionResult GetPizzas()
        {
            var pizza = dataContext.Pizzas.ToList();
            return Json(pizza);
        }
    }
}
