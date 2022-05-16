using System;

using RestaurantOrderApp.Domain.Enums;

namespace RestaurantOrderApp.Domain.Models
{
    public class Dish {
        public string Name { get; set; }
        public DishType Type {get;set;}
        public TimeOfDayEnum Availability {get;set;}
        
    }//END class
}//END namespace
