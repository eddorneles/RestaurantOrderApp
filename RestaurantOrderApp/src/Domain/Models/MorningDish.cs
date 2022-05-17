using System;

using RestaurantOrderApp.Domain.Enums;

namespace RestaurantOrderApp.Domain.Models
{
    public class MorningDish {
        public string Name { get; set; }
        public DishType Type {get;set;}
        public TimeOfDayEnum TimeAvailability {get;set;}
        public bool IsMultipleOrderAllowed {get;set;}

        
        
    }//END class
}//END namespace
