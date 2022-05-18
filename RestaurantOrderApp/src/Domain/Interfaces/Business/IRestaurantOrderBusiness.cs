using System;

using RestaurantOrderApp.Domain.Enums;
using RestaurantOrderApp.Domain.Models;
using RestaurantOrderApp.Web.Dtos;

namespace RestaurantOrderApp.Domain.Interfaces.Business {
    public interface IRestaurantOrderBusiness {
        public RestaurantOrder ProcessOrder( string orderCodification );

    }//END class
}//END namespace
