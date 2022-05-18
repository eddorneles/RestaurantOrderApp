using System;
using System.Linq;
using System.Collections.Generic;
using RestaurantOrderApp.Web.Dtos;
using RestaurantOrderApp.Domain.Models;
using RestaurantOrderApp.Domain.Enums;

namespace RestaurantOrderApp.Web.Dtos.Converters {
    public class RestaurantOrderDtoConverter {
        
        public static RestaurantOrder Convert( CreateRestaurantOrderDto createOrderDto ){
            var orderParameters = createOrderDto.Codification.Split(",").ToList();
            if( orderParameters.Count <= 1 ) throw new ArgumentException( $"Invalid order codification parameters number. " +
                    "At least 2 comma separated parameters are necessary." );
            // Enum.TryParse<TimeOfDayEnum>( orderParameters[0], true, out TimeOfDayEnum timeOfDayEnum );
            if( IsTimeOfDayNotValid( orderParameters[0], out TimeOfDayEnum timeOfDayEnum ) )
                    throw new ArgumentException( $"Invalid order time of day. The first parameter must be 'morning' or 'night'." );
            throw new NotImplementedException();
        }

        private static bool IsTimeOfDayNotValid( string timeOfDay, out TimeOfDayEnum timeOfDayEnum ){
            return !Enum.TryParse<TimeOfDayEnum>( timeOfDay, true, out timeOfDayEnum );
        }

    }//END class
}//END namespace
