using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using RestaurantOrderApp.Web.Dtos;
using RestaurantOrderApp.Domain.Models;
using RestaurantOrderApp.Domain.Interfaces.Business;
using RestaurantOrderApp.Domain.Exceptions;


namespace RestaurantOrderApp.Web.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class RestaurantOrderController : ControllerBase {

        private readonly ILogger<RestaurantOrderController> _logger;
        private readonly IRestaurantOrderBusiness RestaurantOrderBusiness;

        public RestaurantOrderController(ILogger<RestaurantOrderController> logger, 
                IRestaurantOrderBusiness restaurantOrderBusiness ){
            
            _logger = logger;
            this.RestaurantOrderBusiness = restaurantOrderBusiness;
        }

        [HttpGet]
        public IEnumerable<Dish> Get()
        {
            throw new NotImplementedException();
            
        }

        [HttpPost]
        public IActionResult Post( CreateRestaurantOrderDto createOrderDto ){
            try{
                RestaurantOrder processedOrder = this.RestaurantOrderBusiness.ProcessOrder( createOrderDto.Codification );
                var processedOrderDto = new ProcessedOrderDto(processedOrder);
                return Ok( processedOrderDto );
            }catch( ProcessOrderException e ){
                var orderWithError = e.RestaurantOrderWithError;
                ProcessedOrderDto processedOrderWithErrorDto = new ProcessedOrderDto(orderWithError);
                return BadRequest( processedOrderWithErrorDto );
            }
        }

    }//END class
}//END namespace