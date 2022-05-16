using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using RestaurantOrderApp.Domain.Models;

namespace RestaurantOrderApp.Web.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class DishesController : ControllerBase {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<DishesController> _logger;

        public DishesController(ILogger<DishesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Dish> Get()
        {
            throw new NotImplementedException();
            
        }
    }
}//END namespace