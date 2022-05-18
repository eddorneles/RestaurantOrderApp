using System;

using RestaurantOrderApp.Domain.Enums;

namespace RestaurantOrderApp.Domain.Models
{
    public class Dish {
        public int TypeNumber {get;set;}
        public string Name { get; set; }
        public TimeOfDayEnum TimeAvailability {get;set;}
        public bool IsMultipleOrderAllowed {get;set;}

        public Dish( TimeOfDayEnum timeAvailability ){
            this.TimeAvailability = timeAvailability;
        }
        
    }//END class
}//END namespace
