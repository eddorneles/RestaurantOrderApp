using System;
using System.Collections.Generic;

using RestaurantOrderApp.Domain.Enums;

namespace RestaurantOrderApp.Domain.Models
{
    public class RestaurantOrder {
        private Dictionary<int,Dish> Dishes {get;set;}
        private Dictionary<int,int> DishQuantity {get;set;}
        private TimeOfDayEnum TimeOfDay {get;set;}

        public RestaurantOrder( TimeOfDayEnum timeOfDay ){
            this.Dishes = new Dictionary<int, Dish>();
            this.DishQuantity = new Dictionary<int, int>();
            this.TimeOfDay = timeOfDay;
        }

        public void AddDish( Dish dish ){
            if( dish is null ) throw new ArgumentNullException( "A non-existent dish can't be ordered." );
            if( !dish.TimeAvailability.Equals( this.TimeOfDay ) ){
                throw new ArgumentException( 
                    $"The dish time availability is '{dish.TimeAvailability.ToString()}' can't be different from order time of day." );
            }
            if( this.IsDishAlreadyOrdered( dish ) ){
                if( !dish.IsMultipleOrderAllowed ) {
                    throw new ArgumentException( $"The dish '{dish.Name}' can't be ordered more than once." );
                }
                this.DishQuantity[dish.TypeNumber]++;
                return;
            }
            this.Dishes.Add( dish.TypeNumber, dish );
            this.DishQuantity.Add(dish.TypeNumber, 1 );
        }//END AddDish()

        public bool IsDishAlreadyOrdered( Dish dish ){
            return this.Dishes.ContainsKey( dish.TypeNumber );
        }

        public Dish GetDishByTypeNumber( int typeNumber ){
            return this.Dishes.GetValueOrDefault( typeNumber, null );
        }

        public int GetDishQuantityByTypeNumber( int typeNumber ){
            return this.DishQuantity.GetValueOrDefault( typeNumber, 0 );
        }

        public IEnumerable<int> GetOrderedDisheTypesNumber(){
            return this.Dishes.Keys;
        }

        public IEnumerable<Dish> GetOrderedDishes(){
            return this.Dishes.Values;
        }
        
    }//END class
}//END namespace
