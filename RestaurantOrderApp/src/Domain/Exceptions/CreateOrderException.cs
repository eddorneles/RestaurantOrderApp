using System;
using System.Collections.Generic;

using RestaurantOrderApp.Domain.Enums;
using RestaurantOrderApp.Domain.Models;

namespace RestaurantOrderApp.Domain.Exceptions {
    public class ProcessOrderException : Exception {
        
        public RestaurantOrder RestaurantOrderWithError {get;}
        public ProcessOrderException( string message, RestaurantOrder restaurantOrder ) : base( message ){
            this.RestaurantOrderWithError = restaurantOrder;
        }//END constructor

        public ProcessOrderException( string message, 
                RestaurantOrder restaurantOrder, 
                Exception innerException ) : base( message, innerException ){
            this.RestaurantOrderWithError = restaurantOrder;
        }//END constructor
        
    }//END class
}//END namespace