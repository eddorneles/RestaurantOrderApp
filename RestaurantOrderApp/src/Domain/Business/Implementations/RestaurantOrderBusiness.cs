using System;
using System.Linq;
using System.Collections.Generic;

using RestaurantOrderApp.Domain.Enums;
using RestaurantOrderApp.Domain.Models;
using RestaurantOrderApp.Domain.Exceptions;
using RestaurantOrderApp.Domain.Interfaces.Business;
using RestaurantOrderApp.Domain.Interfaces.Repositories;


namespace RestaurantOrderApp.Domain.Business.Implementations {
    public class RestaurantOrderBusiness : IRestaurantOrderBusiness {

        private readonly IDishRepository DishRepository;
        private readonly IRestaurantOrderRepository RestaurantOrderRepository;

        public RestaurantOrder ProcessOrder( string orderCodification ){
            var orderParameters = orderCodification.Split(",").ToList();
            if( orderParameters.Count <= 1 ) throw new ProcessOrderException( $"Invalid order codification parameters number. " +
                    "At least 2 comma separated parameters are necessary.", null );

            throw new NotImplementedException();
        }

        private RestaurantOrder CreateOrder( IList<string> orderParameters ){
            RestaurantOrder newRestaurantOrder = null;
            try{
                if( IsTimeOfDayNotValid( orderParameters[0], out TimeOfDayEnum timeOfDayEnum ) )
                        throw new ArgumentException( $"Invalid order time of day. The first parameter must be 'morning' or 'night'." );
                
                orderParameters.RemoveAt(0);
                newRestaurantOrder = new RestaurantOrder( timeOfDayEnum );
                foreach ( var typeNumberParam in orderParameters ){
                    if( this.IsDishTypeNumberParamNotInt( typeNumberParam, out int dishTypeNumber ) )
                        throw new ArgumentException( $"Invalid dish type number. The value '{typeNumberParam}' can't be converted to int" );
                    var dish = this.DishRepository.GetByTypeNumberAndTimeOfDay( dishTypeNumber, timeOfDayEnum );
                    newRestaurantOrder.AddDish( dish );
                }
                newRestaurantOrder = this.RestaurantOrderRepository.Add( newRestaurantOrder );
                return newRestaurantOrder;
            }catch( Exception e ){
                throw new ProcessOrderException( e.Message, newRestaurantOrder, e );
            }
            
            
        }//END 

        private bool IsTimeOfDayNotValid( string timeOfDay, out TimeOfDayEnum timeOfDayEnum ){
            return !Enum.TryParse<TimeOfDayEnum>( timeOfDay, true, out timeOfDayEnum );
        }

        private bool IsDishTypeNumberParamNotInt( string typeNumberParam, out int dishTypeNumber ){
            return !int.TryParse( typeNumberParam, out dishTypeNumber );
        }

    }//END class
}//END namespace
