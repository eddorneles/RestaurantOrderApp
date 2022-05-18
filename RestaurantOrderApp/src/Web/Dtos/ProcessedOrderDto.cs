using System;
using System.Collections.Generic;
using System.Linq;

using RestaurantOrderApp.Domain.Models;

namespace RestaurantOrderApp.Web.Dtos {
    public class ProcessedOrderDto {

        public string Output {get;set;}
        
        public ProcessedOrderDto( RestaurantOrder restaurantOrder ) {
            this.Output = this.BuildOrderOutput( restaurantOrder );
        }

        public ProcessedOrderDto( RestaurantOrder restaurantOrder, bool error ) {
            this.Output = this.BuildOrderOutput( restaurantOrder );

        }

        private string BuildOrderOutput( RestaurantOrder restaurantOrder ){

            if( restaurantOrder is null ){
                return "error";
            }
            List<string> output = new();
            var orderedDishes =  restaurantOrder.GetDishes();
            orderedDishes.Sort( delegate( Dish d1, Dish d2 ){
                return d1.TypeNumber.CompareTo( d2.TypeNumber );
            } );
            foreach( var dish in orderedDishes ){
                var dishOutput = $"{dish.Name}";
                if( restaurantOrder.GetDishQuantityByTypeNumber( dish.TypeNumber ) > 1 ){
                    dishOutput += $"({restaurantOrder.GetDishQuantityByTypeNumber(dish.TypeNumber)})";
                }
                output.Add( dishOutput );
            }
            if( restaurantOrder.HasError() ) output.Add( "error" );
            return String.Join( ", ", output );
        }
        

    }//END class
}//END namespace
